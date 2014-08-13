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
    public partial class ChargingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Charge_OnClick(object sender, EventArgs e)
        {
            ChargingRequestBuilder chargingBuilder = ChargingRequest.GetBuilder();
            ChargingRequest chargingRequest = chargingBuilder
       .SetMerchantId(Config.MERCHANT_ID)
       .SetCallBackUrl(Config.CALLBACK_URL)
       .SetBuyerEmailId(buyer_email_address.Value)
       .SetMerchantTransactionId(merchant_transaction_id.Value)
       .SetTransactionType(transaction_type.Value)
       .SetTransactionAmount(transaction_amount.Value)
       .SetPaymentMethod(payment_method.Value)
       .SetBankName(bank_name.Value)
       .SetEmiMonths(emi_months.Value)
       .SetCurrency(currency.Value)
       .SetUiMode(ui_mode.Value)
       .SetHashMethod(hash_method.Value)
       .SetMerchantKeyId(merchant_key_id.Value)
       .SetBuyerPhoneNo(buyer_phone_no.Value)
       .SetItemTotal(item_total.Value)
       .SetItemVertical(item_vertical.Value)
       .SetBuyerUniqueId(buyer_unique_id.Value)
       .SetShippingAddress(shipping_address.Value)
       .SetShippingCity(shipping_city.Value)
       .SetShippingState(shipping_state.Value)
       .SetShippingZip(shipping_zip.Value)
       .SetShippingCountry(shipping_country.Value)
       .SetSource(source.Value)
       .SetBillingName(billing_name.Value)
       .SetBillingAddress(billing_address.Value)
       .SetBillingCity(billing_city.Value)
       .SetBillingState(billing_state.Value)
       .SetBillingZip(billing_zip.Value)
       .SetBillingCountry(billing_country.Value)
       .SetIsUserLoggedIn(is_user_logged_in.Value)
       .SetProductInfo1(product_info1.Value)
       .SetProductInfo2(product_info2.Value)
       .SetProductInfo3(product_info3.Value)
       .SetUdf1(udf1.Value)
       .SetUdf2(udf2.Value)
       .SetUdf3(udf3.Value)
       .SetUdf4(udf4.Value)
       .SetUdf5(udf5.Value)
       .SetMinSla(min_sla.Value)
       .SetAddressCount(address_count.Value)
       .SetSalesChannel(sales_channel.Value)
       .SetSMSNotifyNumber(sms_notify_number.Value)
       .SetTerminalId(terminal_id.Value)
       .Build(Config.SECRET_KEY);


            if ((ui_mode.Value).Equals("REDIRECT"))
            {
                Response.Redirect(chargingRequest.GetUrl(Config.API_CHARGING));
            }
            else if ((ui_mode.Value).Equals("IFRAME"))
            {
                this.Context.Items.Add("charging_url", chargingRequest.GetUrl(Config.API_CHARGING));
                this.Server.Transfer("ChargeIframe.aspx");
            }
        }
    }

}

