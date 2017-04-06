using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Data.Mapping
{
    public class CategoryMap: OctopusEntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.ToTable("Category");
            this.HasKey(c => c.Id);

            this.HasOptional(c => c.Parent)
                .WithMany()
                .HasForeignKey(c => c.ParentId);
        }
    }
}
