using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 注销根信息
    /// </summary>
    public class UnRegisterRoot
    {
        [JsonPropertyName("UnRegisterObject")]
        public UnRegister UnRegister { get; set; }
    }
}

