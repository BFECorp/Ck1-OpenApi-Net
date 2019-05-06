using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.DataYewu;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDK.Test
{
    [TestClass]
    public class DataServiceTest : BaseTest
    {
        private DataService _service;

        public DataServiceTest()
        {
            this._service = new DataService(AccessToken);
        }
        [TestMethod]
        public void ListWarehouseTest()
        {
            var result = this._service.ListWarehouse();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);

            Assert.IsTrue(result.Success);
            Assert.IsTrue(result.Result.Count > 0);
        }
        [TestMethod]
        public void ListLocationTest()
        {
            var result = this._service.ListLocation();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
            Assert.IsTrue(result.Result.Count > 0);
        }
        [TestMethod]
        public void GetOutboundServiceTest()
        {
            var warehouseId = "US";
            var result = this._service.GetOutboundService(warehouseId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
            Assert.IsTrue(result.Result.Count > 0);
        }
        [TestMethod]
        public void GetDirectExpressServicesTest()
        {
            var result = this._service.GetDirectExpressServices();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
            Assert.IsTrue(result.Success);
            Assert.IsTrue(result.Result.Count > 0);
        }
    }
}
