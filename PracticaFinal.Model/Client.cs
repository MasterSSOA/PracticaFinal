using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientFullName { get; set; }
        public List<int> Accounts { get; set; }
    }
}
