using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayzippyDotNetSDK.payzippy_sdk
{
    
 public interface RefundRequestBuilder
   {
	 RefundRequestBuilder SetMerchantId(string merchantId);
	 RefundRequestBuilder SetMerchantKeyId(string merchantKeyId);
	 RefundRequestBuilder SetMerchantTransactionId(string merchantTransactionId);
	 RefundRequestBuilder SetPayzippySaleTransactionId(string payzippySaleTransactionId);
	 RefundRequestBuilder SetHashMethod(string hashMethod);
	 RefundRequestBuilder SetRefundAmount(string refundAmount);
      RefundRequestBuilder SetRefundReason(string refundReason);
      RefundRequestBuilder SetRefundedBy(string refundedBy);
      RefundRequestBuilder SetTimeGmt(string timeGmt);
      RefundRequestBuilder SetUdf1(string udf1);
      RefundRequestBuilder SetUdf2(string udf2);
      RefundRequestBuilder SetUdf3(string udf3);
      RefundRequestBuilder SetUdf4(string udf4);
      RefundRequestBuilder SetUdf5(string udf5);
      RefundRequest Build(string secretKey);

}
    
}
