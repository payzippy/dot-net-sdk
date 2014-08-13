using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    class QueryResponse
    {
        private Dictionary<string, object> responseParams;

    public class TransactionResponse
	 {
        private Dictionary<string, object> dataParams;

		public TransactionResponse(Dictionary<string, object> dataParams)
		{
			this.dataParams = dataParams;
		}

		public Dictionary<string, object> GetTransactionResponseParams()
		{
			return dataParams;
		}

		public string GetTransactionStatus()
		{
			return Convert.ToString(dataParams[Constants.TRANSACTION_STATUS]);
		}

        public string GetTransactionResponseCode()
		{
            return Convert.ToString(dataParams[Constants.TRANSACTION_RESPONSE_CODE]);
		}

        public string GetFraudAction()
		{
            return Convert.ToString(dataParams[Constants.FRAUD_ACTION]);
		}

        public string GetFraudDetails()
		{
            return Convert.ToString(dataParams[Constants.FRAUD_DETAILS]);
		}

		public int GetTransactionAmount()
		{
			return Convert.ToInt32(Convert.ToString(dataParams[Constants.TRANSACTION_AMOUNT]));
		}

        public string GetMerchantTransactionId()
		{
            return Convert.ToString(dataParams[Constants.MERCHANT_TRANSACTION_ID]);
		}

        public string GetPayzippyTransactionId()
		{
            return Convert.ToString(dataParams[Constants.PAYZIPPY_TRANSACTION_ID]);
		}

        public string GetBankArn()
		{
            return Convert.ToString(dataParams[Constants.BANK_ARN]);
		}

        public string GetPaymentMethod()
		{
            return Convert.ToString(dataParams[Constants.PAYMENT_METHOD]);
		}

        public string GetTransactionTime()
		{
            return Convert.ToString(dataParams[Constants.TRANSACTION_TIME]);
		}

        public string GetTransactionCurrency()
		{
            return Convert.ToString(dataParams[Constants.TRANSACTION_CURRENCY]);
		}

		public string GetTransactionType()
		{
            return Convert.ToString(dataParams[Constants.TRANSACTION_TYPE]);
		}

		public int GetEmiMonths()
		{
			return Convert.ToInt32(Convert.ToString(dataParams[Constants.EMI_MONTHS]));
		}

		public string GetTransactionResponseMessage()
		{
            return Convert.ToString(dataParams[Constants.TRANSACTION_RESPONSE_MESSAGE]);

		}

	}

      private List<TransactionResponse> transactionResponse = new List<TransactionResponse>();

        public QueryResponse(Dictionary<string, object> responseParams)
	    {
		    this.responseParams = responseParams;
            List<Dictionary<string, object>> dataParams = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonConvert.SerializeObject(responseParams[Constants.DATA]));
            foreach (Dictionary<string, object> dataParam in dataParams)
		     {
			     transactionResponse.Add(new TransactionResponse(dataParam));
		     }
	    }

	 public QueryResponse(string jsonString)
	 {
		this.responseParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(jsonString));
		 List<Dictionary<string, object>> dataParams = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonConvert.SerializeObject(responseParams[Constants.DATA]));
         foreach (Dictionary<string, object> dataParam in dataParams)
		{
            transactionResponse.Add(new TransactionResponse(dataParam));
		}
	 }

    public List<TransactionResponse> GetTransactionResponse()
    {
        return this.transactionResponse;
    }

    public Dictionary<string, object> GetResponseParams()
    {
        return responseParams;
    }

   
    public int GetStatusCode()
    {
        return Convert.ToInt32(Convert.ToString(responseParams[Constants.STATUS_CODE]));
    }

    public String GetStatusMessage()
    {
        return Convert.ToString(responseParams[Constants.STATUS_MESSAGE]);
    }
    

        public Dictionary<string, object> GenerateHashParams(Dictionary<string, object> responseParams)
	      {
           Dictionary<string, object> hashParams = new Dictionary<string, object>();
		      foreach (string key in responseParams.Keys)
		        {
			       if (key.Equals("data"))
			          {
                       List<Dictionary<string, object>> dataParams = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonConvert.SerializeObject(responseParams[key]));
				         
				         if (dataParams.Count > 0)
				           {
					         for (int i = 0; i < dataParams.Count; i++)
					             {
						            foreach (string dKey in dataParams[i].Keys)
						               {
                                           if (("True").Equals(Convert.ToString(dataParams[i][dKey])) || ("False").Equals(Convert.ToString(dataParams[i][dKey])))
                                           {
                                               hashParams.Add("data[" + i.ToString() + "]." + dKey,
                                            Convert.ToString(dataParams[i][dKey]).ToLower());
                                           }
                                           else
                                           {
                                               hashParams.Add("data[" + i.ToString() + "]." + dKey,
                                                Convert.ToString(dataParams[i][dKey]));
                                           }
                                           
						               }
					              }
				            }				         
			          }
			          else
			           {
				        hashParams.Add(key, Convert.ToString(responseParams[key]));
			           }
		         }
		return hashParams;
    
	}
   
    public bool IsValidResponse(string secretKey)
    {
        if (GetStatusCode() == 200)
        {
            return responseParams[Constants.HASH].Equals(
                     HashUtils.GenerateHash(GenerateHashParams(responseParams), secretKey,
                            responseParams[Constants.HASH_METHOD].ToString()));
        }
        else
        {
            return false;
        }
    }

    public string GetHashMethod()
    {
        return Convert.ToString(responseParams[Constants.HASH_METHOD]);
    }

    public string GetHash()
    {
        return Convert.ToString(responseParams[Constants.HASH]);
    }

    public string GetMerchnatId()
    {
        return Convert.ToString(responseParams[Constants.MERCHANT_ID]);
    }

    public string GetMerchnatKeyId()
    {
        return Convert.ToString(responseParams[Constants.MERCHANT_KEY_ID]);
    }

    public string GetErrorCode()
    {
        return Convert.ToString(responseParams[Constants.ERROR_CODE]);
    }

    public string GetErrorMessage()
    {

        if (responseParams.ContainsKey(Constants.ERROR_MESSAGE))
            return Convert.ToString(responseParams[Constants.ERROR_MESSAGE]);
        else
            return "";
    }

   }
}


