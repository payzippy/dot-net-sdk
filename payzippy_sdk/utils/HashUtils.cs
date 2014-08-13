using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PayzippyDotNetSDK.payzippy_sdk
{
   public class HashUtils
    {
        public static String GenerateHash(Dictionary<string, object> chargingParams, string secretKey, string hashMode)
        {
            List<string> list = new List<string>(chargingParams.Keys);
            list.Sort();
            StringBuilder stringForHash = new StringBuilder();
            foreach (string key in list)
            {
                string value = Convert.ToString(chargingParams[key]);
                if (value != null && !"hash".Equals(key, StringComparison.InvariantCultureIgnoreCase))
                    stringForHash.Append(value + "|");
            }
            stringForHash.Append(secretKey);
            return CreateHash(stringForHash.ToString(), hashMode);
        }



        private static string CreateHash(string input, string hashMode)
        {   
            byte[] hashValue = null;
            string hash = string.Empty;
 
            if ("md5".Equals(hashMode, StringComparison.InvariantCultureIgnoreCase))
            {
                MD5 hashString = new MD5CryptoServiceProvider();
               hashValue =  hashString.ComputeHash(Encoding.ASCII.GetBytes(input), 0, Encoding.ASCII.GetByteCount(input));
   
            }
            else if ("sha256".Equals(hashMode, StringComparison.InvariantCultureIgnoreCase))
            {
                SHA256Managed hashString = new SHA256Managed();
                hashValue = hashString.ComputeHash(Encoding.ASCII.GetBytes(input), 0, Encoding.ASCII.GetByteCount(input));
            }

            foreach (byte x in hashValue)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;


        }
    }
}
