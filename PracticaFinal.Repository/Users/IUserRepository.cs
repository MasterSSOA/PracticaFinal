using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFinal.Models;

namespace PracticaFinal.Repository.Users
{
    public interface IUserRepository
    {
        public User UserValidation(string user, string pass);
    }
}
