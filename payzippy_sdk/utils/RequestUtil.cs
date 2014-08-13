using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PayzippyDotNetSDK.payzippy_sdk
{
   public class RequestUtil
    {
      public static string GetUrl(Dictionary<string, object> requestParams,string  baseUrl){

        StringBuilder builder = new StringBuilder();
        if (requestParams == null || requestParams.Count == 0)
        {
            return "";
        }
            foreach (var entry in requestParams)
            {
                if (entry.Value != null)
                {
                    builder.Append(HttpUtility.UrlEncode(entry.Key, Encoding.UTF8) + "=");
                    builder.Append(HttpUtility.UrlEncode(Convert.ToString(entry.Value), Encoding.UTF8) + "&");
                }
            }

            return baseUrl + "?" + builder.ToString();
        }
         public static string GetPostData(Dictionary<string, object> requestParams)
         {

             StringBuilder builder = new StringBuilder();
             if (requestParams == null || requestParams.Count == 0)
             {
                 return "";
             }
             foreach (var entry in requestParams)
             {
                 if (entry.Value != null)
                 {
                      builder.Append(HttpUtility.UrlEncode(entry.Key, Encoding.UTF8) + "=");
                      builder.Append(HttpUtility.UrlEncode(Convert.ToString(entry.Value), Encoding.UTF8) + "&");
                 }
             }

             return builder.ToString();
         }
    }

    }
