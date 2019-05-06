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
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DirectExpressServiceTest : BaseTest
    {
        private DirectExpressService _service;

        public DirectExpressServiceTest()
        {
            this._service = new DirectExpressService(AccessToken);
        }
        [TestMethod]
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
                PackageId = "unite20190506test012",

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

                Remark = "unite test"
            };
            var result = this._service.CreateDirectExpressOrder(request);
            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);

            Assert.IsTrue(result.Success);            
        }
        [TestMethod]
        public void GetDirectExpressOrderLabelTest()
        {
            var request = new GetDirectExpressOrdersLabelRequest()
            {
                PackageIds = new List<string>() { "unite20190506test012" },
                PrintContent = DirectExpressPrintContent.AddressRemark,
                CustomPrintOptions =
                    new List<DirectExpressCustomPrintOption>() { DirectExpressCustomPrintOption.Custom },
                PrintFormat = PrintFormat.ClassicLabel
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
            Assert.IsTrue(result.Success);
        }
        [TestMethod]
        public void GetDirectExpressOrderStatusTest()
        {
            string packageId = "unite20190506test012";
            var result = this._service.GetDirectExpressOrderStatus(packageId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CreateStatus.Created,result.Result.Status);
            Assert.AreEqual(result.Result.HandleStatus, DirectExpressOrderStatus.Submitted);
        }
    }
}
