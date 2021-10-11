using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticaFinal.Models;
using PracticaFinal.Repository;
using PracticaFinal.Repository.Accounts;

namespace PracticaFinal.Pages
{
    public class HomeModel : PageModel
    {

        //Properties.
        private int _id;
        public List<Account> accounts;
        [BindProperty]
        public int AccountNumber { get; set; }
        public Client client { get; set; }
        private readonly IClientRepository clientRepository;
        private readonly IAccountRepository accountRepository;

        //Constructor.
        public HomeModel(IClientRepository clientRepository, IAccountRepository accountRepository)
        {
            this.clientRepository = clientRepository;
            this.accountRepository = accountRepository;
           
        }

        //Methods.
        public IActionResult OnGet()
        {
            if (TempData["ClientId"] != null)
            {
                _id = (int)TempData["ClientId"];
                TempData.Keep("ClientId");
                client = clientRepository.GetClient(_id);
                accounts = accountRepository.GetAccounts(_id);
                return Page();
            }
            return RedirectToPage("./Error");
        }

        public IActionResult OnPost()
        {
            TempData["AccountNumber"] = AccountNumber;
            TempData.Keep("AccountNumber");

            return RedirectToPage("./Transactions");
        }
    }
}
