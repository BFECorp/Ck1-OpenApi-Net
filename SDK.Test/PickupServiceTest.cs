using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Pickup;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;

namespace SDK.Test
{
    class PickupServiceTest
    {
        private PickupService _service;
        private const string AccessToken = "MDA2MjA2NTMtNDRlZS00MTc1LTg0ODQtOTZjOWQ2NzBkMzgx";

        public PickupServiceTest()
        {
            this._service = new PickupService(AccessToken);
        }

        public void GetPickupAreaTest()
        {
            var city = "";
            var result = this._service.GetPickupArea(city);

            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);
        }

        public void CreatePickupOrderTest()
        {
            var request = new CreatePickupOrderRequest()
            {
                Address = "黄埔大道163号",
                PickupId = "PMN5698002",
                City = "广州",
                Contact = "林小柯",
                District = "天河区",
                MerchantId = "MN006334",
                Phone = "13545678910",
                PickupTime = "2016-04-25T07:00:00Z",
                Remark = "收货单备注",
                InboundDetail = new InboundDetail()
                {
                    ContainerQty = 3,
                    RelateShipmentIds = new List<string> { "STOL201603300001"},
                    Volumn = 10000,
                }
            };
            var result = this._service.CreatePickupOrder(request);

            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);
        }
    }
}
