<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestPage.aspx.cs" Inherits="CMSDesk_TestPage" %>

<%@ Register Src="~/CMSWebParts/Forms/BookingFeeWebpart.ascx" TagPrefix="uc1" TagName="BookingFeeWebpart" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:BookingFeeWebpart runat="server" ID="BookingFeeWebpart" />
    </div>
    </form>
</body>
</html>
