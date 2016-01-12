using Client.Factory;
using Client.Model;
using System;
using System.Net;

namespace Client.Service.Login
{
    public class LoginClient
    { 
        #region Delegates
        public delegate void CredentialsChangedDelegate(string token);
        #endregion

        #region Events
        public event CredentialsChangedDelegate CredentialsChanged;
        #endregion

        private static LoginClient Client = null;
        private AccountFactory Factory = new AccountFactory();
        private Account Account = null;

        private LoginClient()
        {

        }

        public string GetToken()
        {
            return (this.Account == null) ? null : this.Account.Token;
        }

        public void Login(string password, Action<bool> callback)
        {
            Factory.FindByIdAsync(password, (Account account, HttpStatusCode status) =>
            {
                if (status == HttpStatusCode.NotFound)
                {
                    callback(false);
                }
                else
                {
                    this.Account = account;
                    this.CredentialsChanged(this.Account.Token);
                    callback(true);
                }
            });
        }

        public static LoginClient GetInstance()
        {
            if (Client == null)
            {
                Client = new LoginClient();
            }

            return Client;
        }
    }
}
