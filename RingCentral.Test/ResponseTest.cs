﻿using System;
using NUnit.Framework;
using RingCentral.Http;

namespace RingCentral.Test
{
    public class ResponseTest : TestConfiguration
    {
        protected const string AccountInformationEndPoint = "/restapi/v1.0/account/";
        protected const string AccountExtensionInformationEndPoint = "/restapi/v1.0/account/~/extension";
        //[Test]
        public void GetResponseErrorMessage()
        {

            //Request request = new Request(AccountInformationEndPoint + "5");
           // Response result = RingCentralClient.GetPlatform().Get(request);
            //var errorResult =  result.GetError();
            //Assert.IsNotNull(errorResult);
            //Assert.AreEqual("Service Temporary Unavailable", errorResult);
       
        }
        //[Test]
        public void GetResponseErrorBadGrantType()
        {
            //Request request = new Request(AccountExtensionInformationEndPoint + "/7");
            //Response result = RingCentralClient.GetPlatform().Get(request);
            //var errorResult = result.GetError();
            //Assert.IsNotNull(errorResult);
            //Assert.AreEqual("Unsupported grant type",errorResult);
        }
        [Test, ExpectedException(typeof(Exception), ExpectedMessage = @"Response is not JSON")]
        public void GetResponseNonJson()
        {
            Request request = new Request(AccountExtensionInformationEndPoint + "/6");
            Response result = RingCentralClient.GetPlatform().Get(request);
            var jsonResult =  result.GetJson();
            
        }

        [Test]
        public void GetErrorGoodCheckStatus()
        {
           Request request = new Request(AccountInformationEndPoint);
           Response result = RingCentralClient.GetPlatform().Get(request);
           Assert.IsNull(result.GetError());
        }

        //[Test]
        //public void SetRequestXHttpOverrideHeader()
        //{

        //    const string xHttpOverRideHeader = "GET";

        //    var request = new Request("/restapi/v1.0/account/~");
        //    request.SetXhttpOverRideHeader(xHttpOverRideHeader);
        //    var requestHeader = request.GetXhttpOverRideHeader();
        //    Assert.AreEqual(requestHeader, xHttpOverRideHeader);
        //}
    }
}
