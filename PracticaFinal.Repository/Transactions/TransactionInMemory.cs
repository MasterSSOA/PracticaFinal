using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;

namespace PracticaFinal.Repository.Transactions
{
    public class TransactionInMemory : ITransactionRepository
    {
        //Properties.
        private readonly List<Transaction> transactions;

        //Constructor.
        public TransactionInMemory()
        {
            transactions = new List<Transaction>()
            {
                new Transaction()
                {
                    AccountFrom = 20105136,
                    AccountTo = 20235624,


                }
            };
        }
        public List<Transaction> GetTransactions(int From, int To, DateTime initialDate, DateTime finalDate)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactions(Account From, Account To, DateTime initialDate, DateTime finalDate)
        {
            throw new NotImplementedException();
        }

    }
}
