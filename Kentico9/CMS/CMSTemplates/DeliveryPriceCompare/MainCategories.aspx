m<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/DeliveryPriceCompare/DPCAdmin.master" AutoEventWireup="true" CodeFile="MainCategories.aspx.cs" Inherits="CMSTemplates_DeliveryPriceCompare_MainCategories" %>

<%@ Register Src="~/CMSWebParts/Forms/ServiceCategory.ascx" TagPrefix="uc1" TagName="ServiceCategory" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="clear:both;">
        <uc1:ServiceCategory runat="server" ID="ServiceCategory" />
    </div>
</asp:Content>


