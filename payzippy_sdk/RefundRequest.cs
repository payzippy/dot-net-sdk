using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public class RefundRequest
    {

     private Dictionary<string, object> requestParams;

	public RefundRequest(Dictionary<string, object> requestParams)
	{
		this.requestParams = requestParams;
	}

	public  class Builder : RefundRequestBuilder
	{
		private Dictionary<string, object> requestParams = new Dictionary<string, object>();

		public RefundRequestBuilder SetMerchantKeyId(string merchantKeyId)
		{
			requestParams.Add(Constants.MERCHANT_KEY_ID, merchantKeyId);
			return this;

		}

		public RefundRequestBuilder SetHashMethod(string hashMethod)
		{
            requestParams.Add(Constants.HASH_METHOD, hashMethod.ToUpper());
			return this;

		}

		public RefundRequestBuilder SetPayzippySaleTransactionId(string payzippySaleTransactionId)
		{
			requestParams.Add(Constants.PAYZIPPY_SALE_TRANSACTION_ID, payzippySaleTransactionId);
			return this;

		}

		public RefundRequestBuilder SetMerchantId(string merchantId)
		{
			requestParams.Add(Constants.MERCHANT_ID, merchantId);
			return this;

		}

		public RefundRequestBuilder SetMerchantTransactionId(string merchantTransactionId)
		{
			requestParams.Add(Constants.MERCHANT_TRANSACTION_ID, merchantTransactionId);
			return this;

		}

		public RefundRequestBuilder SetRefundAmount(string refundAmount)
		{
			requestParams.Add(Constants.REFUND_AMOUNT, refundAmount);
			return this;

		}
        public RefundRequestBuilder SetRefundReason(string refundReason)
        {
            string replacedValue = ReplaceSpecialCharacters(refundReason);
            requestParams.Add(Constants.REFUND_REASON, replacedValue);
            return this;
        }

        public RefundRequestBuilder SetRefundedBy(string refundedBy)
        {
            string replacedValue = ReplaceSpecialCharacters(refundedBy);
            requestParams.Add(Constants.REFUNDED_BY, replacedValue);
            return this;
        }



        public RefundRequestBuilder SetTimeGmt(string timeGmt)
        {
            requestParams.Add(Constants.TIMEGMT, timeGmt);
            return this;
        }

        public RefundRequestBuilder SetUdf1(string udf1)
        {
            string replacedValue = ReplaceSpecialCharacters(udf1);
            requestParams.Add(Constants.UDF1, replacedValue);
            return this;
        }
        public RefundRequestBuilder SetUdf2(string udf2)
        {
            string replacedValue = ReplaceSpecialCharacters(udf2);
            requestParams.Add(Constants.UDF2, replacedValue);
            return this;
        }
        public RefundRequestBuilder SetUdf3(string udf3)
        {
            string replacedValue = ReplaceSpecialCharacters(udf3);
            requestParams.Add(Constants.UDF3, replacedValue);
            return this;
        }
        public RefundRequestBuilder SetUdf4(string udf4)
        {
            string replacedValue = ReplaceSpecialCharacters(udf4);
            requestParams.Add(Constants.UDF4, replacedValue);
            return this;
        }
        public RefundRequestBuilder SetUdf5(string udf5)
        {
            string replacedValue = ReplaceSpecialCharacters(udf5);
            requestParams.Add(Constants.UDF5, replacedValue);
            return this;
        }

        private string ReplaceSpecialCharacters(string valueOld)
        {
            Regex regexObject = new Regex(@"[^A-Za-z0-9 \\\._#!@$|;{},?^*':()+[\]=-]", RegexOptions.IgnoreCase);
            return regexObject.Replace(Convert.ToString(valueOld), " ");
        }
		public RefundRequest Build(string secretKey)
		{
            ValidityCheck.ValidateRefundParams(this.requestParams);

			if (!requestParams.ContainsKey(Constants.HASH))
			{
				requestParams.Add(Constants.HASH, HashUtils.GenerateHash(requestParams, secretKey,
				        this.requestParams[Constants.HASH_METHOD].ToString()));
			}
			
			return new RefundRequest(this.requestParams);

		}

	}
       public static RefundRequestBuilder GetBuilder()
	    {
		return new Builder();
	    }
        
        public Dictionary<string, object> GetRequestParams()
	{
		return requestParams;
	}

	

	public string GetMerchantKeyId()
	{
		return requestParams[Constants.MERCHANT_KEY_ID].ToString();
	}

	public string GetMerchantId()
	{
		return requestParams[Constants.MERCHANT_ID].ToString();
	}

	public string GetHashMethod()
	{
		return requestParams[Constants.HASH_METHOD].ToString();
	}

	public string GetHash()
	{
		return requestParams[Constants.HASH].ToString();
	}

	public string GetMerchantTransactionId()
	{
		return requestParams[Constants.MERCHANT_TRANSACTION_ID].ToString();
	}

    public string getPayzippySaleTransactionId()
	{
		return requestParams[Constants.PAYZIPPY_SALE_TRANSACTION_ID].ToString();
	}

    public string GetRefundAmount()
	{
		return  requestParams[Constants.REFUND_AMOUNT].ToString();
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
    public string GetRefundReason()
    {
        return requestParams[Constants.REFUND_REASON].ToString();
    }
    public string GetRefundedBy()
    {
        return requestParams[Constants.REFUNDED_BY].ToString();
    }

    public string GetUrl(string BaseUrl)
	{
		return RequestUtil.GetUrl(requestParams, BaseUrl);
	}
	
    }
}
