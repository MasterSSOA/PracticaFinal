using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaFinal.Models;
using PracticaFinal.Repository.Transactions;

namespace PracticaFinal.Pages
{
    public class TransactionsModel : PageModel
    {
        //Properties.
        [TempData]
        public int AccountNumber { get; set; }
        public Transaction transaction;
        public List<Transaction> transactions;
        private readonly ITransactionRepository transactionRepository;


        //Constructor.
        public TransactionsModel(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }


        //Methods.
        public void OnGet()
        {
            if (TempData["AccountNumber"] != null)
            {
                transactions = transactionRepository.GetTransactions(AccountNumber);
                AccountNumber = (int)TempData["AccountNumber"];
                TempData.Keep("AccountNumber");
            }
        }
    }
}
