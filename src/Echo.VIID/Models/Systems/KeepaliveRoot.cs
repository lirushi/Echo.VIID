using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 保活根对象
    /// </summary>
    public class KeepaliveRoot
    {
        [JsonPropertyName("KeepaliveObject")]
        public Keepalive Keepalive { get; set; }
    }
}

