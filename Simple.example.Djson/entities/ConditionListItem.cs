using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class ConditionListItem : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int taskConditonID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int controlTaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int conditionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assetsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assetsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indicatorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indicatorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indexValueType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comparisonSymbolDictID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comparingSymbolicValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conditionValueDictionaryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conditionValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string createTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indexValueUnitDictionaryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string indexValueUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collectorNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conditionFormula { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FormulaValueList> formulaValueList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int waitingTime { get; set; }
    }
}
