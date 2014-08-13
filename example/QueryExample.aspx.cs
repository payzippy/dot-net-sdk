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
    public partial class QueryExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Query_OnClick(object sender, EventArgs e)
        {
            QueryRequestBuilder queryBuilder = QueryRequest.GetBuilder();
            QueryRequest queryRequest =
                    queryBuilder.SetMerchantId(Config.MERCHANT_ID)
                                .SetMerchantKeyId(merchant_key_id.Value)
                                .SetMerchantTransactionId(merchant_transaction_id.Value)
                                .SetPayzippyTransactionId(payzippy_transaction_id.Value)
                                .SetHashMethod(hash_method.Value)
                                .Build(Config.SECRET_KEY);

            string jsonResponse = WebClient.DoQuery(queryRequest.GetRequestParams(), Config.API_QUERY);
            this.Context.Items.Add("query_response", jsonResponse);
            this.Server.Transfer("QueryResp.aspx");

        }


    }
}