using ChesFine.Octopus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Entities
{
   public class User:BaseEntity
    {
        public string Name { get; set; }

        public int? Age { get; set; }
    }
}
