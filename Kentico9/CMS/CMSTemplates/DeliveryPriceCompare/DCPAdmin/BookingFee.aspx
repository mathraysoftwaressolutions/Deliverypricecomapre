<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/DeliveryPriceCompare/DCPAdmin/DCPAdminMaster.master" AutoEventWireup="true" CodeFile="BookingFee.aspx.cs" Inherits="CMSTemplates_DeliveryPriceCompare_BookingFee" %>

<%@ Register Src="~/CMSWebParts/Forms/BookingFeeWebpart.ascx" TagPrefix="uc1" TagName="BookingFeeWebpart" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%-- <asp:WebPartManager ID="WebPartManager1" runat="server"></asp:WebPartManager>
    <asp:WebPartZone ID="WebPartZone1" runat="server">
    </asp:WebPartZone>--%>
    <div style="clear:both;">

    <uc1:BookingFeeWebpart runat="server" ID="BookingFeeWebpart" /></div>
</asp:Content>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>--%>