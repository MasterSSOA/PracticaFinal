using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    public class Transaction
    {
        public int TransNumber { get; set; }
        public DateTime TransDate { get; set; }
        public double Amount { get; set; }
        public string TransDescription { get; set; }
        public Account AccountFrom { get; set; }
        public Account AccountTo { get; set; }
    }
}
