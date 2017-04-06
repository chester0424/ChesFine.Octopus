using ChesFine.Octopus.Core.Data;
using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Services.Users
{
    public partial class UserService:IUserService
    {
        #region Fields

        IRepository<User> _userReportory;

        #endregion

        #region Ctor

        public UserService(IRepository<User> userReportory)
        {
            this._userReportory = userReportory;
        }

        #endregion

        #region Methods

        public virtual IList<User> GetAllUsers()
        {
            //var query = _userReportory.Table;
            //return query.ToList();
            return new List<User>() { new User() { Id = 1, Name = "abc", Age = 33 } };
        }

        #endregion
    }
}
