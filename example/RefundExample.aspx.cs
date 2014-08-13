using System;
using System.Collections;
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

namespace PayzippyDotNetSDK
{
    public partial class RefundExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Refund_OnClick(object sender, EventArgs e)
        {
            RefundRequestBuilder refundBuilder = RefundRequest.GetBuilder();

            RefundRequest refundRequest =refundBuilder
    .SetMerchantId(Config.MERCHANT_ID)
	.SetMerchantKeyId(merchant_key_id.Value)
	.SetMerchantTransactionId(merchant_transaction_id.Value)
	.SetPayzippySaleTransactionId(payzippy_sale_transaction_id.Value)
	.SetHashMethod(hash_method.Value)
	.SetRefundAmount(refund_amount.Value)
    .SetRefundReason(refund_reason.Value)
    .SetRefundedBy(refunded_by.Value)
    .SetUdf1(udf1.Value)
    .SetUdf2(udf2.Value)
    .SetUdf3(udf3.Value)
    .SetUdf4(udf4.Value)
    .SetUdf5(udf5.Value)
    .Build(Config.SECRET_KEY);

            string jsonResponse = WebClient.DoRefund(refundRequest.GetRequestParams(), Config.API_REFUND);
            this.Context.Items.Add("refund_response", jsonResponse);
            this.Server.Transfer("RefundResp.aspx");
        }
    }
}
