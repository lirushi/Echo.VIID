namespace Echo.VIID.Models
{
    /// <summary>
    /// 图像类型
    /// </summary>
    public enum ImageType : int
    {
        /// <summary>
        /// 车辆大图
        /// </summary>
        CarLargeImg = 1,

        /// <summary>
        /// 车牌彩色小图
        /// </summary>
        CarColorSmallImg,

        /// <summary>
        /// 车牌二值化图
        /// </summary>
        CarBinarization,

        /// <summary>
        /// 驾驶员面部特征图
        /// </summary>
        DriverFace,

        /// <summary>
        /// 副驾驶面部特征图
        /// </summary>
        CopilotFace,

        /// <summary>
        /// 车标
        /// </summary>
        CarLogo,

        /// <summary>
        /// 违章合成图
        /// </summary>
        Violating,

        /// <summary>
        /// 过车合成图
        /// </summary>
        PassCar,

        /// <summary>
        /// 车辆特写图
        /// </summary>
        CarCloseUp,

        /// <summary>
        /// 人员图
        /// </summary>
        People,

        /// <summary>
        /// 人脸图
        /// </summary>
        Face,
        /// <summary>
        /// 非机动车图
        /// </summary>
        NonMotorVehicle,

        /// <summary>
        /// 物品图
        /// </summary>
        Item,

        /// <summary>
        /// 场景图
        /// </summary>
        Scene,

        /// <summary>
        /// 一般图片
        /// </summary>
        General

    }
}
