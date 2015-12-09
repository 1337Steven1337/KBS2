using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using Excel;
using Client.View.Account;
using System.Security.Cryptography;
using System.Net;
using RestSharp;
using Client.Service.Email;

namespace Client.Controller.Account
{
    public class AddAccountController : AbstractController<Model.Account>
    {
        static readonly char[] AvailableCharacters = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        private IAddAccountView View { get; set; }
        private AccountFactory Factory = new AccountFactory();
        private Dictionary<string, string> UsedPasswords = new Dictionary<string, string>();
        private IEmailClient EmailClient { get; set; }

        public AddAccountController(IAddAccountView view) : this(view, new EmailClient())
        {

        }
        public AddAccountController(IAddAccountView view, IEmailClient client)
        {
            this.EmailClient = new EmailClient();
            this.View = view;
            this.View.SetController(this);
        }

        private void AccountSaved(Model.Account account, HttpStatusCode code, IRestResponse response)
        {
            if(code == HttpStatusCode.Created)
            {
                //this.EmailClient.send() 
            } 
            else
            {
                this.View.ShowSaveFailed();
            }
        }

        private string Sha256(string value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Join("", hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }

        private string GeneratePassword(int length, string student)
        {
            char[] identifier = new char[length];
            byte[] randomData = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomData);
            }

            for (int idx = 0; idx < identifier.Length; idx++)
            {
                int pos = randomData[idx] % AvailableCharacters.Length;
                identifier[idx] = AvailableCharacters[pos];
            }

            string password = new string(identifier);

            if(this.UsedPasswords.Select(x => x.Value == password).Count() > 0)
            {
                password = this.GeneratePassword(length, student);
            }

            this.UsedPasswords.Add(student, password);

            return this.Sha256(password);
        }

        private void ProcessUser(Row row)
        {
            Model.Account account = new Model.Account();
            account.Student = row.Cells[1].Text.ToLower();
            account.Password = this.GeneratePassword(5, account.Student);

            this.Factory.Save(account, this.View.GetHandler(), this.AccountSaved);
        }

        public void ProcessFile(string path)
        {
            UsedPasswords.Clear();
            IEnumerable<worksheet> sheets = Workbook.Worksheets(path);

            if(sheets.Count() > 0)
            {
                foreach (worksheet sheet in sheets)
                {
                    IEnumerable<Row> rows = sheet.Rows;

                    for(int i = 1; i < rows.Count(); i++)
                    {
                        this.ProcessUser(rows.ElementAt(i));
                    }
                }
            }
            else
            {
                this.View.ShowLoadFailed();
            }
        }

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
    }
}
