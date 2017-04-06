using ChesFine.Octopus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Entities
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Theme: BaseEntity
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
        /// 概要
        /// </summary>
        public string Resume { get; set; }

        /// <summary>
        /// 简概
        /// </summary>
        public string ShortResume { get; set; }

        /// <summary>
        /// 图片（地址）
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 优先级（排序）
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 类别编号
        /// </summary>
        //public int? CategoryId { get; set; }

        //public virtual Category Category { get; set; }
    }
}
