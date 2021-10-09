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
        UserInMemory userInMemory = new UserInMemory();
        AccountInMemory accountInMemory = new AccountInMemory();


        //Constructor.
        public ClientInMemory() => clients = new List<Client>()
            {
               new Client()
               {
                    ClientId = 1,
                    ClientFullName = "Pedro Ramirez Sosa",
                    Accounts = accountInMemory.GetAccounts(1),
                    User = userInMemory.GetUser(1)
               },
               new Client()
               {
                    ClientId = 2,
                    ClientFullName = "Benito Martinez",
                    Accounts = accountInMemory.GetAccounts(2),
                    User = userInMemory.GetUser(2)
               }
            };

        //Methods.
        public Client GetClient(int ClientId) => clients.Find(c => c.ClientId.Equals(ClientId));
    }
}
