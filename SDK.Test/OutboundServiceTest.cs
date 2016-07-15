using System;
using System.Collections.Generic;
using System.IO;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Outbound;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
using UnShippedReason = CK1.OpenPlatform.SDK.Model.UnShippedReason;

namespace SDK.Test
{
    class OutboundServiceTest
    {
        private OutboundService _service;
        private const string AccessToken = "MDA2MjA2NTMtNDRlZS00MTc1LTg0ODQtOTZjOWQ2NzBkMzgx";

        public OutboundServiceTest()
        {
            this._service = new OutboundService(AccessToken);
        }

        public void CreateOutboundOrderTest()
        {
            var request = new CreateOutboundOrderRequest()
            {
                MerchantId = "MN006334",
                Remark = "二程下单测试",
                WarehouseId = "US",
                Package = new Package()
                {
                    PackageId = "MN006T0006",
                    Remark = "包裹备注",
                    SellPrice = 5,
                    SellPriceCurrency = Currency.USD,
                    ServiceCode = "USRLE",
                    ShipToAddress = new ShipToAddress()
                    {
                        Contact = "Carla Chaves",
                        Street1 = "Alex Hull, 930 Tanglewood dr",
                        Street2 = "",
                        City = "'St. Leonard",
                        Province = "East Sussex",
                        Country = "US",
                        Postcode = "33063-7008",
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
                            Sku = "bag-y001"
                        },
                        new OutboundSkuObject()
                        {
                            Price = 5,
                            ProductName = "bag",
                            Quantity = 1,
                            Sku = "bag-r001"
                        }
                    }
                }
            };
            var result = this._service.CreateOutboundOrder(request);

            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetOutboundOrderStatusTest()
        {
            var packageId = "P004test0012101133";
            var result = this._service.GetOutboundOrderStatus(packageId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void CancelOutboundOrderTest()
        {
            var packageId = "MN006T0005";
            var result = this._service.CancelOutboundOrder(packageId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
