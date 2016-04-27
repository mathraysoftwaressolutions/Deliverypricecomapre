<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/DeliveryPriceCompare/DPCAdmin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CMSTemplates_DeliveryPriceCompare_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plcMain" Runat="Server">
    <!-- main content -->
        <table style="width:100%;height:500px;border: 0px">            
			<tr style="vertical-align:top;">
                <!-- left column -->
                <td style="width:280px" class="HomePageLeftColumn">                    
                </td>
                <!-- center column -->
                <td style="padding: 3px 5px 0px 5px;width:450px;">
                   <!-- center box -->
<table cellspacing="0" cellpadding="0" border="0" class="ContainerWithCorners" style="width: 100%;">
    <tr class="ContainerWithCornersRow">
        <td class="ContainerWithCornersTopLeft">&nbsp;</td>
        <td class="ContainerWithCornersTop">&nbsp;</td>
        <td class="ContainerWithCornersTopRight">&nbsp;</td>
    </tr>
    <tr>
        <td class="ContainerWithCornersLeft">&nbsp;</td>
        <td class="ContainerWithCornersContent" valign="top">
            <cms:CMSPagePlaceholder ID="plcZone" runat="server">
                <LayoutTemplate>
                    <cms:CMSWebPartZone ID="zoneMain" runat="server" />
                </LayoutTemplate>
            </cms:CMSPagePlaceholder>
        </td>
        <td class="ContainerWithCornersRight">&nbsp;</td>
    </tr>
    <tr class="ContainerWithCornersRow">
        <td class="ContainerWithCornersBottomLeft">&nbsp;</td>
        <td class="ContainerWithCornersBottom">&nbsp;</td>
        <td class="ContainerWithCornersBottomRight">&nbsp;</td>
    </tr>
</table>  
                </td>
                <!-- right column -->
                <td style="padding: 3px 0px 0px 5px;width:270px">
                    <!-- text box -->
                    <table cellpadding="0" cellspacing="0" style="width: 100%;margin-bottom: 10px;" class="Blue">
                        <tr>
                            <td class="BoxTitle">Contact us
                            </td>
                        </tr>
                        <tr>
                            <td class="BoxArea">
                            Our Business, Inc.<br />
                            127 One Business Way<br />
                            Los Angeles, CA<br />
                            &nbsp;<br />
                            phone: (800) 111 1111<br />
                            fax: (800) 111 1111                                                                                    
                            </td>
                        </tr>
                    </table>                  
                    
                    <cms:CMSEditableRegion ID="txtRight" runat="server" DialogHeight="280"  RegionTitle="Right Content" RegionType="HtmlEditor"/>
               
            </tr>
        </table>
<!-- /main content -->
</asp:Content>

