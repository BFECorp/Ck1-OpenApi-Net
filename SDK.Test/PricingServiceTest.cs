using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Pricing;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;

namespace SDK.Test
{
    class PricingServiceTest
    {
        private PricingService _service;
        private const string AccessToken = "MDA2MjA2NTMtNDRlZS00MTc1LTg0ODQtOTZjOWQ2NzBkMzgx";

        public PricingServiceTest()
        {
            this._service = new PricingService(AccessToken);
        }

        public void GetSkusPricingTest()
        {
            var request = new GetSkuPricingRequest()
            {
                Address = "172 Meadowview lane",
                City = "Idaho",
                Country = "United States",
                Postcode = "83301",
                Province = "Twin Falls",
                ServiceCode = "USRPP",
                WarehouseId = "US",
                MerchantId = "MN006334",
                Skus =
                    new List<SkuInfo>()
                    {
                        new SkuInfo() {Sku = "bag-y001", Quantity = 2},
                        new SkuInfo() {Sku = "bag-y002", Quantity = 3}
                    }
            };
            var result = this._service.GetSkusPricing(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetSkusPricingAllTest()
        {
            var request = new GetSkuPricingAllRequest()
            {
                Address = "172 Meadowview lane",
                City = "Idaho",
                Country = "United States",
                Postcode = "83301",
                Province = "Twin Falls",
                IncludeUnsuccessful = true,
                WarehouseId = "US",
                MerchantId = "MN006334",
                Skus =
                    new List<SkuInfo>()
                    {
                        new SkuInfo() {Sku = "bag-y001", Quantity = 2},
                        new SkuInfo() {Sku = "bag-y002", Quantity = 3}
                    }
            };
            var result = this._service.GetSkusPricingAll(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetDirectExpressPricingTest()
        {
            var request = new GetExpressPricingRequest()
            {
                ServiceCode = "CUE",
                LocationId = "GZ",
                Weight = 600,
                Length = 20,
                Width = 15,
                Height = 10,
                Country = "US",
                Postcode = "83301",
                Address = "172 Meadowview lane",
                Province = "Idaho",
                City = "Twin Falls"
            };
            var result = this._service.GetDirectExpressPricing(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetDirectExpressPricingAllTest()
        {
            var request = new GetExpressPricingAllRequest()
            {
                IncludeUnsuccessful = true,
                LocationId = "GZ",
                Weight = 600,
                Length = 20,
                Width = 15,
                Height = 10,
                Country = "US",
                Postcode = "83301",
                Address = "172 Meadowview lane",
                Province = "Idaho",
                City = "Twin Falls"
            };
            var result = this._service.GetDirectExpressPricingAll(request);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
