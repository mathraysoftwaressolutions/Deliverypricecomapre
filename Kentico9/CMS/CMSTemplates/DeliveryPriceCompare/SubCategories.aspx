<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/DeliveryPriceCompare/DPCAdmin.master" AutoEventWireup="true" CodeFile="SubCategories.aspx.cs" Inherits="CMSTemplates_DeliveryPriceCompare_SubCategories" %>

<%@ Register Src="~/CMSWebParts/Forms/ServiceSubCategory.ascx" TagPrefix="uc1" TagName="ServiceSubCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plcMain" Runat="Server">
    <div style="clear:both;">
        <uc1:ServiceSubCategory runat="server" ID="ServiceSubCategory" />
    </div>
</asp:Content>

