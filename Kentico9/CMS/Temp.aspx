<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Temp.aspx.cs" Inherits="Temp" %>

<%@ Register Src="~/CMSWebParts/Forms/ServiceCategory.ascx" TagPrefix="uc1" TagName="ServiceCategory" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:servicecategory runat="server" id="ServiceCategory1" />
    </div>
    </form>
</body>
</html>
