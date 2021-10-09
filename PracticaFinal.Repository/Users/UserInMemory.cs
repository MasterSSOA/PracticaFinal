using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;

namespace PracticaFinal.Repository.Users
{
    public class UserInMemory : IUserRepository
    {
        //Properties.
        ClientInMemory ClientInMemory = new ClientInMemory();
        private readonly List<User> users;
        private User user;
        private Client client;

        //Constructor.
        public UserInMemory() => users = new List<User>()
            {
                new User()
                {
                    UserId = 1, 
                    UserName = "PRamirez", 
                    UserPass = "1234", 
                    ClientId = 1, 
                    Client = ClientInMemory.GetClient(1)
                },

                 new User()
                {
                    UserId = 1,
                    UserName = "BMartinez",
                    UserPass = "4321",
                    ClientId = 2,
                    Client = ClientInMemory.GetClient(2)
                }
            };

        //Methods.
        public User GetUser(int Userid) => users.Find(c => c.UserId.Equals(Userid));
        public Client UserValidation(string user, string pass)
        {
            if (users.Exists(u => (u.UserName.Equals(user) && u.UserPass.Equals(pass))))
            {
                this.user = users.Find(u => (u.UserName.Equals(user) && u.UserPass.Equals(pass)));
                client = ClientInMemory.GetClient(this.user.ClientId);
                return client;
            }
            return null;
        }
    }
}
