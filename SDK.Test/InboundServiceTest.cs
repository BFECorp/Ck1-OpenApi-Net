using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Inbound;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDK.Test
{
    [TestClass]
    public class InboundServiceTest : BaseTest
    {
         private InboundService _service;
        private const string AccessToken = "MDA2MjA2NTMtNDRlZS00MTc1LTg0ODQtOTZjOWQ2NzBkMzgx";

        public InboundServiceTest()
        {
            this._service = new InboundService(AccessToken);
        }
        [TestMethod]
        public void CreateInboundOrdersTest()
        {
            var request = new CreateInboundOrderRequest()
            {
                Location = "GZ",
                MerchantId = "MN006334",
                Remark = "测试入库订单",
                ShipmentId = "STOL201603300002",
                ShippingType = "DHL",
                WarehouseId = "US",
                Containers = new List<ContainerInfo>()
                {
                    new ContainerInfo()
                    {
                        CustomContainerNo = "CTNTST030003",
                        Height = 40,
                        Length = 20,
                        Width = 10,
                        Weight = 4800,
                        Skus = new List<InboundSkuObject>()
                        {
                            new InboundSkuObject()
                            {
                                Quantity = 20,
                                Sku = "bag-y001"
                            },
                            new InboundSkuObject()
                            {
                                Quantity = 10,
                                Sku = "bag-y002"
                            }
                        }
                    },
                    new ContainerInfo()
                    {
                        CustomContainerNo = "CTNTST030004",
                        Height = 25,
                        Length = 20,
                        Width = 10,
                        Weight = 600,
                        Skus = new List<InboundSkuObject>()
                        {
                            new InboundSkuObject()
                            {
                                Quantity = 20,
                                Sku = "bag-r001"
                            },
                            new InboundSkuObject()
                            {
                                Quantity = 20,
                                Sku = "bag-r002"
                            }
                        }
                    }
                }
            };
            var result = this._service.CreateInboundOrders(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
        }
        [TestMethod]
        public void GetInboundOrderStatusTest()
        {
            var shipmentId = "fangwei001001002";
            var result = this._service.GetInboundOrderStatus(shipmentId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
        }
        [TestMethod]
        public void GetInboundOrderLabelTest()
        {
            var request = new GetInboundOrderLabelRequest()
            {
                PrintContent = InboundPrintContent.PackingListInChinese,
                PrintFormat = PrintFormat.ClassicLabel,
                ShipmentId = "STOL201603300001"
            };
            var result = this._service.GetInboundOrderLabel(request);
            if (result.Success)
            {
                using (
                    var fs =
                        File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "/" +
                                       DateTime.Now.ToString("yyyy-MM-dd-mm") + "InboundOrderLabel.pdf"))
                {
                    var bytes = Convert.FromBase64String(result.Result.Label);
                    fs.Write(bytes, 0, bytes.Length);

                    fs.Close();
                }

                Console.WriteLine("ok");
            }
            else
            {
                var json = JsonConvert.SerializeObject(result);

                Console.Write(json);
            }
            Assert.IsTrue(result.Success);
        }
    }
}
