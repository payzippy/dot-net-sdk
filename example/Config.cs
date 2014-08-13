using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public class Config
    {
        public static readonly string MERCHANT_ID = ""; // Your Merchant ID
        public static readonly string SECRET_KEY = ""; // Your Secret Key. Do not share this.
        public static readonly string TRANSACTION_TYPE = "SALE";
        public static readonly string CURRENCY = "INR";
        public static readonly string MERCHANT_KEY_ID = ""; // Your Merchant Key ID
        public static readonly string CALLBACK_URL = ""; // Your callback URL
        public static readonly string API_CHARGING = "";
        public static readonly string API_QUERY = "";
        public static readonly string API_REFUND = "";
        // public static readonly string UI_MODE = "REDIRECT"; // UI Integration - REDIRECT or IFRAME
        // public static readonly string HASH_METHOD = "SHA256"; // MD5 or SHA256

    }
}
