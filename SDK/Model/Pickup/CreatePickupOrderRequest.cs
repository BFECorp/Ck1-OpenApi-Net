using System;
using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Pickup
{
    /// <summary>
    /// 表示添加收货订单的请求
    /// </summary>
    public class CreatePickupOrderRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 收货订单Id 
        /// </summary>
        public string PickupId { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 收货城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 收货区域
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 收货时间
        /// </summary>
        public string PickupTime { get; set; }

        /// <summary>
        /// 入库货物信息
        /// </summary>
        public InboundDetail InboundDetail { get; set; }

        /// <summary>
        /// 直发货物信息
        /// </summary>
        public DirectExpressDetail DirectExpressDetail { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        
    }

    /// <summary>
    /// 入库货物信息
    /// </summary>
    public class InboundDetail
    {
        /// <summary>
        /// 体积(CBM)
        /// </summary>
        public double Volumn { get; set; }

        /// <summary>
        /// 箱数
        /// </summary>
        public int ContainerQty { get; set; }

        /// <summary>
        /// 入库单Id列表
        /// </summary>
        public List<string> RelateShipmentIds { get; set; }

    }

    /// <summary>
    /// 直发货物信息
    /// </summary>
    public class DirectExpressDetail
    {
        /// <summary>
        /// 重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 包裹数
        /// </summary>
        public int PackageQty { get; set; }
    }
}
