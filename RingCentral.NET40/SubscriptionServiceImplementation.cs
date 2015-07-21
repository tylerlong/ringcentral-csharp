﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PubNubMessaging;
using System.Diagnostics;

namespace RingCentral.Subscription
{
    public class SubscriptionServiceImplementation : ISubscriptionService
    {
        public void Subscribe(string channel, string channelGroup, Action<object> userCallback, Action<object> connectCallback, Action<SubscriptionError> errorCallback)
        {
            var pubnub = new PubNubMessaging.Core.Pubnub("","");

            pubnub.Subscribe<string>(channel, channelGroup, DisplaySubscribeReturnMessage, DisplaySubscribeConnectStatusMessage, DisplayErrorMessage);
        }

        public void Unsubscribe(string channel, string channelGroup, Action<object> userCallback, Action<object> connectCallback, Action<object> disconnectCallback, Action<SubscriptionError> errorCallback)
        {
            throw new NotImplementedException();
        }

        public void DisplaySubscribeReturnMessage(object message)
        {
            Debug.WriteLine("Subscribe Message: " + message);
        }

        public void DisplaySubscribeConnectStatusMessage(object message)
        {
            Debug.WriteLine("Connect Message: " + message);
        }

        public void DisplayErrorMessage(object message)
        {
            Debug.WriteLine("Error Message: " + message);
        }
    }
}