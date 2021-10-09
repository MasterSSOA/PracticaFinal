using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
