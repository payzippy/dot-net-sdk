using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public class ValidityCheck
    {
        public static bool IsNumbers(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsDigit(c))
                    return true;
            }
            return false;

        }



        public static bool ValidateChargeParams(Dictionary<string, object> requestParams)
        {
            // Mandatory Parameters

            // Validating merchant id
            if (String.IsNullOrEmpty((requestParams[Constants.MERCHANT_ID].ToString()))
                    || requestParams[Constants.MERCHANT_ID].ToString().Length > Constants.MERCHANT_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT ID");
            }
            // Validating buyers email address
            else if (String.IsNullOrEmpty(requestParams[Constants.BUYER_EMAIL_ADDRESS].ToString())
                    || requestParams[Constants.BUYER_EMAIL_ADDRESS].ToString().Length > Constants.BUYER_EMAIL_ADDRESS_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BUYER EMAIL ADDRESS");
            }
            // Validating Merchant transaction id
            else if (String.IsNullOrEmpty(requestParams[Constants.MERCHANT_TRANSACTION_ID].ToString())
                    || requestParams[Constants.MERCHANT_TRANSACTION_ID].ToString().Length > Constants.MERCHANT_TRANSACTION_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT TRANSACTION ID");
            }

            // Validating transaction amount
            else if (String.IsNullOrEmpty(requestParams[Constants.TRANSACTION_AMOUNT].ToString())
                    || IsNumbers(requestParams[Constants.TRANSACTION_AMOUNT].ToString()))
            {
                throw new System.ArgumentException("INVALID TRANSACTION AMOUNT");
            }
            // Validating payment method
            else if (String.IsNullOrEmpty(requestParams[Constants.PAYMENT_METHOD].ToString())
                    || !Constants.validPaymentMethods.Contains(requestParams[Constants.PAYMENT_METHOD].ToString()))
            {
                throw new System.ArgumentException("INVALID PAYMENT METHOD");
            }
            // Validating bank name
            else if (Constants.bankNameRequirement.Contains(requestParams[Constants.PAYMENT_METHOD].ToString())
                    && (String.IsNullOrEmpty(requestParams[Constants.BANK_NAME].ToString())))
            {
                throw new System.ArgumentException("BANK NAME NOT SET");
            }

            // Validating EMI value
            else if ("emi".Equals(requestParams[Constants.PAYMENT_METHOD].ToString(), StringComparison.InvariantCultureIgnoreCase)
                    && (String.IsNullOrEmpty(requestParams[Constants.EMI_MONTHS].ToString())
                            || IsNumbers(requestParams[Constants.EMI_MONTHS].ToString()) ||
                            Int32.Parse(requestParams[Constants.EMI_MONTHS].ToString()) <= 0))
            {
                throw new System.ArgumentException("INVALID EMI MONTHS");
            }
            // Validating currency
            else if (String.IsNullOrEmpty(requestParams[Constants.CURRENCY].ToString()))
            {
                throw new System.ArgumentException("CURRENCY NOT SET");
            }

            // Validating UI mode
            else if (String.IsNullOrEmpty(requestParams[Constants.UI_MODE].ToString())
                    || !Constants.uiModeRequirements.Contains(requestParams[Constants.UI_MODE].ToString()))
            {
                throw new System.ArgumentException("INVALID UI MODE");
            }
            // Validating hash method
            else if (String.IsNullOrEmpty(requestParams[Constants.HASH_METHOD].ToString())
                    || !Constants.hashMethodRequirements.Contains(requestParams[Constants.HASH_METHOD].ToString()))
            {
                throw new System.ArgumentException("INVALID HASH METHOD, MD5 and SHA256 only (must be in uppercase)");
            }
            // Validating merchant key id
            else if (String.IsNullOrEmpty(requestParams[Constants.MERCHANT_KEY_ID].ToString())
                    || requestParams[Constants.MERCHANT_KEY_ID].ToString().Length > Constants.MERCHANT_KEY_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT KEY ID");
            }
            // Validating transaction_type
            else if (String.IsNullOrEmpty(requestParams[Constants.TRANSACTION_TYPE].ToString())
                    || !"SALE".Equals(requestParams[Constants.TRANSACTION_TYPE].ToString()))
            {
                throw new System.ArgumentException("INVALID MERCHANT TRANSACTION TYPE");
            }

            // -------------------------- Optional Parameters ------------------------------

            // validating buyer_phone_no
            else if (requestParams.ContainsKey(Constants.BUYER_PHONE_NO)
                    && requestParams[Constants.BUYER_PHONE_NO].ToString().Length > Constants.BUYER_PHONE_NO_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BUYER_PHONE_NO");
            }
            // validating buyer_unique_id
            else if (requestParams.ContainsKey(Constants.BUYER_UNIQUE_ID)
                    && requestParams[Constants.BUYER_UNIQUE_ID].ToString().Length > Constants.BUYER_UNIQUE_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BUYER_UNIQUE_ID");
            }
            // validating shipping_address
            else if (requestParams.ContainsKey(Constants.SHIPPING_ADDRESS)
                    && requestParams[Constants.SHIPPING_ADDRESS].ToString().Length > Constants.SHIPPING_ADDRESS_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SHIPPING ADDRESS");
            }

             // validating shipping_city
            else if (requestParams.ContainsKey(Constants.SHIPPING_CITY)
                    && requestParams[Constants.SHIPPING_CITY].ToString().Length > Constants.SHIPPING_CITY_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SHIPPING CITY");
            }
            // validating shipping_state
            else if (requestParams.ContainsKey(Constants.SHIPPING_STATE)
                    && requestParams[Constants.SHIPPING_STATE].ToString().Length > Constants.SHIPPING_STATE_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SHIPPING STATE");
            }

            // validating shipping_zip
            else if (requestParams.ContainsKey(Constants.SHIPPING_ZIP)
                    && requestParams[Constants.SHIPPING_ZIP].ToString().Length > Constants.SHIPPING_ZIP_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SHIPPING_ZIP");
            }
            // validating shipping_country
            else if (requestParams.ContainsKey(Constants.SHIPPING_COUNTRY)
                    && requestParams[Constants.SHIPPING_COUNTRY].ToString().Length > Constants.SHIPPING_COUNTRY_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SHIPPING_COUNTRY");
            }
            // validating source
            else if (requestParams.ContainsKey(Constants.SOURCE)
                    && requestParams[Constants.SOURCE].ToString().Length > Constants.SOURCE_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SOURCE");
            }
            // validating callback_url
            else if (requestParams.ContainsKey(Constants.CALLBACK_URL)
                    && requestParams[Constants.CALLBACK_URL].ToString().Length > Constants.CALLBACK_URL_MAXLEN)
            {
                throw new System.ArgumentException("INVALID CALLBACK_URL");
            }
            // validating billing_name
            else if (requestParams.ContainsKey(Constants.BILLING_NAME)
                    && requestParams[Constants.BILLING_NAME].ToString().Length > Constants.BILLING_NAME_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING_NAME");
            }
            // validating billing_address
            else if (requestParams.ContainsKey(Constants.BILLING_ADDRESS)
                    && requestParams[Constants.BILLING_ADDRESS].ToString().Length > Constants.BILLING_ADDRESS_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING_ADDRESS");
            }

             // validating billing_city
            else if (requestParams.ContainsKey(Constants.BILLING_CITY)
                    && requestParams[Constants.BILLING_CITY].ToString().Length > Constants.BILLING_CITY_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING CITY");
            }
            // validating billing_state
            else if (requestParams.ContainsKey(Constants.BILLING_STATE)
                    && requestParams[Constants.BILLING_STATE].ToString().Length > Constants.BILLING_STATE_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING STATE");
            }
            // validating billing_zip
            else if (requestParams.ContainsKey(Constants.BILLING_ZIP)
                    && requestParams[Constants.BILLING_ZIP].ToString().Length > Constants.BILLING_ZIP_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING_ZIP");
            }
            // validating billing_country
            else if (requestParams.ContainsKey(Constants.BILLING_COUNTRY)
                    && requestParams[Constants.BILLING_COUNTRY].ToString().Length > Constants.BILLING_COUNTRY_MAXLEN)
            {
                throw new System.ArgumentException("INVALID BILLING_COUNTRY");
            }
            // validating min_sla
            else if (requestParams.ContainsKey(Constants.MIN_SLA)
                    && (requestParams[Constants.MIN_SLA].ToString().Length > Constants.MIN_SLA_MAXLEN ||
                IsNumbers(requestParams[Constants.MIN_SLA].ToString())))
            {
                throw new System.ArgumentException("INVALID MIN_SLA");
            }
            // validating is_user_logged_in
            else if (requestParams.ContainsKey(Constants.IS_USER_LOGGED_IN)
                    && !(requestParams[Constants.IS_USER_LOGGED_IN].ToString().Equals("true", StringComparison.InvariantCultureIgnoreCase) ||
                requestParams[Constants.IS_USER_LOGGED_IN].ToString().Equals("false", StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new System.ArgumentException("INVALID IS_USER_LOGGED_IN");
            }

            // validating address_count
            else if (requestParams.ContainsKey(Constants.ADDRESS_COUNT)
                    && (requestParams[Constants.ADDRESS_COUNT].ToString().Length > Constants.ADDRESS_COUNT_MAXLEN ||
                            IsNumbers(requestParams[Constants.ADDRESS_COUNT].ToString())))
            {
                throw new System.ArgumentException("INVALID ADDRESS_COUNT");
            }

            // validating sales_channel
            else if (requestParams.ContainsKey(Constants.SALES_CHANNEL)
                    && requestParams[Constants.SALES_CHANNEL].ToString().Length > Constants.SALES_CHANNEL_MAXLEN)
            {
                throw new System.ArgumentException("INVALID SALES_CHANNEL");
            }

            // validating item_total
            else if (requestParams.ContainsKey(Constants.ITEM_TOTAL)
                    && requestParams[Constants.ITEM_TOTAL].ToString().Length > Constants.ITEM_TOTAL_MAXLEN)
            {
                throw new System.ArgumentException("INVALID ITEM_TOTAL");
            }

            // validating item_vertical
            else if (requestParams.ContainsKey(Constants.ITEM_VERTICAL)
                    && requestParams[Constants.ITEM_VERTICAL].ToString().Length > Constants.ITEM_VERTICAL_MAXLEN)
            {
                throw new System.ArgumentException("INVALID ITEM_VERTICAL");
            }

            // validating min_sla
            else if (requestParams.ContainsKey(Constants.MIN_SLA)
                    && (requestParams[Constants.MIN_SLA].ToString().Length > Constants.MIN_SLA_MAXLEN ||
                            IsNumbers(requestParams[Constants.MIN_SLA].ToString())))
            {
                throw new System.ArgumentException("INVALID MIN_SLA");
            }


            // validating udf1
            else if (requestParams.ContainsKey(Constants.UDF1)
                    && requestParams[Constants.UDF1].ToString().Length > Constants.UDF1_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF1");
            }

            // validating udf2
            else if (requestParams.ContainsKey(Constants.UDF2)
                    && requestParams[Constants.UDF2].ToString().Length > Constants.UDF2_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF2");
            }

            // validating udf3
            else if (requestParams.ContainsKey(Constants.UDF3)
                    && requestParams[Constants.UDF3].ToString().Length > Constants.UDF3_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF3");
            }

            // validating udf4
            else if (requestParams.ContainsKey(Constants.UDF4)
                    && requestParams[Constants.UDF4].ToString().Length > Constants.UDF4_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF4");
            }

            // validating udf5
            else if (requestParams.ContainsKey(Constants.UDF5)
                    && requestParams[Constants.UDF5].ToString().Length > Constants.UDF5_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF5");
            }

            return true;

        }

        public static bool ValidateRefundParams(Dictionary<string, object> refundParams){

            // Mandatory Parameters

		// Validating merchant id
            if (String.IsNullOrEmpty(refundParams[Constants.MERCHANT_ID].ToString())
                    || refundParams[Constants.MERCHANT_ID].ToString().Length > Constants.MERCHANT_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT ID");
            }
		// Validating merchant key id
            else if (String.IsNullOrEmpty(refundParams[Constants.MERCHANT_KEY_ID].ToString())
                    || refundParams[Constants.MERCHANT_KEY_ID].ToString().Length > Constants.MERCHANT_KEY_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT KEY ID");
            }
		// Validating payzippy_sale_transaction_id
            else if (!refundParams.ContainsKey(Constants.MERCHANT_TRANSACTION_ID) && (String.IsNullOrEmpty(refundParams[Constants.PAYZIPPY_SALE_TRANSACTION_ID].ToString())
                    || refundParams[Constants.PAYZIPPY_SALE_TRANSACTION_ID].ToString().Length > Constants.PAYZIPPY_SALE_TRANSACTION_ID_MAXLEN))
            {
                throw new System.ArgumentException("INVALID PAYZIPPY TRANSACTION ID");
            }
		
		// Validating merchant_transaction_id
            else if (!refundParams.ContainsKey(Constants.PAYZIPPY_SALE_TRANSACTION_ID) && (String.IsNullOrEmpty(refundParams[Constants.MERCHANT_TRANSACTION_ID].ToString())
                    || refundParams[Constants.MERCHANT_TRANSACTION_ID].ToString().Length > Constants.MERCHANT_TRANSACTION_ID_MAXLEN))
            {
                throw new System.ArgumentException("INVALID MERCHANT TRANSACTION ID");
            }
		// Validating refund amount
            else if (String.IsNullOrEmpty(refundParams[Constants.REFUND_AMOUNT].ToString())
                || IsNumbers(refundParams[Constants.REFUND_AMOUNT].ToString()))
		{
            throw new System.ArgumentException("INVALID REFUND_AMOUNT");
		}

		// Validating hash method
            else if (String.IsNullOrEmpty(refundParams[Constants.HASH_METHOD].ToString())
                    || !Constants.hashMethodRequirements.Contains(refundParams[Constants.HASH_METHOD].ToString()))
            {
                throw new System.ArgumentException("INVALID HASH METHOD, MD5 and SHA256 only (must be in uppercase)");
            }
		// Optional Parameters

		// validating refund_reason
            else if (refundParams.ContainsKey(Constants.REFUND_REASON)
                && refundParams[Constants.REFUND_REASON].ToString().Length > Constants.REFUND_REASON_MAXLEN)
		{
            throw new System.ArgumentException("INVALID REFUND_REASON");
		}
		// validating refunded_by
            else if (refundParams.ContainsKey(Constants.REFUNDED_BY)
            && refundParams[Constants.REFUNDED_BY].ToString().Length > Constants.REFUNDED_BY_MAXLEN)
		{
            throw new System.ArgumentException("INVALID REFUNDED_BY");
		}
		

		// validating udf1
            else if (refundParams.ContainsKey(Constants.UDF1)
                    && refundParams[Constants.UDF1].ToString().Length > Constants.UDF1_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF1");
            }

            // validating udf2
            else if (refundParams.ContainsKey(Constants.UDF2)
                    && refundParams[Constants.UDF2].ToString().Length > Constants.UDF2_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF2");
            }

            // validating udf3
            else if (refundParams.ContainsKey(Constants.UDF3)
                    && refundParams[Constants.UDF3].ToString().Length > Constants.UDF3_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF3");
            }

            // validating udf4
            else if (refundParams.ContainsKey(Constants.UDF4)
                    && refundParams[Constants.UDF4].ToString().Length > Constants.UDF4_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF4");
            }

            // validating udf5
            else if (refundParams.ContainsKey(Constants.UDF5)
                    && refundParams[Constants.UDF5].ToString().Length > Constants.UDF5_MAXLEN)
            {
                throw new System.ArgumentException("INVALID UDF5");
            }

            return true;
        }

        public static bool ValidateQueryParams(Dictionary<string, object> queryParams){

            // Validating merchant id
            if (String.IsNullOrEmpty(queryParams[Constants.MERCHANT_ID].ToString())
                    || queryParams[Constants.MERCHANT_ID].ToString().Length > Constants.MERCHANT_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT ID");
            }
		// Validating merchant key id
            else if (String.IsNullOrEmpty(queryParams[Constants.MERCHANT_KEY_ID].ToString())
                    || queryParams[Constants.MERCHANT_KEY_ID].ToString().Length > Constants.MERCHANT_KEY_ID_MAXLEN)
            {
                throw new System.ArgumentException("INVALID MERCHANT KEY ID");
            }
		// Validating payzippy_transaction_id
            else if (!queryParams.ContainsKey(Constants.MERCHANT_TRANSACTION_ID) && (String.IsNullOrEmpty(queryParams[Constants.PAYZIPPY_TRANSACTION_ID].ToString())
                   || (queryParams[Constants.PAYZIPPY_TRANSACTION_ID].ToString().Length > Constants.PAYZIPPY_TRANSACTION_ID_MAXLEN)))
            {
                throw new System.ArgumentException("INVALID PAYZIPPY TRANSACTION ID");
            }
		
		// Validating merchant_transaction_id
            else if (!queryParams.ContainsKey(Constants.PAYZIPPY_TRANSACTION_ID) && (String.IsNullOrEmpty(queryParams[Constants.MERCHANT_TRANSACTION_ID].ToString())
                    || queryParams[Constants.MERCHANT_TRANSACTION_ID].ToString().Length > Constants.MERCHANT_TRANSACTION_ID_MAXLEN))
            {
                throw new System.ArgumentException("INVALID MERCHANT TRANSACTION ID");
            }

		// Validating hash method
            else if (String.IsNullOrEmpty(queryParams[Constants.HASH_METHOD].ToString())
                    || !Constants.hashMethodRequirements.Contains(queryParams[Constants.HASH_METHOD].ToString()))
            {
                throw new System.ArgumentException("INVALID HASH METHOD, MD5 and SHA256 only (must be in uppercase)");
            }
		// Optional
		// Validating transaction type
            else if (queryParams.ContainsKey(Constants.TRANSACTION_TYPE)
                && (String.IsNullOrEmpty(queryParams[Constants.TRANSACTION_TYPE].ToString()) || !Constants.transactionTypeCheck.Contains(queryParams[Constants.TRANSACTION_TYPE].ToString())))
		{
            throw new System.ArgumentException("INVALID TRANSACTION_TYPE");
		}
		return true;

        }
        
    }
}
