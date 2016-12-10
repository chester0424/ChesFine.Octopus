using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Users
{
    public interface IUserService
    {
        /// <summary>
        /// get all users
        /// </summary>
        /// <returns></returns>
        IList<User> GetAllUsers();
    }
}
