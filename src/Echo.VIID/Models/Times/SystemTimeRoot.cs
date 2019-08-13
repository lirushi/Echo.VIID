using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemTimeRoot
    {
        [JsonPropertyName("SystemTimeObject")]
        public SystemTime SystemTime { get; set; }
    }
}
