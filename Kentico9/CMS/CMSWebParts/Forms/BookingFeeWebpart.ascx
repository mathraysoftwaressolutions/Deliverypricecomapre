<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_Forms_BookingFeeWebpart"  CodeFile="~/CMSWebParts/Forms/BookingFeeWebpart.ascx.cs" %>
<div>
  <script type="text/javascript">
        function NumberOnly(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 12 && (charCode < 45 || charCode > 57)) {
                alert("Please enter numbers only");
                return false;
            }
        }
    </script>
</div>
<div>
  
    <table>       
        <tr>
            <td colspan="3" align="center">

                <div align="right" runat="server" ID="vSlabs" visible="false">
<asp:LinkButton runat="server" ID="lnkbtnAddSlabs" Text="Add Slab" OnClick="lnkbtnAddSlabs_Click"></asp:LinkButton>
                </div>
                    <div align="center">
                <asp:GridView runat="server" ID="gvbookingfee" AutoGenerateColumns="false" DataKeyNames="ItemID, Booking_Fee, SlabFrom, SlabTo, IsActive">
                    <Columns>
                        <asp:TemplateField HeaderText="Slab Starting">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblslabfrom" Text='<%#Bind("SlabFrom") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Slab Ending">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblslabto" Text='<%#Bind("SlabTo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Booking Fee in %">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblbookingfee" Text='<%#Bind("Booking_Fee") %>'></asp:Label>
                                <asp:Label runat="server" ID="lblActive" Text='<%#Bind("IsActive") %>' Visible="false"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                    </div>

               
                        <div runat="server" ID="vAddSlab">
 <table align="right">
            <tr>
                <td>
                    <asp:Button runat="server"
                        ID="btnAddNewRow" Text="Add Slab"  class="form-control btn-primary but100" OnClick="btnAddNewRow_Click"/>
                </td>
            </tr>
        </table>
        <br />

        <div align="center" style="margin-top: 20px;">
            <table style="margin-top: 20px;">
                <tr>
                    <td colspan="3" align="center">
                        <asp:GridView runat="server" ID="gvmeteredrate" AutoGenerateColumns="false" OnRowCommand="gvmeteredrate_RowCommand"
                            HeaderStyle-HorizontalAlign="Center" GridLines="None" >

                            <Columns>
                                <asp:TemplateField HeaderText="From">
                                    <ItemTemplate>
                                        <asp:TextBox runat="server" ID="txtFrom" Text='<%#Bind("SlabFrom") %>' onkeypress="return NumberOnly(event)" 
                                            MaxLength="11" Enabled="false" style="width:100%" ></asp:TextBox>
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="To">
                                    <ItemTemplate>
                                        <asp:TextBox runat="server" ID="txtTo" MaxLength="11" Text='<%#Bind("SlabTo") %>' onkeypress="return NumberOnly(event)" 
                                            style="width:100%"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="revTo" runat="server" ErrorMessage="Only Decimals With Precision Less Than 3"
                                            ControlToValidate="txtTo" ValidationExpression="^\d+(\.\d{1,2})?$"></asp:RegularExpressionValidator>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Rate(% )">                                
                                    <ItemTemplate>
                                     <asp:TextBox  runat="server" ID="txtRate" Text='<%#Bind("Booking_Fee") %>' OnTextChanged="txtRate_TextChanged"
                                             onkeypress="return NumberOnly(event)" MaxLength="11"   AutoPostBack="true" style="width:100%" ></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="revRate" runat="server" ErrorMessage="Only Decimals With Precision Less Than 3"
                                            ControlToValidate="txtRate" ValidationExpression="^\d+(\.\d{1,2})?$"></asp:RegularExpressionValidator>                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField >
                                    <ItemTemplate>
                                       <asp:Button runat="server" ID="btnRemoveRow" Text="Remove Row" CommandName="PageDelete" CommandArgument='<%#Container.DataItemIndex  %>'
                                            OnClientClick="return confirm('Are you sure you want to delete the row....? ' )"  />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Button runat="server" ID="btnFinalizeslab" Text="Finalize Slabs" Visible="false" class="form-control btn-primary but100"
                        OnClick="btnFinalizeslab_Click"  />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" Visible="false" class="form-control btn-primary but100"
                        OnClick="btnSubmit_Click"  />
                    </td>
                </tr>
            </table>
        </div>
                        </div>
                   
            </td>
        </tr>
    </table>

     
</div>