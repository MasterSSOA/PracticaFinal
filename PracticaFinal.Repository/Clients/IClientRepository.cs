using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;

namespace PracticaFinal.Repository
{
    public interface IClientRepository
    {
        public Client GetClient(int ClientId);

    }
}
