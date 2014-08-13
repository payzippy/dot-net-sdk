using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PayzippyDotNetSDK.payzippy_sdk
{
   public class ChargingRequest
    {
        private Dictionary<string, object> requestParams;

        public ChargingRequest(Dictionary<string, object> requestParams)
        {
            this.requestParams = requestParams;
        }

        public class Builder : ChargingRequestBuilder
        {
            public Dictionary<string, object> requestParams = new Dictionary<string, object>();


            // ==================================================
            // mandatory params
            // ==================================================

            public ChargingRequestBuilder SetMerchantId(string merchantId)
            {
                requestParams.Add(Constants.MERCHANT_ID, merchantId);
                return this;

            }

            public ChargingRequestBuilder SetBuyerEmailId(string buyerEmailId)
            {
                requestParams.Add(Constants.BUYER_EMAIL_ADDRESS, buyerEmailId);
                return this;

            }

            public ChargingRequestBuilder SetMerchantTransactionId(string merchantTransactionId)
            {
                requestParams.Add(Constants.MERCHANT_TRANSACTION_ID, merchantTransactionId);
                return this;

            }

            public ChargingRequestBuilder SetPaymentMethod(string paymentMethod)
            {
                requestParams.Add(Constants.PAYMENT_METHOD, paymentMethod);
                return this;

            }

            public ChargingRequestBuilder SetEmiMonths(string emiMonths)
            {
                requestParams.Add(Constants.EMI_MONTHS, emiMonths);
                return this;

            }

            public ChargingRequestBuilder SetCurrency(string currency)
            {
                requestParams.Add(Constants.CURRENCY, currency);
                return this;

            }

            public ChargingRequestBuilder SetMerchantKeyId(string merchantKeyId)
            {
                requestParams.Add(Constants.MERCHANT_KEY_ID, merchantKeyId);
                return this;

            }

            public ChargingRequestBuilder SetBankName(string bankName)
            {
                requestParams.Add(Constants.BANK_NAME, bankName);
                return this;

            }

            public ChargingRequestBuilder SetUiMode(string uiMode)
            {
                requestParams.Add(Constants.UI_MODE, uiMode);
                return this;

            }

            public ChargingRequestBuilder SetTransactionAmount(string transactionAmount)
            {
                requestParams.Add(Constants.TRANSACTION_AMOUNT, transactionAmount);
                return this;

            }

            public ChargingRequestBuilder SetHashMethod(string hashMethod)
            {
                requestParams.Add(Constants.HASH_METHOD, hashMethod.ToUpper());
                return this;

            }

            public ChargingRequestBuilder SetTransactionType(string transactionType)
            {
                requestParams.Add(Constants.TRANSACTION_TYPE, transactionType);
                return this;

            }
            public ChargingRequestBuilder SetCallBackUrl(string callBackUrl)
            {
                requestParams.Add(Constants.CALLBACK_URL, callBackUrl);
                return this;

            }

           

            public ChargingRequestBuilder SetBuyerPhoneNo(string buyerPhoneNo)
            {
                requestParams.Add(Constants.BUYER_PHONE_NO, buyerPhoneNo);
                return this;

            }


            public ChargingRequestBuilder SetItemTotal(string itemTotal)
            {
                string replacedValue = ReplaceSpecialCharacters(itemTotal);
                requestParams.Add(Constants.ITEM_TOTAL, replacedValue);
                return this;

            }
            public ChargingRequestBuilder SetItemVertical(string itemVertical)
            {
                string replacedValue = ReplaceSpecialCharacters(itemVertical);
                requestParams.Add(Constants.ITEM_VERTICAL, replacedValue);
                return this;

            }

            public ChargingRequestBuilder SetItemCount(string itemCount)
            {
                requestParams.Add(Constants.ITEM_COUNT, itemCount);
                return this;
            }


            // ============================================
            // Optional parameters related to buyer details
            // ============================================


            public ChargingRequestBuilder SetBuyerUniqueId(string buyerUniqueId)
            {
                requestParams.Add(Constants.BUYER_UNIQUE_ID, buyerUniqueId);
                return this;
            }
            public ChargingRequestBuilder SetShippingAddress(string shippingAddress)
            {
                string replacedValue = ReplaceSpecialCharacters(shippingAddress);
                requestParams.Add(Constants.SHIPPING_ADDRESS, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetShippingCity(string shippingCity)
            {
                string replacedValue = ReplaceSpecialCharacters(shippingCity);
                requestParams.Add(Constants.SHIPPING_CITY, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetShippingState(string shippingState)
            {
                string replacedValue = ReplaceSpecialCharacters(shippingState);
                requestParams.Add(Constants.SHIPPING_STATE, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetShippingZip(string shippingZip)
            {
                string replacedValue = ReplaceSpecialCharacters(shippingZip);
                requestParams.Add(Constants.SHIPPING_ZIP, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetShippingCountry(string shippingCountry)
            {
                string replacedValue = ReplaceSpecialCharacters(shippingCountry);
                requestParams.Add(Constants.SHIPPING_COUNTRY, replacedValue);
                return this;
            }


            // ==============================================
            // Optional parameters related to billing details
            // ==============================================

            public ChargingRequestBuilder SetBillingName(string billingName)
            {
                string replacedValue = ReplaceSpecialCharacters(billingName);
                requestParams.Add(Constants.BILLING_NAME, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetBillingAddress(string billingAddress)
            {
                string replacedValue = ReplaceSpecialCharacters(billingAddress);
                requestParams.Add(Constants.BILLING_ADDRESS, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetBillingCity(string billingCity)
            {
                string replacedValue = ReplaceSpecialCharacters(billingCity);
                requestParams.Add(Constants.BILLING_CITY, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetBillingState(string billingState)
            {
                string replacedValue = ReplaceSpecialCharacters(billingState);
                requestParams.Add(Constants.BILLING_STATE, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetBillingZip(string billingZip)
            {
                string replacedValue = ReplaceSpecialCharacters(billingZip);
                requestParams.Add(Constants.BILLING_ZIP, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetBillingCountry(string billingCountry)
            {
                string replacedValue = ReplaceSpecialCharacters(billingCountry);
                requestParams.Add(Constants.BILLING_COUNTRY, replacedValue);
                return this;
            }

            // ==================================================
            // Optional parameters related to the product details
            // ==================================================

            public ChargingRequestBuilder SetSource(string source)
            {
                requestParams.Add(Constants.SOURCE, source);
                return this;
            }
            
            public ChargingRequestBuilder SetProductInfo1(string productInfo1)
            {
                string replacedValue = ReplaceSpecialCharacters(productInfo1);
                requestParams.Add(Constants.PRODUCT_INFO1, replacedValue);
                return this;
            }

            public ChargingRequestBuilder SetProductInfo2(string productInfo2)
            {
                string replacedValue = ReplaceSpecialCharacters(productInfo2);
                requestParams.Add(Constants.PRODUCT_INFO2, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetProductInfo3(string productInfo3)
            {
                string replacedValue = ReplaceSpecialCharacters(productInfo3);
                requestParams.Add(Constants.PRODUCT_INFO3, replacedValue);
                return this;
            }


            // ===============================================
            // Optional parameters related to merchant details
            // ===============================================

            public ChargingRequestBuilder SetTerminalId(string terminalId)
            {
                requestParams.Add(Constants.TERMINAL_ID, terminalId);
                return this;
            }
           

            public ChargingRequestBuilder SetUdf1(string udf1)
            {
                string replacedValue = ReplaceSpecialCharacters(udf1);
                requestParams.Add(Constants.UDF1, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetUdf2(string udf2)
            {
                string replacedValue = ReplaceSpecialCharacters(udf2);
                requestParams.Add(Constants.UDF2, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetUdf3(string udf3)
            {
                string replacedValue = ReplaceSpecialCharacters(udf3);
                requestParams.Add(Constants.UDF3, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetUdf4(string udf4)
            {
             string replacedValue = ReplaceSpecialCharacters(udf4);
                requestParams.Add(Constants.UDF4, replacedValue);
                return this;
            }
            public ChargingRequestBuilder SetUdf5(string udf5)
            {
               string replacedValue = ReplaceSpecialCharacters(udf5);
               requestParams.Add(Constants.UDF5, replacedValue);
                return this;
            }

            // ==============================================
            // Optional parameters useful for fraud detection
            // ==============================================
	
	      public ChargingRequestBuilder SetMinSla(string minSla)
          {
            requestParams.Add(Constants.MIN_SLA, minSla);
                 return this;
          }
	
	      public ChargingRequestBuilder SetAddressCount(string addressCount)
          {
            requestParams.Add(Constants.ADDRESS_COUNT, addressCount);
                return this;
          }

          public ChargingRequestBuilder SetSalesChannel(string salesChannel)
           {
              string replacedValue = ReplaceSpecialCharacters(salesChannel);
              requestParams.Add(Constants.SALES_CHANNEL, replacedValue);
              return this;
           }
	
	     public ChargingRequestBuilder SetSMSNotifyNumber(string smsNotifyNumber)
         {
             requestParams.Add(Constants.SMS_NOTIFY_NUMBER, smsNotifyNumber);
                return this;
         }
         public ChargingRequestBuilder SetIsUserLoggedIn(string isUserLoggedIn)
         {
          requestParams.Add(Constants.IS_USER_LOGGED_IN, isUserLoggedIn);
          return this;
         }

        public ChargingRequestBuilder SetTimeGmt(string timeGmt)
        {
         requestParams.Add(Constants.TIMEGMT, timeGmt);
         return this;
        }


        private string ReplaceSpecialCharacters(string valueOld)
        {
         Regex regexObject = new Regex(@"[^A-Za-z0-9 \\\._#!@$|;{},?^*':()+[\]=-]", RegexOptions.IgnoreCase);
         return regexObject.Replace(Convert.ToString(valueOld), " ");
        }

        public ChargingRequest Build(string secretKey)
            {
                ValidityCheck.ValidateChargeParams(this.requestParams);
            
                if (!requestParams.ContainsKey(Constants.HASH))
                {
                    requestParams.Add(Constants.HASH, HashUtils.GenerateHash(requestParams, secretKey, this.requestParams[(Constants.HASH_METHOD)].ToString()));
                }
                return new ChargingRequest(this.requestParams);
            }

        }

        public static ChargingRequestBuilder GetBuilder()
        {
            return new Builder();
        }

        public Dictionary<string, object> GetRequestParams()
        {
            return requestParams;
        }

        public string GetMerchantId()
        {
            return requestParams[Constants.MERCHANT_ID].ToString();
        }

        public string GetBuyerEmailId()
        {
            return requestParams[Constants.BUYER_EMAIL_ADDRESS].ToString();
        }

        public string GetMerchantTransactionId()
        {
            return requestParams[Constants.MERCHANT_TRANSACTION_ID].ToString();
        }

        public string GetTransactionType()
        {
            return requestParams[Constants.TRANSACTION_TYPE].ToString();
        }

        // Transaction Amount in paise

        public string GetTransactionAmount()
        {
            return requestParams[Constants.TRANSACTION_AMOUNT].ToString();
        }

        public string GetPaymentMethod()
        {
            return requestParams[Constants.PAYMENT_METHOD].ToString();
        }

        public string GetBankName()
        {
            return requestParams[Constants.BANK_NAME].ToString();
        }

        public string GetEmiMonths()
        {
            return requestParams[Constants.EMI_MONTHS].ToString();
        }

        public string GetCurrency()
        {
            return requestParams[Constants.CURRENCY].ToString();
        }

        public string GetUiMode()
        {
            return requestParams[Constants.UI_MODE].ToString();
        }

        public string GetHashMethod()
        {
            return requestParams[Constants.HASH_METHOD].ToString();
        }

        public string GetHash()
        {
            return requestParams[Constants.HASH].ToString();
        }

        public string GetMerchantKeyId()
        {
            return requestParams[Constants.MERCHANT_KEY_ID].ToString();
        }
        public string GetCallBackUrl()
        {
            return requestParams[Constants.CALLBACK_URL].ToString();
        }

        public string GetBuyerPhoneNo()
        {
            return requestParams[Constants.BUYER_PHONE_NO].ToString();
        }
        public string GetItemTotal()
        {
            return requestParams[Constants.ITEM_TOTAL].ToString();
        }
        public string GetItemVertical()
        {
            return requestParams[Constants.ITEM_VERTICAL].ToString();
        }

        public string GetItemCount()
        {
            return requestParams[Constants.ITEM_COUNT].ToString();
         
        }
        public string GetBuyerUniqueId()
        {
            return requestParams[Constants.BUYER_UNIQUE_ID].ToString();
        }
        public string GetShippingAddress()
        {
            return requestParams[Constants.SHIPPING_ADDRESS].ToString();
        }
        public string GetShippingCity()
        {
            return requestParams[Constants.SHIPPING_CITY].ToString();
        }
        public string GetShippingState()
        {
            return requestParams[Constants.SHIPPING_STATE].ToString();
        }
        public string GetShippingZip()
        {
            return requestParams[Constants.SHIPPING_ZIP].ToString();
        }
        public string GetShippingCountry()
        {
            return requestParams[Constants.SHIPPING_COUNTRY].ToString();
        }
        public string GetSource()
        {
            return requestParams[Constants.SOURCE].ToString();
        }
        public string GetBillingName()
        {
            return requestParams[Constants.BILLING_NAME].ToString();
        }
        public string GetBillingAddress()
        {
            return requestParams[Constants.BILLING_ADDRESS].ToString();
        }
        public string GetBillingCity()
        {
            return requestParams[Constants.BILLING_CITY].ToString();
        }
        public string GetBillingState()
        {
            return requestParams[Constants.BILLING_STATE].ToString();
        }
        public string GetBillingZip()
        {
            return requestParams[Constants.BILLING_ZIP].ToString();
        }
        public string GetBillingCountry()
        {
            return requestParams[Constants.BILLING_COUNTRY].ToString();
        }
        public string GetIsUserLoggedIn()
        {
            return requestParams[Constants.IS_USER_LOGGED_IN].ToString();
        }
        public string GetProductInfo1()
        {
            return requestParams[Constants.PRODUCT_INFO1].ToString();
        }

        public string GetProductInfo2()
        {
            return requestParams[Constants.PRODUCT_INFO2].ToString();
        }
        public string GetProductInfo3()
        {
            return requestParams[Constants.PRODUCT_INFO3].ToString();
        }
        public string GetTimeGmt()
        {
            return requestParams[Constants.TIMEGMT].ToString();
        }

        public string GetUdf1()
        {
            return requestParams[Constants.UDF1].ToString();
        }
        public string GetUdf2()
        {
            return requestParams[Constants.UDF2].ToString();
        }
        public string GetUdf3()
        {
            return requestParams[Constants.UDF3].ToString();
        }
        public string GetUdf4()
        {
            return requestParams[Constants.UDF4].ToString();
        }
        public string GetUdf5()
        {
           return requestParams[Constants.UDF5].ToString();
        }

        public string GetTerminalId()
        {
           return  requestParams[Constants.TERMINAL_ID].ToString();
          
        }

        public string GetMinSla()
        {
            return requestParams[Constants.MIN_SLA].ToString();
            
        }

        public string GetAddressCount()
        {
            return requestParams[Constants.ADDRESS_COUNT].ToString();
            
        }

        public string GetSalesChannel()
        {
            return requestParams[Constants.SALES_CHANNEL].ToString();
        }  

        public string SetSMSNotifyNumber()
        {
          return  requestParams[Constants.SMS_NOTIFY_NUMBER].ToString();
           
        }

        public string GetUrl(string baseUrl)
        {
            return RequestUtil.GetUrl(requestParams, baseUrl);
        }

    }
}
