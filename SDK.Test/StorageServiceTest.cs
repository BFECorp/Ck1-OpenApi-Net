using System;
using System.Collections.Generic;

using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.DirectExpress;
using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Inbound;
using CK1.OpenPlatform.SDK.Model.Storage;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDK.Test
{
    [TestClass]
    public class StorageServiceTest : BaseTest
    {
        private StorageService _service;

        public StorageServiceTest()
        {
            this._service = new StorageService(AccessToken);
        }
        [TestMethod]
        public void GetInventoryGetTest()
        {
            var request = new GetInventoriesRequest()
            {
                MerchantId = "2015202e26e8375d5e6a1777",
                Skus = "mytestsku201512011355,mytestsku201512011123",
                WarehouseId = "US"
            };
            var result = this._service.GetInventory(request);

            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);

            Assert.IsTrue(result.Success);
        }
        [TestMethod]
        public void GetInventoryPostTest()
        {
            var request = new InventoriesRequest()
            {
                MerchantId = "2015202e26e8375d5e6a1777",
                WarehouseId = "US",
                Skus = new List<string>()
                {
                    "mytestsku201512011355",
                    "mytestsku201512011350",
                    "mytestsku201512011123"
                }
            };
            var result = this._service.GetInventory(request);

            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);

            Assert.IsTrue(result.Success);
        }
        [TestMethod]
        public void ListStorageSkuTest()
        {
            var request = new ListStorageSkuRequest()
            {
                WarehouseId = "US",
                PageIndex = 1,
                PageSize = 5,
                Sorting = StorageSkuSortingType.SkuAsc
                
            };
            var result = this._service.ListStorageSku(request);

            var json = JsonConvert.SerializeObject(result);
            Console.Write(json);

            Assert.IsTrue(result.Success);
            
        }
    }
}
