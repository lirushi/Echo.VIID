namespace Echo.VIID.Models
{
    /// <summary>
    /// 视频图像分析处理事件类型
    /// </summary>
    public enum EventType : int
    {
        /// <summary>
        /// 其他  
        /// </summary>
        Other = 0,

        /// <summary>
        /// 卡口 过车
        /// </summary>
        PassCar,
        /// <summary>
        /// 卡口 过人
        /// </summary>
        PassPeople,

        /// <summary>
        /// 卡口 打架
        /// </summary>
        PassFight,

        /// <summary>
        /// 卡口 快速奔跑
        /// </summary>
        PassRun,

        /// <summary>
        /// 目标检测与特征提取 运动目标检测
        /// </summary>
        FeatureMoving,

        /// <summary>
        /// 目标检测与特征提取 目标分类
        /// </summary>
        FeatureSort,

        /// <summary>
        /// 目标检测与特征提取 目标颜色检测
        /// </summary>
        FeatureColor,

        /// <summary>
        /// 目标检测与特征提取 行人检测
        /// </summary>
        FeaturePedestrian,

        /// <summary>
        /// 目标检测与特征提取 人员属性分析
        /// </summary>
        FeaturePersonnelAttribute,

        /// <summary>
        /// 目标检测与特征提取 人脸检测  
        /// </summary>
        FeatureFaceDiscover,

        /// <summary>
        /// 目标检测与特征提取 人脸比对
        /// </summary>
        FeatureFaceComparison,
        /// <summary>
        /// 目标检测与特征提取 车辆检测  
        /// </summary>
        FeatureCarDiscover,

        /// <summary>
        /// 目标检测与特征提取 车辆比对
        /// </summary>
        FeatureCarComparison,
        /// <summary>
        /// 目标数量分析 流量统计
        /// </summary>

        AnalysisTrafficStatistics,

        /// <summary>
        /// 目标数量分析 密度检测
        /// </summary>
        AnalysisDensity,

        /// <summary>
        /// 目标识别 车牌识别
        /// </summary>
        RecognitionLicensePlate,

        /// <summary>
        /// 目标识别 车辆基本特征识别
        /// </summary>
        RecognitionCarBase,

        /// <summary>
        /// 目标识别 车辆个体特征识别
        /// </summary>
        RecognitionCarFeature,

        /// <summary>
        /// 行为分析 绊线检测
        /// </summary>
        BehaviorLine,
        /// <summary>
        /// 行为分析 入侵检测
        /// </summary>
        BehaviorIntrusion,

        /// <summary>
        /// 行为分析 逆行检测
        /// </summary>
        BehaviorRetrograde,

        /// <summary>
        /// 行为分析 徘徊检测
        /// </summary>
        BehaviorLinger,

        /// <summary>
        /// 行为分析 遗留物检测
        /// </summary>
        BehaviorRemnant,

        /// <summary>
        /// 行为分析 目标移除检测
        /// </summary>
        BehaviorTargetRemoval,

        /// <summary>
        /// 视频摘要 视频摘要
        /// </summary>
        VideoSummary,

        /// <summary>
        /// 视频增强与复原 去雾
        /// </summary>
        VideoCorrectionDefogging,

        /// <summary>
        /// 视频增强与复原 去模糊
        /// </summary>
        VideoCorrectionDeblur,

        /// <summary>
        /// 视频增强与复原 对比度增强
        /// </summary>
        VideoCorrectionContrast,

        /// <summary>
        /// 视频增强与复原 低照度视频图像增强
        /// </summary>
        VideoCorrectionZQ,

        /// <summary>
        /// 视频增强与复原 偏色校正
        /// </summary>
        VideoCorrectionColor,

        /// <summary>
        /// 视频增强与复原 宽动态增强
        /// </summary>
        VideoCorrectionKDTZQ,

        /// <summary>
        /// 视频增强与复原 超分辨率重建
        /// </summary>
        VideoCorrectionCFBLCJ,

        /// <summary>
        /// 视频增强与复原 几何畸变校正
        /// </summary>
        VideoCorrectionDistortion,

        /// <summary>
        /// 视频增强与复原 奇偶场校正
        /// </summary>
        VideoCorrectionParity,

        /// <summary>
        /// 视频增强与复原 颜色空间分量分离
        /// </summary>
        VideoCorrectionYSKJFLFL,

        /// <summary>
        /// 视频增强与复原 去噪
        /// </summary>
        VideoCorrectionNoiseReduction,

    }
}
