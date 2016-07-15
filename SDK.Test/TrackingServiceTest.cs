using System;
using System.Collections.Generic;
using System.IO;

using CK1.OpenPlatform.SDK.Model.Enum;
using CK1.OpenPlatform.SDK.Model.Tracking;
using CK1.OpenPlatform.SDK.Services;

using Newtonsoft.Json;
namespace SDK.Test
{
    class TrackingServiceTest
    {
        private TrackingService _service;
        private const string AccessToken = "YmE4MzBmN2EtMzJkMi00MjJkLWEyZjktZTdlODkyMDJhMWY1";

        public TrackingServiceTest()
        {
            this._service = new TrackingService(AccessToken);
        }

        public void GetInboundOrderStatusTest()
        {
            var trackingNumber = "CGT151028TST000002";
            var result = this._service.GetTracking(trackingNumber);
            var json = JsonConvert.SerializeObject(result);

            Console.Write(json);
        }
    }
}
