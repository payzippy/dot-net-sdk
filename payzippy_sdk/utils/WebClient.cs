using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public class WebClient
    {
        public static string DoGet(Dictionary<string, object> requestParams, string baseUrl)
        {
            WebRequest request = WebRequest.Create(RequestUtil.GetUrl(requestParams, baseUrl));

            // Get the response
            WebResponse response = request.GetResponse();
            StreamReader responseText = new StreamReader(response.GetResponseStream());
            return responseText.ReadToEnd().Trim();
            
            
        }
        public static string DoPost(Dictionary<string, object> requestParams, string baseUrl)
        {
            WebRequest request = WebRequest.Create(baseUrl);
            string postData = RequestUtil.GetPostData(requestParams);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            byte[] bytes = Encoding.ASCII.GetBytes(postData);
            request.ContentLength = bytes.Length;
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(bytes, 0, bytes.Length);
            reqStream.Close();

            // Get the response
            WebResponse response = request.GetResponse();
            StreamReader responseText = new StreamReader(response.GetResponseStream());
            return responseText.ReadToEnd().Trim();
           
        }

        public static string DoQuery(Dictionary<string, object> requestParams, string baseUrl)
	    {
            return DoPost(requestParams, baseUrl);
	    }

        public static string DoRefund(Dictionary<string, object> requestParams, string baseUrl)
	  {
          return DoPost(requestParams, baseUrl);
	   }

    }
}
