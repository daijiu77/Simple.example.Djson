using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class CommandListItem : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int commandID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int commandType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int controlTaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int runningOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int assetsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assetsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int indicatorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indicatorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int indicatorValueType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indicatorUnitDictID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indicatorUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int controlValueDictID { get; set; }
        /// <summary>
        /// 开
        /// </summary>
        public string controlValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collectorNumber { get; set; }
        /// <summary>
        /// 开
        /// </summary>
        public string initialValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int initialValueDictID { get; set; }
    }
}
