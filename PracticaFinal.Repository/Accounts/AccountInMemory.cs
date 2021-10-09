using PracticaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Repository.Accounts
{
    public class AccountInMemory : IAccountRepository
    {
        //Properties.
        private readonly List<Account> accounts;
        ClientInMemory clientInMemory = new ClientInMemory();

        //Constructor.
        public AccountInMemory() => accounts = new List<Account>()
            {
                new Account()
                {
                    AccountNumber = 20105136,
                    AccountBalance = 124560.50,
                    ClientId = 1,
                    Client = clientInMemory.GetClient(1)
                },
                new Account()
                {
                    AccountNumber = 20235624,
                    AccountBalance = 40860.20,
                    ClientId = 1,
                    Client = clientInMemory.GetClient(1)
                },
                new Account()
                {
                    AccountNumber = 51254826,
                    AccountBalance = 080582.50,
                    ClientId = 2,
                    Client = clientInMemory.GetClient(2)
                },
                new Account()
                {
                    AccountNumber = 62548214,
                    AccountBalance = 58020.20,
                    ClientId = 2,
                    Client = clientInMemory.GetClient(2)
                }
            };

        //Methods.
        public List<Account> GetAccounts(int ClientID) => 
            accounts.FindAll(a => a.ClientId.Equals(ClientID));

        public Account GetAccount(int AccountId) => 
            accounts.Find(a => a.AccountNumber.Equals(AccountId));
    }
}
