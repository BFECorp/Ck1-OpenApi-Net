using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 直发订单处理状态
    /// </summary>
    public enum DirectExpressOrderStatus
    {
        /// <summary>
        /// 初始状态
        /// </summary>
        Initial = 0,
        /// <summary>
        /// 已提审
        /// </summary>
        Submitted = 1,
        /// <summary>
        /// 已审核
        /// </summary>
        Examined = 2,
        /// <summary>
        /// 已发
        /// </summary>
        Shipped = 3,
        /// <summary>
        /// 核重待确认
        /// </summary>
        WaitingForWeightConfirm = 5,
        /// <summary>
        /// 核重已确认
        /// </summary>
        WeightConfirm = 6,
        /// <summary>
        /// 退货
        /// </summary>
        Return = 7,
        /// <summary>
        /// 取消
        /// </summary>
        Cancel = 8,

    }
}
