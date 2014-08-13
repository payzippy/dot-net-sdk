using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    public interface QueryRequestBuilder
    {
     QueryRequestBuilder SetMerchantId(string merchantId);
	 QueryRequestBuilder SetMerchantKeyId(string merchantKeyId);
	 QueryRequestBuilder SetMerchantTransactionId(string merchantTransactionId);
	 QueryRequestBuilder SetPayzippyTransactionId(string payzippySaleTransactionId);
	 QueryRequestBuilder SetHashMethod(string hashMethod);
     QueryRequestBuilder SetTransactionType(string transactionType);
     QueryRequest Build(string secretKey);
    }
}
