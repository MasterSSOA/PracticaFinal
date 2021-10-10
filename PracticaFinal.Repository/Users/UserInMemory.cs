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
        private readonly List<User> users;

        //Constructor.
        public UserInMemory() => users = new List<User>()
            {
                new User()
                {
                    UserId = 1, 
                    UserName = "PRamirez", 
                    UserPass = "1234", 
                    ClientId = 1
                },

                 new User()
                {
                    UserId = 1,
                    UserName = "BMartinez",
                    UserPass = "4321",
                    ClientId = 2
                }
            };

        //Methods.
        public User UserValidation(string user, string pass)
            => users.Find(u => (u.UserName.Equals(user) && u.UserPass.Equals(pass)));
    }
}
