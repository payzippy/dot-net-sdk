using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using PayzippyDotNetSDK.payzippy_sdk;

namespace PayzippyDotNetSDK
{
    public partial class ChargingResp : System.Web.UI.Page
    {
        public string msgResponse;
        public string strParms;
        protected void Page_Load(object sender, EventArgs e)
        {
            msgResponse = "<h1> RESPONSE PARAMETERS </h1>";
            NameValueCollection postValues = Request.Form;
            NameValueCollection getValues = Request.QueryString;

            Dictionary<string, object> responseParams = new Dictionary<string, object>();

            if ((postValues.AllKeys.Length > 0) && (postValues.HasKeys()))
            {
                string nextPostKey;
                for (int i = 0; i < postValues.AllKeys.Length; i++)
                {
                    nextPostKey = postValues.AllKeys[i];
                    responseParams.Add(nextPostKey, postValues[i]);
                    strParms += nextPostKey + " = " + postValues[i] + "<BR />";
                }
            }

            else if ((getValues.AllKeys.Length > 0) && (getValues.HasKeys()))
            {
                string nextGetKey;
                for (int i = 0; i < getValues.AllKeys.Length; i++)
                {
                    nextGetKey = getValues.AllKeys[i];
                    responseParams.Add(nextGetKey, getValues[i]);
                    strParms += nextGetKey + " = " + getValues[i] + "<BR />";

                }

            }

            if (responseParams.Count == 0)
                return;

            ChargingResponse chargingResponse = new ChargingResponse(responseParams);

            if (chargingResponse.IsValidResponse(Config.SECRET_KEY))
            {

                msgResponse += "<p class='text-success' ><b>Hash matches. The response is valid. <BR/></p>";
                if (chargingResponse.IsSuccess())
                {
                    msgResponse += "<p class='text-success' >";
                }
                else
                {
                    msgResponse += "<p class='text-error' >";
                }
                msgResponse += chargingResponse.GetTransactionStatus() + "<BR/>";
                msgResponse += chargingResponse.GetTransactionResponseMessage() + "<BR/>";
                msgResponse += chargingResponse.GetTransactionResponseCode() + "<BR/></b></p>";

            }
            else
            {
                msgResponse += "<p class='text-error' >Hash mismatch. Response is invalid<BR/>";
            }
            this.Page.DataBind();
        }
    }
}