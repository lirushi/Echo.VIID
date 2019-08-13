using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 人脸信息
    /// </summary>
    public class Face
    {
        /// <summary>
        ///  人脸标识
        ///  ImageCntObjectIdType
        /// </summary>
        public string FaceID { get; set; }

        /// <summary>
        /// 信息分类
        /// </summary>
        public InfoType InfoKind { get; set; }

        /// <summary>
        /// 来源标识
        /// BasicObjectIdType
        /// </summary>
        public string SourceID { get; set; }

        /// <summary>
        /// 设备标识
        /// DeviceIDType 
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// 人脸区域，左上角X坐标
        /// </summary>
        public int LeftTopX { get; set; }

        /// <summary>
        /// 人脸区域，左上角Y坐标
        /// </summary>
        public int LeftTopY { get; set; }

        /// <summary>
        /// 人脸区域，右下角X坐标
        /// </summary>
        public int RightBtmX { get; set; }

        /// <summary>
        /// 人脸区域，右下角Y坐标
        /// </summary>
        public int RightBtmY { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderType GenderCode { get; set; }

        /// <summary>
        /// 是否驾驶员
        /// </summary>
        public Ternary IsDriver { get; set; }

        /// <summary>
        /// 是否涉外人员
        /// </summary>
        public Ternary IsForeigner { get; set; }

        /// <summary>
        /// 是否涉恐人
        /// </summary>
        public Ternary IsSuspectedTerrorist { get; set; }

        /// <summary>
        /// 是否涉案人
        /// </summary>
        public Ternary IsCriminalInvolved { get; set; }

        /// <summary>
        /// 是否在押人员
        /// </summary>
        public Ternary IsDetainees { get; set; }

        /// <summary>
        /// 是否被害人
        /// </summary>
        public Ternary IsVictim { get; set; }

        /// <summary>
        /// 是否可疑人 
        /// </summary>
        public Ternary IsSuspiciousPerson { get; set; }

        /// <summary>
        /// 人脸图像列表对象
        /// </summary>
        [JsonPropertyName("SubImageList")]
        public SubImageList SubImageList { get; set; }

        /// <summary>
        /// 人脸图片
        /// </summary>
        [JsonIgnore]
        public IList<SubImage> Images { get { return SubImageList?.SubImages; } }
    }
}
