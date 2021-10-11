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
        [TempData]
        public int ClientId { get; set; }
        [BindProperty]
        public User user { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserRepository userRepository;

        //Constructor.
        public IndexModel(ILogger<IndexModel> logger, IUserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }

        //Methods.
        public IActionResult OnPost()
        {
            var user = userRepository.UserValidation(this.user.UserName, this.user.UserPass);
            if (user != null)
            {
                ClientId = user.ClientId;
                return RedirectToPage("./Home");
            }
            return Page();
        }
    }
}
