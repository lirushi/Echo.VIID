using Echo.VIID.JsonConverters;
using System;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 图像信息
    /// </summary>
    public class SubImage
    {
        /// <summary>
        /// 图像标识
        /// ImageCntObjectIdType
        /// </summary>
        public string ImageID { get; set; }

        /// <summary>
        /// 事件分类
        /// </summary>
        public EventType EventSort { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// 存储路径
        /// </summary>
        public string StoragePath { get; set; }

        /// <summary>
        /// 图像类型
        /// </summary>
        public ImageType Type { get; set; }

        /// <summary>
        /// 图片格式
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// 拍照时间
        /// </summary>
        [JsonConverter(typeof(VIIDDateTimeJsonConvert))]
        public DateTime ShotTime { get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// 图片Base64数据
        /// </summary>
        public string Data { get; set; }
    }
}
