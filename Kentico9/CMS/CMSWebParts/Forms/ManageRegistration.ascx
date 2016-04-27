<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageRegistration.ascx.cs" Inherits="CMSWebParts_Forms_ManageRegistration" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="BusinessName" HeaderText="BusinessName"></asp:BoundField>
                    <asp:BoundField DataField="Fristname" HeaderText="Fristname"></asp:BoundField>
                    <asp:BoundField DataField="country" HeaderText="country"></asp:BoundField>
                    <asp:BoundField DataField="Email" HeaderText="Email"></asp:BoundField>
                    <asp:CommandField HeaderText="Active" NewText="Active" SelectText="Active" ShowSelectButton="True"></asp:CommandField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>

