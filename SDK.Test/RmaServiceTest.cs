using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Rma;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;

namespace SDK.Test
{
    class RmaServiceTest
    {
        private RmaService _service;
        private const string AccessToken = "MGRhZGU5YjMtNzlmYS00Mzc2LTg1M2ItYTllYTk1ZTk5MTli";

        public RmaServiceTest()
        {
            this._service = new RmaService(AccessToken);
        }

        public void ListRmasTest()
        {
            var request = new GetRmaOrderLabelRequest()
            {
                RmaOrderId = "S001",
                RmaWarehouseId = "NJ",
                PrintFormat = PrintFormat.ClassicLabel,
                RmaShippingProvider = "USPS",
                RmaTrackingNumber = "89548114852",
                Products = new List<RmaProductInfo>()
                            {
                                new RmaProductInfo()
                                    {
                                        ProductNo = "abc001",
                                        ProductName = "phone 2015",
                                        Length = 12,
                                        Width = 10,
                                        Height = 10,
                                        DeclareValue = 15,
                                        Quantity = 1,
                                        HandleType = RmaHandleType.Dispose,
                                        ProductCategory = "phone",
                                        Weight = 600
                                    },
                                new RmaProductInfo()
                                    {
                                        ProductNo = "abc002",
                                        ProductName = "phone 2015",
                                        Length = 12,
                                        Width = 10,
                                        Height = 10M,
                                        DeclareValue = 15,
                                        Quantity = 2,
                                        HandleType = RmaHandleType.Dispose,
                                        ProductCategory = "phone",
                                        Weight = 600
                                    },
                            },
            };
            
            var result = this._service.GetRmaLabel(request);
            if (result.Success)
            {
                using (
                    var fs =
                        File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "/" +
                                       DateTime.Now.ToString("yyyy-MM-dd-mm") + "RmaOrderLabel.pdf"))
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
        }

        public void GetRmaLabel()
        {
            var request = new ListRmasRequest()
            {
                RmaWarehouseId = "NJ",
                HandleTimeStart = "",
                HandleTimeEnd = "",
                Status = RmaOrderStatus.Pending,
                CreateTimeStart = "",
                CreateTimeEnd = "",
                PageIndex = 1,
                PageSize = 10
            };
            

            var result = this._service.ListRmas(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
