using PracticaFinal.Models;
using PracticaFinal.Repository.Accounts;
using PracticaFinal.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal.Repository
{
    public class ClientInMemory : IClientRepository
    {
        //Properties.
        private readonly List<Client> clients;

        //Constructor.
        public ClientInMemory() => clients = new List<Client>()
            {
               new Client()
               {
                    ClientId = 1,
                    ClientFullName = "Pedro Ramirez Sosa",
                    Accounts = new List<int>() {20105136, 20235624}
               },
               new Client()
               {
                    ClientId = 2,
                    ClientFullName = "Benito Martinez",
                    Accounts = new List<int>() {51254826, 62548214}
               }
            };

        //Methods.
        public Client GetClient(int ClientId) => clients.Find(c => c.ClientId.Equals(ClientId));
    }
}
