<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Student.aspx.cs" Inherits="Feedback_System.Student" %>

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
                        <img src="\Images\Student.jpg" /><h2 style="text-decoration: underline"><b><em>STUDENT LOGIN</em></b></h2>
                        <br />
   
    <div>
    <table style="margin: 0 auto 0 0px">
        <tr>
            <td class="nav-justified">
                                                <span style="color: #FF0000; font-size: large;">
                <asp:Label ID="Label1" runat="server" Text="Username" style="width: 171px; height: 24px; margin-top: 0px;"><em>User Name:</em></asp:Label></span></td>
            <td style="width: 100%;" padding="5,2,2,2"  align="center">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="nav-justified">
                                                <span style="color: #FF0000; font-size: large;">
                <asp:Label ID="Label2" runat="server" Text="Password"  style="width: 171px; height: 24px; margin-top: 0px;"><em>Password:</em></asp:Label></span></td>
            <td style="width: 100%;" padding="5,2,2,2"  align="center">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="StudentLogin" runat="server" Text="Login" OnClick="StudentLogin_Click" Width="135px" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="timesnewroman" Height="41px" BackColor="Blue" style="font-size: large"/></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials" ForeColor="Red"></asp:Label></td>
        </tr>
    </table>
    </div>
   
                        </div></div></div></div></div></asp:Content>

