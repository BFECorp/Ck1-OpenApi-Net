using Newtonsoft.Json;

namespace SDK.Test
{
    using System;
    using System.IO;

    using CK1.OpenPlatform.SDK.Model.Enum;
    using CK1.OpenPlatform.SDK.Model.MerchantSku;
    using CK1.OpenPlatform.SDK.Services;

    public class MerchantSkuServiceTest
    {
        private MerchantSkuService _service;
        private const string AccessToken = "MDA2MjA2NTMtNDRlZS00MTc1LTg0ODQtOTZjOWQ2NzBkMzgx";

        public MerchantSkuServiceTest()
        {
            this._service = new MerchantSkuService(AccessToken);
        }

        public void MerchantTest()
        {
            var request = new CreateMerchantRequest()
            {
                Contact = "fangwei",
                Email = "123458@test.com",
                Location = "GZ",
                MerchantId = "MN006336",
                MerchantName = "TNT",
                Phone = "13545678912"
            };
            var result = this._service.CreateMerchant(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void MerchantSkuTest()
        {
            var request = new CreateMerchantSkuRequest()
            {
                DeclareName = "bag",
                DeclareValue = 5M,
                Height = 10M,
                Length = 10M,
                //MerchantId = "test-merchant-001",
                ProductAmountWarn = 0,
                ProductCategory = "test-Category",
                ProductDescription = "Sample description",
                ProductFlag = ProductFlag.Simple,
                ProductName = "bag",
                ProductRemark = "test123",
                Sku = "red-bag-008",
                Weight = 100,
                Width = 10M,
                CustomStorageNo = "OpenApi201604080003"
            };
            var result = this._service.CreateMerchantSku(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetInboundSkuLabelTest()
        {
            var request = new GetSkuLabelRequest()
            {
                MerchantId = "MMM",
                PrintFormat = PrintFormat.ClassicLabel,
                Sku = "Abc",
                Quantity = 3,
                WarehouseId = "US",
            };
            var result = this._service.GetSkuLabel(request);
            if (result.Success)
            {
                using (var fs = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "/" + DateTime.Now.ToString("yyyy-MM-dd-mm") + "sku_print.pdf"))
                {
                    var bytes = Convert.FromBase64String(result.Result.Label);
                    fs.Write(bytes, 0, bytes.Length);

                    fs.Close();
                }

                Console.WriteLine("ok");
            }
            
        }
    }
}
