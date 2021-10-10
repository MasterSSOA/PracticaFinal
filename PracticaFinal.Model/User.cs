using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo vacío.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "No puede dejar este campo vacío.")]
        public string UserPass { get; set; }
        public int ClientId { get; set; }
    }
}
