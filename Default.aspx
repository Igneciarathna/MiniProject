<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Feedback_System._Default" %>

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
                        <img src="\Images\Login.jpg" /><h2 style="text-decoration: underline"><b><em>FEEDBACK COLLECTION SYSTEM</em></b></h2>
                        <br />
                         <asp:Button ID="Admin" runat="server" OnClick="Admin_Click" Text="Admin" Width="135px" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="timesnewroman" Height="41px" BackColor="Blue" style="font-size: large" />
                        <br />
                        <br />
                        <asp:Button ID="Student" runat="server" OnClick="Student_Click" Text="Student" Width="135px" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="timesnewroman" Height="41px" BackColor="Blue" style="font-size: large" />
                         <br /><br />
                        <asp:Button ID="Staff" runat="server" OnClick="Staff_Click" Text="Staff" Width="135px" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="timesnewroman" Height="41px" BackColor="Blue" style="font-size: large" />
                         <br /><br />
                              <br style="background-color: #f6ebed" />
                        <br />
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
