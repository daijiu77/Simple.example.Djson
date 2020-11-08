using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class TaskListItem : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int controlTaskID { get; set; }
        /// <summary>
        /// 开启烟雾报警
        /// </summary>
        public string taskName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int linkageGroupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int taskOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int executeState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string executeStateStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string createTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ConditionListItem> conditionList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CommandListItem> commandList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string moveUpVisibility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string moveDownVisibility { get; set; }
    }
}
