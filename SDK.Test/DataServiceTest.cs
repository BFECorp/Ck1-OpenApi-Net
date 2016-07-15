using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.DataYewu;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;

namespace SDK.Test
{
    class DataServiceTest
    {
        private DataService _service;
        private const string AccessToken = "YjI3ZWIyNjItMzEzOS00MGNkLWFmN2UtMzQ1MDY0YzY5ZGUy";

        public DataServiceTest()
        {
            this._service = new DataService(AccessToken);
        }

        public void ListWarehouseTest()
        {
            var result = this._service.ListWarehouse();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void ListLocationTest()
        {
            var result = this._service.ListLocation();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetOutboundServiceTest()
        {
            var warehouseId = "US";
            var result = this._service.GetOutboundService(warehouseId);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }

        public void GetDirectExpressServicesTest()
        {
            var result = this._service.GetDirectExpressServices();
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
