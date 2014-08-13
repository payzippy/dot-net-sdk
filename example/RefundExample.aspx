<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RefundExample.aspx.cs" Inherits="PayzippyDotNetSDK.RefundExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<title>Payzippy REFUND API</title>
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
    <legend>Payzippy REFUND</legend>
    <!-- Text input-->
    <div class="control-group">
                <label class="control-label">Merchant Transaction Id</label>
                <div class="controls">
                    <input id="merchant_transaction_id" name="merchant_transaction_id" type="text" placeholder="Merchant Transaction Id" class="input-xlarge" runat="server" />
                </div>
            </div>

    <!-- Text input-->
    <div class="control-group">
                <label class="control-label">Payzippy Sale Transaction Id</label>
                <div class="controls">
                    <input id="payzippy_sale_transaction_id" name="payzippy_sale_transaction_id" type="text" placeholder="Payzippy Transaction Id" class="input-xlarge"  runat="server" />
                </div>
            </div>
    
    <!-- Text input-->
   <div class="control-group">
                <label class="control-label required">Refund Amount (in Paisa)</label>
                <div class="controls">
                    <input id="refund_amount" name="refund_amount" type="text" placeholder="Refund Amount" class="input-xlarge" required="" runat="server" />
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
            
    <!-- Text input-->
     <div class="control-group">
                <label class="control-label">Refund Reason</label>
                <div class="controls">
                    <input id="refund_reason" name="refund_reason" type="text" value = "Refund Reason" class="input-xlarge" runat="server" />
                </div>
            </div>
            
             <!-- Text input-->
            <div class="control-group">
                <label class="control-label">Refunded By</label>
                <div class="controls">
                    <input id="refunded_by" name="refunded_by" type="text" value = "user@domain.com" class="input-xlarge" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="control-group">
                <label class="control-label">UDF 1</label>
                <div class="controls">
                    <input id="udf1" name="udf1" type="text" value="UDF1" class="input-xlarge" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="control-group">
                <label class="control-label">UDF 2</label>
                <div class="controls">
                    <input id="udf2" name="udf2" type="text" value="UDF2" class="input-xlarge" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="control-group">
                <label class="control-label">UDF 3</label>
                <div class="controls">
                    <input id="udf3" name="udf3" type="text" value="UDF3" class="input-xlarge" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="control-group">
                <label class="control-label">UDF 4</label>
                <div class="controls">
                    <input id="udf4" name="udf4" type="text" value="UDF4" class="input-xlarge" runat="server" />
                </div>
            </div>

            <!-- Text input-->
            <div class="control-group">
                <label class="control-label">UDF 5</label>
                <div class="controls">
                    <input id="udf5" name="udf5" type="text" value="UDF5" class="input-xlarge" runat="server" />
                </div>
            </div>


</div>
    <div class="control-group span12">
    <input type="submit" id="button" class="btn btn-info" runat="server" value="Issue Refund" OnServerClick = "Refund_OnClick" />
</div>
 </fieldset>
    </form>

</body>
</html>
