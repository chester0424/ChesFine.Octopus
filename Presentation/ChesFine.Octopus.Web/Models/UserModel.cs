using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChesFine.Octopus.Web.Models
{
    public class UserModel:BaseModel
    {
       public string Name { get; set; }

        public int? Age { get; set; }
    }
}