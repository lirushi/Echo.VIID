using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 人脸列表根对象
    /// </summary>
    public class FaceListRoot
    {
        /// <summary>
        /// 人脸集合信息
        /// </summary>
        [JsonPropertyName("FaceListObject")]
        public FaceList FaceList { get; set; }
    }
}
