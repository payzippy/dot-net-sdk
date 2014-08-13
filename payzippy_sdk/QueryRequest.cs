using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public class QueryRequest
    {
         private Dictionary<string, object> requestParams;

	public QueryRequest(Dictionary<string, object> requestParams)
	{
		this.requestParams = requestParams;
	}

	public  class Builder : QueryRequestBuilder
	{
		private Dictionary<string, object> requestParams = new Dictionary<string, object>();

		public QueryRequestBuilder SetMerchantKeyId(string merchantKeyId)
		{
			requestParams.Add(Constants.MERCHANT_KEY_ID, merchantKeyId);
			return this;

		}

		public QueryRequestBuilder SetMerchantId(string merchantId)
		{
			requestParams.Add(Constants.MERCHANT_ID, merchantId);
			return this;

		}

		public QueryRequestBuilder SetPayzippyTransactionId(string payzippyTransactionId)
		{
			requestParams.Add(Constants.PAYZIPPY_TRANSACTION_ID, payzippyTransactionId);
			return this;

		}


		public QueryRequestBuilder SetHashMethod(string hashMethod)
		{
            requestParams.Add(Constants.HASH_METHOD, hashMethod.ToUpper());
			return this;

		}

		public QueryRequestBuilder SetMerchantTransactionId(string merchantTransactionId)
		{
			requestParams.Add(Constants.MERCHANT_TRANSACTION_ID, merchantTransactionId);
			return this;

		}

        public QueryRequestBuilder SetTransactionType(string transactionType)
		{
            requestParams.Add(Constants.TRANSACTION_TYPE, transactionType);
            return this;
		}

		public QueryRequest Build(string secretKey) 
		{
            ValidityCheck.ValidateQueryParams(this.requestParams);

			if (!requestParams.ContainsKey(Constants.HASH))
			{
				requestParams.Add(Constants.HASH, HashUtils.GenerateHash(requestParams, secretKey,
				        this.requestParams[Constants.HASH_METHOD].ToString()));
			}
			
			return new QueryRequest(this.requestParams);
		}

	}

	public static QueryRequestBuilder GetBuilder()
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

	public string GetPayzippyTransactionId()
	{
		return requestParams[Constants.PAYZIPPY_TRANSACTION_ID].ToString();
	}

    public string GetTransactionType()
    {
        return requestParams[Constants.TRANSACTION_TYPE].ToString();
    }
	
	public string GetUrl(string baseUrl)
	{
		return RequestUtil.GetUrl(requestParams, baseUrl);
	}
	
    }
}
