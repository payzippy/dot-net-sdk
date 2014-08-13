using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
   public class ChargingResponse
    {
       private  Dictionary<string, object> responseParams;

    public ChargingResponse(Dictionary<string, object> responseParams)
	 {
		this.responseParams = responseParams;
	 }

    public Dictionary<string, object> GetResponseParams()
	{
		return responseParams;
	}
	
	public bool IsValidResponse(string secretKey)
	{
		return responseParams[Constants.HASH].Equals(
                HashUtils.GenerateHash(responseParams, secretKey,Convert.ToString(responseParams[Constants.HASH_METHOD])));
	}

	public bool IsFraud()
	{
		return !("Accept".Equals(Convert.ToString(responseParams[Constants.FRAUD_ACTION]), StringComparison.InvariantCultureIgnoreCase));
	}
       
	public bool IsSuccess()
	 {
        return "SUCCESS".Equals(Convert.ToString(responseParams[Constants.TRANSACTION_STATUS]), StringComparison.InvariantCultureIgnoreCase);        
	 }

	public string GetPayzippyTransactionId()
	{
		return  Convert.ToString(responseParams[Constants.PAYZIPPY_TRANSACTION_ID]);
	}

	public string GetMerchantTransactionId()
	{
        return Convert.ToString(responseParams[Constants.MERCHANT_TRANSACTION_ID]);
	}

	public string GetTransactionStatus()
	{
        return Convert.ToString(responseParams[Constants.TRANSACTION_STATUS]);	
	}

	public string GetTransactionResponseMessage()
	{
        return Convert.ToString(responseParams[Constants.TRANSACTION_RESPONSE_MESSAGE]);
	}
	public string GetTransactionResponseCode()
    {
        return Convert.ToString(responseParams[Constants.TRANSACTION_RESPONSE_CODE]);
	}

	public string GetFraudAction()
	{
        return Convert.ToString(responseParams[Constants.FRAUD_ACTION]);
	}

	public string GetFraudDetails()
	{
        return Convert.ToString(responseParams[Constants.FRAUD_DETAILS]);
	}
	public int GetTransactionAmount()
    {
        return Convert.ToInt32(Convert.ToString(responseParams[Constants.TRANSACTION_AMOUNT]));
	}
	public string GetPaymentMethod()
    {
        return Convert.ToString(responseParams[Constants.PAYMENT_METHOD]);
	}
	public string GetBankName()
    {
        return Convert.ToString(responseParams[Constants.BANK_NAME]);
	}
	public int GetEmiMonths()
    {
        return Convert.ToInt32( Convert.ToString(responseParams[Constants.EMI_MONTHS]));
	}
	public string GetTransactionCurrency()
    {
        return Convert.ToString(responseParams[Constants.TRANSACTION_CURRENCY]);
	}
	public string GetTransactionTime()
    {
        return Convert.ToString(responseParams[Constants.TRANSACTION_TIME]);
	}
    public string GetUdf1()
    {
        return Convert.ToString(responseParams[Constants.UDF1]);
    }
    public string GetUdf2()
    {
        return Convert.ToString(responseParams[Constants.UDF2]);
    }
    public string GetUdf3()
    {
        return Convert.ToString(responseParams[Constants.UDF3]);
    }
    public string GetUdf4()
    {
        return Convert.ToString(responseParams[Constants.UDF4]);
    }
    public string GetUdf5()
    {
        return Convert.ToString(responseParams[Constants.UDF5]);
	}
	public string GetHashMethod(){
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
	public bool IsInternational()
    {

     return   "true".Equals(Convert.ToString(responseParams[Constants.IS_INTERNATIONAL]), StringComparison.InvariantCultureIgnoreCase);
	}
	public string GetVersion()
    {
        return Convert.ToString(responseParams[Constants.VERSION]);
	}
    }
}
