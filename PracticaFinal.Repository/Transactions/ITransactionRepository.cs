using PracticaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Repository.Transactions
{
    public interface ITransactionRepository
    {
        public List<Transaction> GetTransactions(int accountFrom, DateTime initialDate, DateTime finalDate);
        public void CreateTransaction(Transaction transaction);
    }
}
