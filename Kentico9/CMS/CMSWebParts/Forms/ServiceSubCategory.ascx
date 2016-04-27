<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_Forms_ServiceSubCategory"  CodeFile="~/CMSWebParts/Forms/ServiceSubCategory.ascx.cs" %>
<div>
    <asp:MultiView runat="server" ID="mvSubCategories">
        <asp:View runat="server" ID="Vgrid">
            <div align="right">
                <asp:LinkButton runat="server" ID="lnkbtnAdd" Text="Add SubCategory" OnClick="lnkbtnAdd_Click"></asp:LinkButton>
            </div>
            <div align="center">
                <asp:GridView runat="server" ID="gvSubCategories" AutoGenerateColumns="false" OnRowCommand="gvSubCategories_RowCommand"
                     DataKeyNames="ItemID, Main_CategoryId, Sub_Category_Name, Main_Category">
                    <Columns>
                        <asp:TemplateField HeaderText="Sub Category">
                            <ItemTemplate>
  <asp:Label runat="server" ID="lblsubcategoryId" Text='<%#Bind("ItemID") %>' Visible="false"></asp:Label>
                                <asp:Label runat="server" ID="lblsbcategory" Text='<%#Bind("Sub_Category_Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Main Category">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblmainCategory" Text='<%#Bind("Main_Category") %>'></asp:Label>
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
                        <td>Main Category</td><td>:</td><td>
                            <asp:DropDownList runat="server" ID="ddlCategories"></asp:DropDownList>
                                                        </td>
                    </tr>
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