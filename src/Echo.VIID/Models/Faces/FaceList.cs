using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 人脸集合信息
    /// </summary>
    public class FaceList
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        [JsonPropertyName("FaceObject")]
        public IList<Face> Faces { get; set; }
    }
}
