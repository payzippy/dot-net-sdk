<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChargeIframe.aspx.cs" Inherits="PayzippyDotNetSDK.ChargeIframe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <center>
	<h2>Integration With IFrame</h2>
	<iframe
		src="<%=chargingUrl %>"
		frameborder="1" height="600" width="50%" ></iframe>
	</center>
</body>
</html>
