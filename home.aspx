<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">

        .style11
        {
            width: 293px;
        }
        .style12
        {
            width: 291px;
        }
        .style10
        {
            width: 222px;
        }
        .style15
        {
            width: 292px;
        }
        .style13
        {
            width: 300px;
        }
        .style14
        {
            width: 168px;
        }
        .style17
        {
            width: 320px;
        }
        .style18
        {
            width: 303px;
        }
        .style16
        {
            width: 421px;
        }
    </style>
</head>
<body bgcolor="#000000">
    <form id="form1" runat="server">
    
        <table style="width: 105%; height: 300px;">
            <tr>
                <td class="style16" 
                    style="background-image: url('images/cover3.png'); background-repeat: no-repeat">
                    &nbsp;</td>
                <td style="background-image: url('images/spidey1.jpg'); background-repeat: no-repeat;">
                    &nbsp;</td>
            </tr>
        </table>
    <p style="width: 1253px">
&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" 
            Font-Names="Copperplate Gothic Bold" Font-Overline="False" Font-Size="XX-Large" 
            Font-Underline="True" ForeColor="White" Text="NOW SHOWING" Width="295px"></asp:Label>
    </p>
        <table style="width: 100%; height: 400px;">
            <tr>
                <td class="style18" 
                    
                    style="background-image: url('images/fight_club_movie_poster.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                    &nbsp;</td>
                <td class="style11" 
                    style="border-width: medium; background-image: url('images/Final Destination 4 French Poster.jpg'); background-repeat: no-repeat; border-style: ridge">
                    &nbsp;</td>
                <td class="style12" 
                    style="border-width: medium; border-style: ridge; background-image: url('images/MOV_8d85e6c4_b.jpg'); background-repeat: no-repeat;">
                    &nbsp;</td>
                <td class="style10" style="background-image: url('images/transformers1.jpg')">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Constantia" 
                        Font-Size="Large" ForeColor="White" Text="USER ID"></asp:Label>
                    <br />
&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Constantia" 
                        Font-Size="Large" ForeColor="White" Text="PASSWORD"></asp:Label>
&nbsp;
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td style="background-image: url('images/transformers2.jpg')" class="style17">
                    &nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="174px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Width="173px" TextMode="Password"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Sign IN" 
                        onclick="Button1_Click" BackColor="Black" ForeColor="White" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" BackColor="Black" 
                        ForeColor="White" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Red" 
                        onclick="LinkButton1_Click">Sign Up</asp:LinkButton>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" BackColor="Black" ForeColor="White" 
                        onclick="Button3_Click" Text="Proceed as Guest" />
                </td>
            </tr>
        </table>
    <p style="width: 1254px">
&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Names="Copperplate Gothic Light" 
            Font-Size="XX-Large" Font-Underline="True" ForeColor="White" Text="COMING SOON"></asp:Label>
    </p>
    </form>
        <table style="width: 101%; height: 400px;">
            <tr>
                <td class="style15" 
                    style="background-image: url('images/bollywood_movie_posters_39.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                    &nbsp;</td>
                <td class="style12" 
                    style="background-image: url('images/shahrukh-khan-don-2-movie-posters-photos2_20111223074040_300x400.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                    &nbsp;</td>
                <td class="style13" 
                    style="background-image: url('images/MOV_4be5217c_b.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                    &nbsp;</td>
                <td class="style14" 
                    style="background-image: url('images/pc1.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                </td>
                <td style="background-image: url('images/pc2.jpg'); background-repeat: no-repeat; border-style: ridge; border-width: medium">
                    &nbsp;</td>
            </tr>
        </table>
    </body>
</html>
