<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="View.aspx.cs" Inherits="Feedback_System.View" %>

  <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div style="background:pink" align="center">
        <div class="container containter-table" style="height: 127px; width: 1248px; margin-left: 0px;">
        </div>
                        <br />
                        <br />
                        <br />
                        <img src="\Images\Staff.jpg" /><h2 style="text-decoration: underline"><b><em>Import Excel Sheet</em></b></h2>
                        <br />
    <div>
        <br />
       <asp:Button ID="Import" runat="server" Text="Import" OnClick="Import_Click"  Width="135px" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="timesnewroman" Height="41px" BackColor="Blue" style="font-size: large"/>
        <br />
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Height="16px">
                <%-- Theme Properties --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="green" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                
                <Columns>
    <asp:BoundField DataField="FacultyName" HeaderText="FacultyName" />
    <asp:BoundField DataField="Subject" HeaderText="Subject Handling" />
    <asp:BoundField DataField="Question1" HeaderText="The faculty covers the entire syllabus." />
    <asp:BoundField DataField="Question2" HeaderText="The faculty discusses topics in detail." />
    <asp:BoundField DataField="Question3" HeaderText="The faculty possesses deep knowledge of the subject taught." />
    <asp:BoundField DataField="Question4" HeaderText="The faculty communicates clearly." />
    <asp:BoundField DataField="Question5" HeaderText="The faculty inspires me by his/her knowledge in the subject." />
  </Columns></asp:GridView></div></div></div>
</asp:Content>
