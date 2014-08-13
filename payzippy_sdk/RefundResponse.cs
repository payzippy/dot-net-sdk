using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayzippyDotNetSDK.payzippy_sdk
{
   public  class RefundResponse
    {
      private Dictionary<string, object> responseParams;
      private Dictionary<string, object> dataParams;

	public RefundResponse(Dictionary<string, object> responseParams)
	{
		this.responseParams = responseParams;
        this.dataParams =JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(responseParams[Constants.DATA]));
	}

	public RefundResponse(string jsonString) 
	{
		this.responseParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(jsonString));
        this.dataParams =JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(responseParams[Constants.DATA]));
	}

	public Dictionary<string, object> GetResponseParams()
	{
		return responseParams;
	}

    public Dictionary<string, object> GetDataParams()
	{
		return dataParams;
	}
	
    public int GetStatusCode()
    {
 	    return Convert.ToInt32(Convert.ToString(responseParams[Constants.STATUS_CODE]));
    }

	public string GetRefundStatus()
	{
		return Convert.ToString(dataParams[Constants.REFUND_STATUS]);
	}

	public bool IsSuccess()
	{
		return "SUCCESS".Equals(GetRefundStatus());
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

    public Dictionary<string, object> GenerateHashParams(Dictionary<string, object> responseParams)
	  {

          Dictionary<string, object> hashParams = new Dictionary<string, object>();
          foreach (string key in responseParams.Keys)
		{
			if (key.Equals("data"))
			{
				 Dictionary<string, object> dataParams = JsonConvert.DeserializeObject<Dictionary<string, object>>(Convert.ToString(responseParams[key]));
				if (dataParams.Count > 0)
				{
					foreach (string dKey in dataParams.Keys)
					{
                        hashParams.Add("data." + dKey, Convert.ToString(dataParams[dKey]));
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
		return Convert.ToString(responseParams[Constants.ERROR_MESSAGE]);
	}
   
    

	public string GetStatusMessage()
	{
		return Convert.ToString(responseParams[Constants.STATUS_MESSAGE]);
	}   
   
    
	public string GetRefundResponseMessasge()
	{
		return Convert.ToString(dataParams[Constants.REFUND_RESPONSE_MESSAGE]);
	}
	public string GetUdf1()
	{
		return Convert.ToString(dataParams[Constants.UDF1]);
	}

	public string GetUdf2()
	{
		return Convert.ToString(dataParams[Constants.UDF2]);
	}

	public string GetUdf3()
	{
		return Convert.ToString(dataParams[Constants.UDF3]);
	}

	public string GetUdf4()
	{
		return Convert.ToString(dataParams[Constants.UDF4]);
	}

	public string GetUdf5()
	{
		return Convert.ToString(dataParams[Constants.UDF5]);
	}

	
	public string GetMerchantTransactionId()
	{
		return Convert.ToString(dataParams[Constants.MERCHANT_TRANSACTION_ID]);
	}

	public string GetPayzippyTransactionId()
	{
		return Convert.ToString(dataParams[Constants.PAYZIPPY_TRANSACTION_ID]);
	}

	public int GetRefundAmount()
	{
		return Convert.ToInt32(Convert.ToString(dataParams[Constants.REFUND_AMOUNT]));
	}

	public string GetRefundResponseCode()
	{
		return Convert.ToString(dataParams[Constants.REFUND_RESPONSE_CODE]);
	}

	public string GetBankArn()
	{
		return Convert.ToString(dataParams[Constants.BANK_ARN]);
	}

	public string GetTransactionTime()
	{
		return Convert.ToString(dataParams[Constants.TRANSACTION_TIME]);
	}

	public string GetTerminalId()
	{
		return Convert.ToString(dataParams[Constants.TERMINAL_ID]);
	}

	public string GetCurrency()
	{
		return Convert.ToString(dataParams[Constants.CURRENCY]);
	}

    }
}
