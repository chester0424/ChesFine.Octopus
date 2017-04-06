using ChesFine.Octopus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesFine.Octopus.Entities
{
    /// <summary>
    /// 评论、留言
    /// </summary>
    public class Comment: BaseEntity
    {
        ///// <summary>
        ///// 编号
        ///// </summary>
        //public int Id { get; set; }
        
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 文章Id
        /// </summary>
        public int ArticleId { get; set; }
    }
}
