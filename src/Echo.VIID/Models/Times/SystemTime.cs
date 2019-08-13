using Echo.VIID.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 系统时间
    /// </summary>
    public class SystemTime
    {
        /// <summary>
        /// 设备标识（服务器）
        /// </summary>
        public string VIIDServerID { get; set; }

        /// <summary>
        /// 校时模式
        /// </summary>
        public TimeCorrectMode TimeMode { get; set; }

        /// <summary>
        /// 本地时间
        /// </summary>
        [JsonConverter(typeof(VIIDDateTimeJsonConvert))]
        public DateTime LocalTime { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        public string TimeZone { get; set; }
    }
}
