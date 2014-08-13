<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryExample.aspx.cs" Inherits="PayzippyDotNetSDK.QueryExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Payzippy Query API</title>
<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
<style>
select,textarea,input[type="text"],input[type="password"],input[type="datetime"],input[type="datetime-local"],input[type="date"],input[type="month"],input[type="time"],input[type="week"],input[type="number"],input[type="email"],input[type="url"],input[type="search"],input[type="tel"],input[type="color"],.uneditable-input
	{
	height: 30px;
}
</style>
&emsp;&emsp;&emsp;&emsp;<a href="ChargingExample.aspx"><b>Charging Example Link</b></a>&emsp;&emsp;&emsp;&emsp;
<a href="QueryExample.aspx"><b>Query Example Link</b></a>&emsp;&emsp;&emsp;&emsp;
 <a href="RefundExample.aspx"><b>Refund Example Link</b></a>&emsp;&emsp;&emsp;&emsp;
<a href="https://www.payzippy.com/apidoc/"><b>API Doc Link</b></a>&emsp;&emsp;&emsp;&emsp;
<a href="https://www.payzippy.com/hashgeneration/"><b>Hash Demo Link</b></a>

</head>
<body>
<div class="container-fluid" />
	<div class="span12">
	<HR/>
	</div>
<div class="clearfix"></div>
     <form id="Form1" class="form-horizontal" method="post" runat="server">
<fieldset>
    <div class="well well-small span6">
    <legend>Payzippy Query</legend>
    <!-- Text input-->
    <div class="control-group">
                <label class="control-label">Payzippy Transaction Id</label>
                <div class="controls">
                    <input id="payzippy_transaction_id" name="payzippy_transaction_id" type="text" placeholder="Payzippy Transaction ID" class="input-xlarge"  runat="server" />
                </div>
            </div>

    <!-- Text input-->
    <div class="control-group">
                <label class="control-label">Merchant Transaction Id</label>
                <div class="controls">
                    <input id="merchant_transaction_id" name="merchant_transaction_id" type="text" placeholder="Merchant Transaction Id" class="input-xlarge" runat="server"/>
                </div>
            </div>

    <!-- Text input-->
   <div class="control-group">
                <label class="control-label">Merchant Key Id</label>
                <div class="controls">
                    <input id="merchant_key_id" name="merchant_key_id" type="text" value="payment" class="input-xlarge" required="" runat="server" />
                </div>
            </div>
    <!-- Text input-->
     <div class="control-group">
                <label class="control-label required">Hash Method</label>
                <div class="controls">
                    <input id="hash_method" name="hash_method" type="text" placeholder="Hash Method" value="SHA256" class="input-xlarge" required=""  runat="server"/>
                </div>
            </div>
</div>
    <div class="control-group span12">
    <input type="submit" id="button" class="btn btn-info" runat="server" value="Submit Query" OnServerClick = "Query_OnClick" />
</div>
 </fieldset>
    </form>

</body>
</html>
