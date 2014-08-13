using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Specialized;
using PayzippyDotNetSDK.payzippy_sdk;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayzippyDotNetSDK
{
    public partial class RefundResp : System.Web.UI.Page
    {
        public string msgResponse;
        public string strParams;
        protected void Page_Load(object sender, EventArgs e)
        {
            msgResponse = "<h1> RESPONSE PARAMETERS </h1>";
            string jsonResponse = this.Context.Items["refund_response"].ToString();
            Dictionary<string, object> response = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(jsonResponse));
            RefundResponse refundResponse = new RefundResponse(response);

            if (refundResponse.IsValidResponse(Config.SECRET_KEY))
            {
                msgResponse += "<p class='text-success' ><b>Hash matches. The response is valid<BR/></b></p>";
                if (refundResponse.IsSuccess())
                {
                    msgResponse += "<p class='text-success' ><b>Refund Successful<BR/></b></p>";

                }
                else
                {
                    msgResponse += "<p class='text-error' ><b>Refund Unsuccessful<BR/>";
                    msgResponse += "Refund Response Message : " + refundResponse.GetRefundResponseMessasge() + "<BR/>";
                    msgResponse += "Transaction time : " + refundResponse.GetTransactionTime() + "</b><BR/></p>";
                }
            }
            else
            {
                msgResponse += "<p class='text-error' ><b>Invalid ResponseReasons: Invalid hash, Validation failure, Payzippy technical Error </b></p><BR/> ";
            }
            
            foreach (string key in response.Keys)
            {
                if (key.Equals("data"))
                {
                    Dictionary<string, object> data = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(response[key]));
                    if (data.Count > 0)
                    {
                        foreach (string dKey in data.Keys)
                        {
                            strParams += dKey + " = " + data[dKey] + "<BR />";
                        }
                    }
                }
                else
                {
                    strParams += key + " = " + response[key] + "<BR />";
                }
            }

            this.Page.DataBind();   
        }
    }
}
