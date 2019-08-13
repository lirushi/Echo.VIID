namespace Echo.VIID.Models
{
    /// <summary>
    /// 视频图像信息类型
    /// </summary>
    public enum InfoType : int
    {
        /// <summary>
        /// 其他
        /// </summary>
        Other = 0,

        /// <summary>
        /// 自动采集
        /// </summary>
        Automatic,

        /// <summary>
        /// 人工采集
        /// </summary>
        Manual
    }
}
