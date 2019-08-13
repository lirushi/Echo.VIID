namespace Echo.VIID.Models
{
    /// <summary>
    /// 确认状态码
    /// </summary>
    public enum ConfirmStatu : int
    {
        /// <summary>
        /// 正常
        /// </summary>
        OK = 0,

        /// <summary>
        /// 未知错误
        /// </summary>
        UnknownError,

        /// <summary>
        /// 繁忙
        /// </summary>
        Busy,

        /// <summary>
        /// 错误 
        /// </summary>
        Error,

        /// <summary>
        /// 无效操作 
        /// </summary>
        InvalidOperation,

        /// <summary>
        /// 无效XML格式
        /// </summary>
        InvalidXmlFormat,

        /// <summary>
        /// 无效XML内容
        /// </summary>
        InvalidXmlContent,

        /// <summary>
        /// 无效JSON格式
        /// </summary>
        InvalidJsonFormat,

        /// <summary>
        /// 无效JSON内容
        /// </summary>
        InvalidJsonContent,

        /// <summary>
        /// 系统重启中
        /// </summary>
        SystemRestarting
    }
}
