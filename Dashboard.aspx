<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="Feedback_System.Dashboard" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div style="background:pink" align="center">
        <div class="container containter-table" style="height: 127px; width: 1248px; margin-left: 0px;">
        </div>
        <div class="container container-table" style="margin: 0 auto;">
            <div class="row vertical-center-row" style="height: 472px; margin-top: 0px; width: 1101px;">
                <div class="text-center table-center col-md-4 col-md-offset-4" style="left: -98px; top: -173px; height: 643px; width: 1406px; margin-right: 0px;">
                    <div class="center" style="height: 404px; width: 515px; margin-left: 0px; margin-top: 138px; margin-right: 0px;">
                        <br />
                        <br />
                        <br />
                        <img src="\Images\Admin.jpg" /><h2 style="text-decoration: underline"><b><em>ADMIN LOGIN</em></b></h2>
                        <br />
    <div>
        <br />
        <br />
     
        <div>
            <asp:GridView ID="gvFaculty" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="FacultyID"
                ShowHeaderWhenEmpty="true"

                OnRowCommand="gvFaculty_RowCommand" OnRowEditing="gvFaculty_RowEditing" OnRowCancelingEdit="gvFaculty_RowCancelingEdit"
                OnRowUpdating="gvFaculty_RowUpdating" OnRowDeleting="gvFaculty_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <%-- Theme Properties --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                
                <Columns>
                    <asp:TemplateField HeaderText="Faculty Name">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("FacultyName") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFacultyName" Text='<%# Eval("FacultyName") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFacultyNameFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Subject Handling">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Subject") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSubject" Text='<%# Eval("Subject") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtSubjectFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/Images/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />

        </div>
 </div></div></div></div></div>
        </div></asp:Content>