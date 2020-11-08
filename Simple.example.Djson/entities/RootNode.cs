using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class RootNode : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int statusCode { get; set; }
        /// <summary>
        /// 查询成功
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string paging { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pageIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalRecord { get; set; }

        public List<Scheme> dynamicObj { get; set; }
    }
}
