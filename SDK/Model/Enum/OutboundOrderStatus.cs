using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 出库订单处理状态
    /// </summary>
    public enum OutboundOrderStatus
    {
        ///<summary>
        ///已删除
        ///</summary>
        Delete = 1,

        ///<summary>
        ///初始状态
        ///</summary>
        Initial = 2,

        ///<summary>
        ///已提审
        ///</summary>
        Submitted = 3,

        ///<summary>
        ///已审核
        ///</summary>
        Examined = 4,

        ///<summary>
        ///已出库
        ///</summary>
        Shipped = 5,

        ///<summary>
        ///配送中
        ///</summary>
        Consignment = 6,

        ///<summary>
        ///已收货
        ///</summary>
        Receive = 7,

        ///<summary>
        ///已完成
        ///</summary>
        Finished = 8,

        ///<summary>
        ///未发货
        ///</summary>
        UnShipped = 9,

        ///<summary>
        ///退货
        ///</summary>
        Returns = 10,

        ///<summary>
        ///退货申请入库
        ///</summary>
        RetrunApply = 11,

        ///<summary>
        ///退货入库完成
        ///</summary>
        RetrunFinished = 12,

        /////<summary>
        /////未发货(已删除)
        /////</summary>
        //UnShippedDelete = 13,
    }
}
