using System;
using System.Collections.Generic;
using System.DJ.DJson.Commons;
using System.Text;

namespace Simple.example.Djson.entities
{
    public class FormulaValueList : BaseEntity
    {
        /// <summary>
        /// 采集服务器编号
        /// </summary>
        public string collectorNumber { get; set; }

        /// <summary>
        /// 设备ip
        /// </summary>
        public string ipAddress { get; set; }

        /// <summary>
        /// 设备端口号
        /// </summary>
        public int portNumber { get; set; } = -1;

        /// <summary>
        /// 设备地址
        /// </summary>
        public int deviceAddress { get; set; }

        /// <summary>
        /// 功能码
        /// </summary>
        public int dataTable { get; set; }

        /// <summary>
        /// 寄存器地址
        /// </summary>
        public int registerAddress { get; set; }

        /// <summary>
        /// 寄存器数量
        /// </summary>
        public int elementCount { get; set; }

        /// <summary>
        /// 接收数据字节位置
        /// </summary>
        public int dataBytePosOfReceive { get; set; }

    }
}
