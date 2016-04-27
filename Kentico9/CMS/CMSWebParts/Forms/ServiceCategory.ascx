<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_Forms_ServiceCategory"  CodeFile="~/CMSWebParts/Forms/ServiceCategory.ascx.cs" %>
<div>
    <asp:MultiView runat="server" ID="mvCategories">
        <asp:View runat="server" ID="Vgrid">
            <div align="right">
                <asp:LinkButton runat="server" ID="lnkbtnAdd" Text="Add Category" OnClick="lnkbtnAdd_Click"></asp:LinkButton>
            </div>
            <div align="center">
                <asp:GridView runat="server" ID="gvCategories" EmptyDataText="Categories Not Available." AutoGenerateColumns="false"
                     DataKeyNames="ItemID, Main_Category" OnRowCommand="gvCategories_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Category" >
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblcategoryId" Text='<%#Bind("ItemID") %>' Visible="false"></asp:Label>
                                <asp:Label runat="server" ID="lblCategory" Text='<%#Bind("Main_Category") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tools">
                            <ItemTemplate>
                               <asp:LinkButton runat="server" ID="lnkbtnDelete" Text="Delete" CommandArgument='<%#Container.DataItemIndex  %>'
                                    CommandName="Delete1"></asp:LinkButton>
                                <asp:LinkButton runat="server" ID="lnkbtnEdit" Text="Edit" CommandArgument='<%#Container.DataItemIndex  %>'
                                    CommandName="Edit1"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </asp:View>
        <asp:View runat="server" ID="vAdd">
            <div>
                <table>
                    <tr>
                        <td>Category Name</td><td>:</td><td><asp:TextBox runat="server" ID="txtCategoryname"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td><td></td><td><asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" /></td>
                    </tr>
                </table>
            </div>
        </asp:View>
    </asp:MultiView>
</div>