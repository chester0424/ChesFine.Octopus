using ChesFine.Octopus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Data.Mapping
{
    public class CommentMap: OctopusEntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.ToTable(" Comment");
        }
    }
}
