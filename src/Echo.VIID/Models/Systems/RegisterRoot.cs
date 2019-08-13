using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 注册信息根对象
    /// </summary>
    public class RegisterRoot
    {
        [JsonPropertyName("RegisterObject")]
        public Register Register { get; set; }
    }
}

