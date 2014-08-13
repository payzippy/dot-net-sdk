using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public interface ChargingRequestBuilder
    {
        // mandatory params
        ChargingRequestBuilder SetMerchantId(string merchantId);
        ChargingRequestBuilder SetBuyerEmailId(string buyerEmailId);
        ChargingRequestBuilder SetMerchantTransactionId(string merchantTransactionId);
        ChargingRequestBuilder SetTransactionType(string transactionType);
        ChargingRequestBuilder SetTransactionAmount(string transactionAmount);
        ChargingRequestBuilder SetPaymentMethod(string paymentMethod);
        ChargingRequestBuilder SetBankName(string bankName);
        ChargingRequestBuilder SetEmiMonths(string emiMonths);
        ChargingRequestBuilder SetCurrency(string currency);
        ChargingRequestBuilder SetUiMode(string uiMode);
        ChargingRequestBuilder SetHashMethod(string hashMethod);
        ChargingRequestBuilder SetMerchantKeyId(string merchantKeyId);
        ChargingRequestBuilder SetCallBackUrl(string callBackUrl);
        ChargingRequestBuilder SetBuyerPhoneNo(string buyerPhoneNo);
        ChargingRequestBuilder SetItemTotal(string itemTotal);
        ChargingRequestBuilder SetItemVertical(string itemVertical);
        ChargingRequestBuilder SetItemCount(string itemCount);


        // ==================================================
        // Optional parameters related to the product details
        // ==================================================
       
        ChargingRequestBuilder SetSource(string source);
        ChargingRequestBuilder SetProductInfo1(string productInfo1);
        ChargingRequestBuilder SetProductInfo2(string productInfo2);
        ChargingRequestBuilder SetProductInfo3(string productInfo3);
        
        

        // ===============================================
        // Optional parameters related to merchant details
        // ===============================================

        ChargingRequestBuilder SetTerminalId(string terminalId);
        ChargingRequestBuilder SetUdf1(string udf1);
        ChargingRequestBuilder SetUdf2(string udf2);
        ChargingRequestBuilder SetUdf3(string udf3);
        ChargingRequestBuilder SetUdf4(string udf4);
        ChargingRequestBuilder SetUdf5(string udf5);

        // ============================================
        // Optional parameters related to buyer details
        // ============================================

        ChargingRequestBuilder SetBuyerUniqueId(string buyerUniqueId);
        ChargingRequestBuilder SetShippingAddress(string shippingAddress);
        ChargingRequestBuilder SetShippingCity(string shippingCity);
        ChargingRequestBuilder SetShippingState(string shippingState);
        ChargingRequestBuilder SetShippingZip(string shippingZip);
        ChargingRequestBuilder SetShippingCountry(string shippingCountry);

        // ==============================================
        // Optional parameters related to billing details
        // ==============================================


        ChargingRequestBuilder SetBillingName(string billingName);
        ChargingRequestBuilder SetBillingAddress(string billingAddress);
        ChargingRequestBuilder SetBillingCity(string billingCity);
        ChargingRequestBuilder SetBillingState(string billingState);
        ChargingRequestBuilder SetBillingZip(string billingZip);
        ChargingRequestBuilder SetBillingCountry(string billingCountry);

        // ==============================================
        // Optional parameters useful for fraud detection
        // ==============================================

        ChargingRequestBuilder SetTimeGmt(string timeGmt);
        ChargingRequestBuilder SetMinSla(string minSla);
        ChargingRequestBuilder SetAddressCount(string addressCount);
        ChargingRequestBuilder SetSalesChannel(string salesChannel);
        ChargingRequestBuilder SetSMSNotifyNumber(string smsNotifyNumber);
        ChargingRequestBuilder SetIsUserLoggedIn(string isUserLoggedIn);

        
        ChargingRequest Build(string secretKey);
    }

}
