using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 入库订单处理状态
    /// </summary>
    public enum InboundOrderStatus
    {
        ///<summary>
        /// 初始
        ///</summary>
        Initial = 0,

        /// <summary>
        /// 待审
        /// </summary>
        WaitingSubmit,

        ///<summary>
        /// 已提审
        ///</summary>
        Submitted = 10,

        /// <summary>
        /// 已验货
        /// </summary>
        Examine,

        ///<summary>
        /// 审核通过
        ///</summary>
        Examined = 30,

        ///<summary>
        /// 已入库
        ///</summary>
        Added = 50,

        /// <summary>
        /// 已发往亚马逊
        /// </summary>
        SentToAmazon = 60,

        /// <summary>
        /// 已删除
        /// </summary>
        Canceled,
    }
}
