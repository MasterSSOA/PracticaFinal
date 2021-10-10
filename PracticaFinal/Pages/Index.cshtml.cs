using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PracticaFinal.Models;
using PracticaFinal.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaFinal.Pages
{
    public class IndexModel : PageModel
    {
        //Properties.
        private readonly ILogger<IndexModel> _logger;
        public User user;
        public Client client;


        //Constructor.
        public IndexModel(ILogger<IndexModel> logger,)
        {
            _logger = logger;
        }

        //Methods.

        public void OnGet() 
        {
        }
        public void OnPost(string user, string pass)
        {
            //client = userRepository.UserValidation(user, pass);
            //return !client.Equals(null) ? RedirectToPage("./Home", new { id = client.ClientId }) : Page();
        }
    }
}
