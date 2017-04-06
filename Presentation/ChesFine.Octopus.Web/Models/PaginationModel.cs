using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ChesFine.Octopus.Web.Models
{
    /// <summary>
    /// 分页数据结果
    /// </summary>
    public class PaginationModel
    {
        /// <summary>
        /// 数据总行数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 当前请求数据结果
        /// </summary>
        public IEnumerable<object> rows { get; set; }
    }

    /// <summary>
    /// 数据查询基类
    /// </summary>
    public class QueryBaseModel
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 页行数
        /// </summary>
        public int rows { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string sort { get; set; }
        /// <summary>
        /// 排序方式
        /// </summary>
        public string order { get; set; }
    }
}