using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ChesFine.Octopus.Entities;

namespace ChesFine.Octopus.Data.Mapping
{
    public class ArticleMap: OctopusEntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            this.ToTable("Article");
            this.HasKey(a => a.Id);

            //配置;一篇文章 对应0/1个主题，一个主题对应多篇文章；文章表对主题表的外键是“ThemeId”
            this.HasOptional(a => a.Theme)
                .WithMany()
                .HasForeignKey(a => a.ThemeId);
        }
    }
}
