using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 应答状态根
    /// </summary>
    public class ResponseStatusRoot
    {
        [JsonPropertyName("ResponseStatusObject")]
        public ResponseStatus ResponseStatusObject { get; set; }
    }
}
