using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;

namespace PracticaFinal.Repository.Accounts
{
    public interface IAccountRepository
    {
        public List<Account> GetAccounts(int ClientID);
        public List<Account> GetAnothersAccounts(int ClientID);
        public Account GetAccount(int AccountId);
        public int GetNumberFromAmount(string Amount);
        public Account UpdateBalance(int Account, double balance, bool IsAdding);
    }
}
