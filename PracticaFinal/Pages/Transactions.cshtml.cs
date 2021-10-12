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
        [BindProperty]
        public DateTime date1 { get; set; }
        [BindProperty]
        public DateTime date2 { get; set; }

        public Transaction transaction;
        public List<Transaction> transactions;
        private readonly ITransactionRepository transactionRepository;

        //Constructor.
        public TransactionsModel(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        //Methods.
        public IActionResult OnGet()
        {
            if (TempData["AccountNumber"] != null && !TempData["AccountNumber"].ToString().Equals("0"))
            {
                date1 = DateTime.Now.AddMonths(-1);
                date2 = DateTime.Now;
                transactions = transactionRepository.GetTransactions(AccountNumber, date1, date2);
                AccountNumber = (int)TempData["AccountNumber"];
                TempData.Keep("AccountNumber");
                return Page();
            }
            return RedirectToPage("./Error");
        }

        public IActionResult OnPost()
        {
            transactions = transactionRepository.GetTransactions(AccountNumber, date1, date2);
            AccountNumber = (int)TempData["AccountNumber"];
            TempData.Keep("AccountNumber");
            return Page();
        }
    }
}
