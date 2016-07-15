using System.Collections.Generic;
using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Tracking
{
    /// <summary>
    /// 包裹轨迹信息
    /// </summary>
    public class GetTrackingResponse
    {
        /// <summary>
        /// 跟踪号
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 承运商
        /// </summary>
        public string ShippingProvider { get; set; }

        /// <summary>
        /// 轨迹状态：Processing、InTransit、Delivered
        /// </summary>
        public TrackingStatus? TrackingStatus { get; set; }

        /// <summary>
        /// 轨迹节点信息列表
        /// </summary>
        public List<CheckpointDto> Checkpoints { get; set; }
    }
    /// <summary>
    /// 轨迹节点信息
    /// </summary>
    public class CheckpointDto
    {
        /// <summary>
        /// 所在地点
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 轨迹状态
        /// </summary>
        public TrackingStatus TrackingStatus { get; set; }

        /// <summary>
        /// 轨迹信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Tracking唯一标识
        /// </summary>
        public string TrackingId { get; set; }
        
    }
}
