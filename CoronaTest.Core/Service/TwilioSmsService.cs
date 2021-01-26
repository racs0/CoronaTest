﻿using CoronaTest.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace CoronaTest.Core.Service
{
   public  class TwilioSmsService : ISmsService
    {
        private readonly string _accountSid;
        private readonly string _authToken;

        public TwilioSmsService(string accountSid, string authToken)
        {
            _accountSid = accountSid;
            _authToken = authToken;
        }

        public bool SendSms(string to, string message)
        {
            try
            {
                TwilioClient.Init(_accountSid, _authToken);

                var sms = MessageResource.Create(
                    body: "Hello World from Twilio SMS service.",
                    from: new Twilio.Types.PhoneNumber("+178549179541"),
                    to: new Twilio.Types.PhoneNumber("+436604928390")
                );
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }


            return true;
        }
    }
}
