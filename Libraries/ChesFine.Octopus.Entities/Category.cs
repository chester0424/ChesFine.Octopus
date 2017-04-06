using ChesFine.Octopus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Entities
{
    /// <summary>
    /// 分类、类别
    /// </summary>
    public class Category: BaseEntity
    {
        ///// <summary>
        ///// 编号
        ///// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority { get; set; }

        public int? ParentId { get; set; }

        public virtual Category Parent { get; set; }

        public List<Category> Children { get; set; }
    }
}
