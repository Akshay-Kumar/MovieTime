<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminhome.aspx.cs" Inherits="adminhome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 940px;
        }
        #form1
        {
            width: 1172px;
            height: 784px;
        }
    </style>
</head>
<body background="images/1.jpg">
    <form id="form1" runat="server">
    <table style="width: 100%; height: 347px;">
        <tr>
            <td style="background-image: url('images/line.jpg')">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton1_Click">Admin Home</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton2_Click">Add Admin</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton 
                    ID="LinkButton3" runat="server" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton3_Click">Change Password</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton4" runat="server" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton4_Click">Logout</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1" 
                style="background-image: url('images/strip1.jpg'); background-repeat: no-repeat;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton5" runat="server" 
                    Font-Names="Arial Rounded MT Bold" Font-Size="Large" ForeColor="White" 
                    onclick="LinkButton5_Click">Add Screen</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1" 
                style="background-image: url('images/strip1.jpg'); background-repeat: no-repeat;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton10" runat="server" 
                    Font-Names="Arial Rounded MT Bold" Font-Size="Large" ForeColor="White" 
                    onclick="LinkButton10_Click">Update Screen</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1" 
                style="background-image: url('images/strip1.jpg'); background-repeat: no-repeat;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton13" runat="server" 
                    Font-Names="Arial Rounded MT Bold" Font-Size="Large" ForeColor="White" 
                    onclick="LinkButton13_Click">Add Movies</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1" 
                style="background-image: url('images/strip1.jpg'); background-repeat: no-repeat;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton14" runat="server" Font-Bold="False" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton14_Click">Update Movies</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style1" 
                style="background-image: url('images/strip1.jpg'); background-repeat: no-repeat;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton15" runat="server" 
                    Font-Names="Arial Rounded MT Bold" ForeColor="White" 
                    onclick="LinkButton15_Click">Assign Movie</asp:LinkButton>
            </td>
        </tr>
        </table>
</form>
</body>
</html>
