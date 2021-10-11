using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;
using PracticaFinal.Repository.Accounts;

namespace PracticaFinal.Repository.Transactions
{
    public class TransactionInMemory : ITransactionRepository
    {
        //Properties.
        private readonly List<Transaction> transactions;

        //Constructor.
        public TransactionInMemory() => transactions = new List<Transaction>()
            {
                //Account = 20105136.
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20105136,
                    AccountTo = 20235624,
                    Amount = 20500,
                    TransDate = new DateTime(2021, 10, 9, 13, 53, 21),
                    TransDescription = "Transacción no. 64512315"
                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20105136,
                    AccountTo = 51254826,
                    Amount = 1862,
                    TransDate = new DateTime(2021, 10, 8, 12, 25, 30),
                    TransDescription = "Transacción no. 64513234"

                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20105136,
                    AccountTo = 20235624,
                    Amount = 5089,
                    TransDate = new DateTime(2021, 10, 09, 18, 21, 02),
                    TransDescription = "Transacción no. 23123245"
                },

                 //Account = 20235624.
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20235624,
                    AccountTo = 20105136,
                    Amount = 12350,
                    TransDate = new DateTime(2021, 8, 14, 15, 23, 51),
                    TransDescription = "Transacción no. 12312334"
                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20235624,
                    AccountTo = 51254826,
                    Amount = 6752,
                    TransDate = new DateTime(2021, 10, 2, 11, 54, 3),
                    TransDescription = "Transacción no. 62312312"

                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 20235624,
                    AccountTo = 62548214,
                    Amount = 7879,
                    TransDate = new DateTime(2021, 10, 5, 14, 5, 2),
                    TransDescription = "Transacción no. 64534534"
                },

                //Account = 51254826.
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 51254826,
                    AccountTo = 20105136,
                    Amount = 56756,
                    TransDate = new DateTime(2021, 8, 14, 15, 23, 51),
                    TransDescription = "Transacción no. 67675456"
                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 51254826,
                    AccountTo = 20235624,
                    Amount = 4565,
                    TransDate = new DateTime(2021, 10, 2, 11, 54, 3),
                    TransDescription = "Transacción no. 34244556"

                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 51254826,
                    AccountTo = 62548214,
                    Amount = 5677,
                    TransDate = new DateTime(2021, 10, 4, 20, 4, 8),
                    TransDescription = "Transacción no. 23423457"
                },

                //Account = 62548214.
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 62548214,
                    AccountTo = 20105136,
                    Amount = 12345,
                    TransDate = new DateTime(2021, 10, 09, 23, 23, 51),
                    TransDescription = "Transacción no. 85645635"
                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 62548214,
                    AccountTo = 20235624,
                    Amount = 9878,
                    TransDate = new DateTime(2021, 10, 1, 13, 54, 3),
                    TransDescription = "Transacción no. 89778544"

                },
                new Transaction()
                {
                    TransNumber = 1,
                    AccountFrom = 62548214,
                    AccountTo = 51254826,
                    Amount = 3423,
                    TransDate = new DateTime(2021, 10, 10, 18, 2, 9),
                    TransDescription = "Transacción no. 12312345"
                }
            };


        //Methods.
        public void CreateTransaction(Transaction transaction) =>
            transactions.Add(transaction);

        public List<Transaction> GetTransactions(int accountFrom, DateTime? initialDate = null, DateTime? finalDate = null)
        {
            if (initialDate == null)
            {
                initialDate = new DateTime(1900, 01, 01);
                finalDate = DateTime.Now;
            }
            return transactions.FindAll(t => t.AccountFrom.Equals(accountFrom) || t.AccountTo.Equals(accountFrom)
             && (initialDate <= t.TransDate && t.TransDate <= finalDate));
        }
    }
}
