using System;
using System.Collections.Generic;
using System.IO;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Outbound;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
using UnShippedReason = CK1.OpenPlatform.SDK.Model.UnShippedReason;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDK.Test
{
    [TestClass]
    public class OutboundServiceTest: BaseTest
    {
        private OutboundService _service;

        public OutboundServiceTest()
        {
            this._service = new OutboundService(AccessToken);
        }
        [TestMethod]
        public void CreateOutboundOrderTest()
        {
            var request = new CreateOutboundOrderRequest()
            {
                Remark = "二程下单测试",
                WarehouseId = "US",
                Package = new Package()
                {
                    PackageId = "21173352",
                    Remark = "包裹备注",
                    SellPrice = 5,
                    SellPriceCurrency = "USD",
                    ServiceCode = "USRLS",
                    ShipToAddress = new ShipToAddress()
                    {
                        Contact = "Carla Chaves",
                        Street1 = "Alex Hull, 930 Tanglewood dr",
                        Street2 = "",
                        City = "TOTOWA",
                        Province = "NEW JERSEY",
                        Country = "United States",
                        Postcode = "07512-2305",
                        Phone = "01424 425635",
                        Email = "mario@mkkm.org"
                    },
                    Skus = new List<OutboundSkuObject>
                    {
                        new OutboundSkuObject()
                        {
                            Price = 5,
                            ProductName = "bag",
                            Quantity = 1,
                            Sku = "bag-y004"
                        },
                        new OutboundSkuObject()
                        {
                            Price = 5,
                            ProductName = "bag",
                            Quantity = 1,
                            Sku = "bag-y005"
                        }
                    }
                }
            };
            var result = this._service.CreateOutboundOrder(request);

            var json = JsonConvert.SerializeObject(result);

            Assert.IsTrue(result.Success);
            
            Console.Write(json);
        }
        [TestMethod]
        public void GetOutboundOrderStatusTest()
        {
            var packageId = "21173352";
            var result = this._service.GetOutboundOrderStatus(packageId);
            var json = JsonConvert.SerializeObject(result);

            Assert.IsTrue(result.Success);
            Console.Write(json);
        }
        [TestMethod]
        public void CancelOutboundOrderTest()
        {
            var packageId = "MN006T0005";
            var result = this._service.CancelOutboundOrder(packageId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
