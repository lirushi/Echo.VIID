using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 图像集合信息
    /// </summary>
    public class SubImageList
    {
        /// <summary>
        /// 图像信息
        /// </summary>
        [JsonPropertyName("SubImageInfoObject")]
        public IList<SubImage> SubImages { get; set; }
    }
}
