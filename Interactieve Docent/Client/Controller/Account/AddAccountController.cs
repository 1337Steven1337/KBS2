using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Factory;
using Client.View;
using Excel;
using Client.View.Account;
using System.Security.Cryptography;
using System.Net;
using RestSharp;
using Client.Service.Email;
using Client.Service.Generate;


namespace Client.Controller.Account
{
    public class AddAccountController : AbstractController<Model.Account>
    {


        #region Instances
        private IAddAccountView View { get; set; }
        private IEmailClient EmailClient { get; set; }

        private AccountFactory Factory = new AccountFactory();
        private Dictionary<string, string> UsedPasswords = new Dictionary<string, string>();
        private Dictionary<string, int> AccountSaveResults = new Dictionary<string, int>();
        private List<Model.Account> Accounts = new List<Model.Account>();
        #endregion

        #region Constructors
        public AddAccountController(IAddAccountView view) : this(view, new EmailClient())
        {

        }
        public AddAccountController(IAddAccountView view, IEmailClient client)
        {
            this.EmailClient = new EmailClient();
            this.View = view;
            this.View.SetController(this);
        }
        #endregion

        #region Events
        private void AccountSaved(Model.Account account, HttpStatusCode code, IRestResponse response)
        {
            if(code == HttpStatusCode.Created)
            {
                try
                {
                    this.EmailClient.Send(account.Student, this.UsedPasswords[account.Student]);
                    this.AccountSaveResults[account.Student] = 1;
                    this.View.UpdateProgressBar();
                }
                catch (Exception)
                {
                    this.AccountSaveResults[account.Student] = 3;
                }
            } 
            else
            {
                this.AccountSaveResults[account.Student] = 2;
            }

            if(this.AccountSaveResults.ContainsValue(0))
            {

            }
            else if ((this.AccountSaveResults.ContainsValue(2) || this.AccountSaveResults.ContainsValue(3)))
            {
                this.View.ShowSaveFailed(this.AccountSaveResults);
                this.View.EnableButton();
            }
            else
            {
                this.View.ShowSaveSucceed();
                this.View.EnableButton();
            }
        }
        #endregion

        #region Methods

        private string GeneratePassword(int length,string student)
        {
            string password = Client.Service.Generate.Token.GenerateToken(length);

            if (this.UsedPasswords.ContainsValue(password))
            {
                password = this.GeneratePassword(length, student);
            }

            this.UsedPasswords.Add(student, password);

            return password;

        }


        private void ProcessUser(Row row)
        {
            Model.Account account = new Model.Account();
            account.Student = row.Cells[1].Text.ToLower();
            account.Password = Token.Sha256(this.GeneratePassword(6, account.Student));
            account.Pincode_Id = Client.Properties.Settings.Default.Session_Id.ToString();
            this.Accounts.Add(account);
            this.AccountSaveResults.Add(account.Student, 0);
        }

        private void SaveAccounts()
        {
            foreach (Model.Account account in this.Accounts)
            {
                this.Factory.Save(account, this.View.GetHandler(), this.AccountSaved);
            }
        }

        public void ProcessFile(string path)
        {
            UsedPasswords.Clear();
            AccountSaveResults.Clear();
            Accounts.Clear();

            IEnumerable<worksheet> sheets = Workbook.Worksheets(path);

            if (sheets.Count() > 0)
            {
                foreach (worksheet sheet in sheets)
                {
                    IEnumerable<Row> rows = sheet.Rows;

                    for (int i = 1; i < rows.Count(); i++)
                    {
                        this.ProcessUser(rows.ElementAt(i));
                    }
                }

                if (this.Accounts.Count > 0)
                {
                    this.View.DisableButton();
                    this.View.ResetProgressBar(1, this.Accounts.Count);
                    this.SaveAccounts();
                }
                else
                {
                    this.View.ShowNoAccountsFound();
                }
            }
            else
            {
                this.View.ShowLoadFailed();
            }
        }
        #endregion

        #region Overrides
        public override IView GetView()
        {
            return this.View;
        }

        public override void SetBaseFactory(IFactory<Model.Account> baseFactory)
        {
            this.Factory.SetBaseFactory(baseFactory);
        }

        public override void SetView(IView view)
        {
            this.View = (IAddAccountView)view;
        }
        #endregion
    }
}
