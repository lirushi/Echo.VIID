using Echo.VIID.JsonConverters;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    /// <summary>
    /// 应答状态
    /// </summary>
    public class ResponseStatus
    {
        /// <summary>
        /// 请求的URL
        /// 必填
        /// </summary>
        [Required]
        public string RequestURL { get; set; }

        /// <summary>
        /// 状态码
        /// 必填
        /// </summary>
        [Required,JsonConverter(typeof(JsonStringEnumConverter))]
        public ConfirmStatu StatusCode { get; set; }

        /// <summary>
        /// 状态描述
        /// 必填
        /// </summary>
        public string StatusString { get; set; }

        /// <summary>
        /// 资源Id-创建型接口需要返回创建的资源的Id，其他可选
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 当前时间，用于需要校时的场合
        /// 可选
        /// </summary>
        [JsonConverter(typeof(VIIDDateTimeJsonConvert))]
        public DateTime LocalTime { get; set; }
    }
}
