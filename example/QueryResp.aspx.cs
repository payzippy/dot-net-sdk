using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using PayzippyDotNetSDK.payzippy_sdk;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayzippyDotNetSDK
{
    public partial class QueryResp : System.Web.UI.Page
    {
        public string msgResponse;
        public string strParms;
        protected void Page_Load(object sender, EventArgs e)
        {
            msgResponse = "<h1> RESPONSE PARAMETERS </h1>";
            string jsonResponse = this.Context.Items["query_response"].ToString();
            Dictionary<string, object> response = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(jsonResponse));
            QueryResponse queryResponse = new QueryResponse(response);
            

            if (queryResponse.IsValidResponse(Config.SECRET_KEY))
            {
                msgResponse += "<p class='text-success'><b>Hash matches. The response is valid <BR/></p>";
                msgResponse += "Status Message : " + queryResponse.GetStatusMessage() + "<BR/>";
                msgResponse += "Error Message : " + queryResponse.GetErrorMessage() + "</b><BR/>";
            }
            else
            {
                msgResponse += "<p class='text-error' >Invalid Response (Reasons: Invalid hash, Validation failure, Payzippy technical Error </b><BR/> ";
            }

            foreach (string key in response.Keys)
		        {
			       if (key.Equals("data"))
			          {
                       List<Dictionary<string, object>> data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonConvert.SerializeObject(response[key]));
				         
				         if (data.Count > 0)
				           {
					         for (int i = 0; i < data.Count; i++)
					             {
						            foreach (string dKey in data[i].Keys)
						               {
                                           strParms += dKey + " = " + data[i][dKey] + "<BR />";
						               }
                                    strParms += "<HR/>";
					              }
				            }				         
			          }
			          else
			           {
                           strParms += key + " = " + response[key] + "<BR />";
			           }
		         }
            this.Page.DataBind();
        }
    }
}