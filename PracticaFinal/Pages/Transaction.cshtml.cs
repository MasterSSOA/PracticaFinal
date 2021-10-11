using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaFinal.Models;
using PracticaFinal.Repository.Accounts;
using PracticaFinal.Repository.Transactions;

namespace PracticaFinal.Pages
{
    public class TransactionModel : PageModel
    {

        //Properties.
        [TempData]
        public int ClientId { get; set; }
        [BindProperty]
        public Transaction transaction { get; set; }
        [BindProperty]
        public string accountFrom { get; set; }
        [BindProperty]
        public string accountTo { get; set; }

        private int _id;
        public string Type;
        private List<Account> accounts;
        public IEnumerable<SelectListItem> accountsTo;
        public IEnumerable<SelectListItem> accountsFrom;
        private readonly IAccountRepository accountRepository;
        private readonly ITransactionRepository transactionRepository;

        //Constructor.
        public TransactionModel(IAccountRepository accountRepository, ITransactionRepository transactionRepository)
        {
            this.accountRepository = accountRepository;
            this.transactionRepository = transactionRepository;
        }

        //Methods.
        public IActionResult OnGet(string Type)
        {
            if (TempData["ClientId"] != null)
            {
                _id = (int)TempData["ClientId"];
                TempData.Keep("ClientId");
                this.Type = Type;
                accounts = accountRepository.GetAccounts(_id);
                accountsFrom = new SelectList(accounts, nameof(Account.AccountBalance), nameof(Account.AccountNumber), null);
                accountsTo = new SelectList(accounts, nameof(Account.AccountBalance), nameof(Account.AccountNumber), null);
                return Page();
            }
            return RedirectToPage("./Error");
        }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
                return Page();            

            //Obteniendo datos de la transacción.
            transaction.AccountFrom = accountRepository.GetNumberFromAmount(accountFrom);
            transaction.AccountTo = accountRepository.GetNumberFromAmount(accountTo);
            transaction.TransDescription = "Transacción no. " + RandomDigits(10);
            transaction.TransDate = DateTime.Now;

            //Creando transacción.
            transactionRepository.CreateTransaction(transaction);
            accountRepository.UpdateBalance(transaction.AccountFrom, transaction.Amount, false);
            accountRepository.UpdateBalance(transaction.AccountTo, transaction.Amount, true);
            return RedirectToPage("./Home");
        }

        public string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
    }
}
