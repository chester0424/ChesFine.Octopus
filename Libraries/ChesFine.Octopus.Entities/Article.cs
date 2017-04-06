using ChesFine.Octopus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Entities
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article: BaseEntity
    {
        ///// <summary>
        ///// 编号
        ///// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 优先级（排序）
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 最近一次编辑日期
        /// </summary>
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// 主题编号
        /// </summary>
        public int? ThemeId { get; set; }

        public Theme Theme { get; set; }
    }
}
