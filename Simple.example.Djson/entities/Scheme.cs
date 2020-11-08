using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class Scheme : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int controlGroupID { get; set; }
        /// <summary>
        /// 控制烟雾报警开关
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int controlType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string controlTypeStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string effectiveDateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string autoStartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string autoEndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string effectivePeriodType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string effectiveStartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string effectiveEndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int groupState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string createTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string modifyTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confirmID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confirmName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confirmTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int faultToleranceTimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastExecutionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int isDelete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int isEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isEnableStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string showStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hiddenStop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TaskListItem> taskList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int updateStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int delayTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creatorName { get; set; }
    }
}
