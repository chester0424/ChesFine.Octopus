using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Data.Mapping
{
    public class ThemeMap: OctopusEntityTypeConfiguration<Theme>
    {
        public ThemeMap()
        {
            this.ToTable("Theme");
            this.HasKey(t => t.Id);

            //this.HasRequired(t => t.Category)
            //    .WithMany()
            //    .HasForeignKey(t => t.CategoryId);

        }
    }
}
