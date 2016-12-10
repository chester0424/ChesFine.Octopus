using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Data.Mapping
{
    public class UserMapp: OctopusEntityTypeConfiguration<User>
    {
        public UserMapp()
        {
            this.ToTable("User");
            this.HasKey(a => a.Id);

            this.Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
