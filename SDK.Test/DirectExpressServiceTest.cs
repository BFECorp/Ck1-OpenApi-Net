namespace SDK.Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.DirectExpress;
    using CK1.OpenPlatform.SDK.Model.Enum;
    using CK1.OpenPlatform.SDK.Services;

    using Newtonsoft.Json;

    public class DirectExpressServiceTest
    {
        private DirectExpressService _service;
        private const string AccessToken = "ZDM1M2FmYjgtN2Q0NS00MjBlLWE4MWUtZDZlM2VmY2M1Mjkz";

        public DirectExpressServiceTest()
        {
            this._service = new DirectExpressService(AccessToken);
        }

        public void CreateDirectExpressOrderTest()
        {
            var request = new CreateDirectExpressOrderRequest()
            {
                MerchantId = "",
                Location = "GZ",
                Package = new Package(),
                Remark = "openapi v1 unite test"
            };
            request.Package = new Package()
            {
                ServiceCode = "CUE",
                Custom = "unite_test011",
                Height = 10,
                Width = 10,
                Length = 10,
                Weight = 100,
                PackageId = "unite_test012",

                Skus = new List<SkuObject>()
                {
                    new SkuObject()
                    {
                        Sku = "12345lnjk",
                        Quantity = 2,
                        Weight = 100,
                        DeclareValue = 4,
                        DeclareNameEn = "bag",
                        DeclareNameCn = "包包",
                        ProductName = "旗米拉",
                        Price = 8
                    }
                },

                ShipToAddress = new ShipToAddress()
                {
                    Country = "US",
                    Province = "OH",
                    City = "OH",
                    Street1 = "4525 Ackerman Blvd Kettering OH ",
                    Postcode = "45429",
                    Contact = "David Mcaffee",
                    Phone = "937-689-8216"
                },

                SellPrice = 16,
                SellPriceCurrency = Currency.USD,
                SalesPlatform = SalesPlatform.Aliexpress,

                Remark = "unite test",
                ImportTrackingNumber = "unite_test006_ImportTrackingNumber",
            };
            var result = this._service.CreateDirectExpressOrder(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetDirectExpressOrderLabelTest()
        {
            var request = new GetDirectExpressOrdersLabelRequest()
            {
                MerchantId = "MMM",
                PackageIds = new List<string>() { "unite_test001", "unite_test011" },
                PrintContent = DirectExpressPrintContent.AddressRemark,
                CustomPrintOptions =
                    new List<DirectExpressCustomPrintOption>() { DirectExpressCustomPrintOption.Custom },
                PrintFormat = PrintFormat.ClassicA4
            };

            var result = this._service.GetDirectExpressOrderLabel(request);

            if (result.Success)
            {
                using (
                    var fs =
                        File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "/" +
                                       DateTime.Now.ToString("yyyy-MM-dd-mm") + "DirectExpressOrderLabel.pdf"))
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

        public void GetDirectExpressOrderStatusTest()
        {
            string packageId = "unite_test010-006";
            var result = this._service.GetDirectExpressOrderStatus(packageId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
