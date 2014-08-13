This is the DOTNET SDK for PayZippy Merchant API.

Setup Instructions
==================

1. Clone the repository to get dot-net-sdk folder having example and payzippy_sdk folders. 

2. To use the sample code, copy the payzippy files & directories to a directory of your choice in Visual Studio and change the namespace of all the files according to your project.

3. Open dot-net-sdk/example/Config.cs file and set up your config details such as Merchant ID, Secret Key, Callback URL. The examples won't work without setting up the config details. You can also set the UI mode to redirect or iframe (details in point 6).

4. Download Json.Net and Add reference of Newtonsoft.Json.dll for handling the json response.

5. For the examples included, the callback url should point to the ChargingResp.aspx file under example folder. So, if you access your site locally as http://localhost:<port number>/, then callback url http://localhost:<port number>/dot-net-sdk/example/ChargingResp.aspx

6. There is an ChargingExample.aspx included for using the Charging API. This example includes the all parameters that can be sent in the Charging Request (Set this file as Start Page).

7. Further documentation on creating a charging request, parsing the response are included in the corresponding code files.


```
Sample code snippet to create a charging request object is shown below:

//include the charging payzippy_sdk( same as code example in ChargingExample.aspx.cs)
using Payzippy_DOTNET_SDK.payzippy_sdk;


//Set all the parameters that you want to send in the chargingrequest object.
//You can also overwrite the default parameters set in the Config.cs file.
ChargingRequestBuilder chargingBuilder = ChargingRequest.GetBuilder();
chargingBuilder.SetMerchantId(Config.MERCHANT_ID);
chargingBuilder.SetCallBackUrl(Config.CALLBACK_URL);
chargingBuilder.SetMerchantKeyId(Config.MERCHANT_KEY_ID);
chargingBuilder.SetBuyerEmailId(buyer_email_address.Value);
chargingBuilder.SetMerchantTransactionId(merchant_transaction_id.Value);
chargingBuilder.SetTransactionType(transaction_type.Value);
chargingBuilder.SetTransactionAmount(transaction_amount.Value);
chargingBuilder.SetPaymentMethod(payment_method.Value);
chargingBuilder.SetBankName(bank_name.Value);
chargingBuilder.SetCurrency(string currency);
chargingBuilder.SetUiMode(string uiMode); // REDIRECT or IFRAME
chargingBuilder.SetHashMethod(string hashMethod); // MD5 or SHA256
chargingBuilder.SetBuyerPhoneNo(string buyerPhoneNo);
chargingBuilder.SetItemTotal(string itemTotal);
chargingBuilder.SetItemVertical(string itemVertical);

//call build method which returns ChargingRequest object by passing the secret key

ChargingRequest chargingRequest = chargingBuilder.Build(Config.SECRET_KEY);

//get the url here

string url = chargingRequest.GetUrl(<pass the charging API url>);

if ui_mode id REDIRECT, then
Response.Redirect(url);

else if ui_mode is IFRAME
//include the url in the iframe src like the example below

<iframe src="<%=url%>" height="600" width="50%">
</iframe>

```
Further documentation on creating a charging request, parsing the response are included in the corresponding code files
