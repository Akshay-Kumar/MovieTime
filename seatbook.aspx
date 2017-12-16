%@ Page Language="C#" AutoEventWireup="true" CodeFile="seatbook.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 769px;
        }
        #form2
        {
            height: 1027px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div style="height: 1024px; background-image: url('images/Power_ON-2560x1600.jpg');">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Names="Arial Black" 
            Font-Size="Large" ForeColor="White" Text="SEAT ARRANGEMENT FRONT END"></asp:Label>
&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"><span><strong>LogOut</strong></span></asp:LinkButton>
&nbsp;&nbsp; </strong>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="116px" 
            ImageUrl="~/images/screen.png" Width="870px" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Names="Arial Rounded MT Bold" 
            Font-Size="Large"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click"><span>Go 
        to Booking Page!</span></asp:LinkButton>
        <br />
        <br />
        <br />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Italic="True" 
            Font-Names="Arial Rounded MT Bold" ForeColor="White" Text="SEAT ARRANGEMENT"></asp:Label>
        <strong><span style="text-decoration: underline"><span style="font-size: 12pt">&nbsp;</span><br />
                </span></strong>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button 
            ID="Button2" runat="server" Height="53px" Text="A-1" Width="72px" 
            onclick="Button2_Click" />
        <asp:Button
                    ID="Button3" runat="server" Height="53px" Text="A-2" Width="66px" 
            onclick="Button3_Click" /><asp:Button
                        ID="Button4" runat="server" Height="53px" Text="A-3" 
            Width="65px" onclick="Button4_Click" /><asp:Button
                            ID="Button5" runat="server" Height="53px" Text="A-4" 
            Width="66px" onclick="Button5_Click" /><asp:Button
                                ID="Button6" runat="server" Height="52px" Text="A-5" 
            Width="64px" onclick="Button6_Click" /><asp:Button
                                    ID="Button7" runat="server" Height="52px" 
            Text="A-6" Width="66px" onclick="Button7_Click" /><strong> &nbsp;
                                        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:Button ID="Button8" runat="server" Height="52px" Text="A-7" Width="63px" 
            onclick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" Height="52px" Text="A-8" 
            Width="65px" onclick="Button9_Click" />
                <asp:Button ID="Button10" runat="server" Height="53px" Text="A-9" 
            Width="66px" onclick="Button10_Click" />
                <asp:Button ID="Button11" runat="server" Height="53px" Text="A-10" 
            Width="66px" onclick="Button11_Click" />
                <asp:Button ID="Button12" runat="server" Height="53px" Text="A-11" 
            Width="66px" onclick="Button12_Click" />
                <asp:Button ID="Button13" runat="server" Height="53px" Text="A-12" 
            Width="66px" onclick="Button13_Click" />
                <asp:Button ID="Button14" runat="server" Height="53px" Text="A-13" 
            Width="70px" onclick="Button14_Click" /><br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button15" runat="server" Height="53px" Text="B-1" 
            Width="66px" onclick="Button15_Click" />
                <asp:Button ID="Button16" runat="server" Height="53px" Text="B-2" 
            Width="66px" onclick="Button16_Click" />
                <asp:Button ID="Button17" runat="server" Height="53px" Text="B-3" 
            Width="66px" onclick="Button17_Click" />
                <asp:Button ID="Button18" runat="server" Height="53px" Text="B-4" 
            Width="66px" onclick="Button18_Click" />
                <asp:Button ID="Button19" runat="server" Height="53px" Text="B-5" 
            Width="66px" onclick="Button19_Click" />
                <asp:Button ID="Button20" runat="server" Height="53px" Text="B-6" 
            Width="66px" onclick="Button20_Click" /><strong>
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </strong>
                <asp:Button ID="Button21" runat="server" Height="53px" Text="B-7" 
            Width="66px" onclick="Button21_Click" />
                <asp:Button ID="Button22" runat="server" Height="53px" Text="B-8" 
            Width="66px" onclick="Button22_Click" />
                <asp:Button ID="Button23" runat="server" Height="53px" Text="B-9" 
            Width="66px" onclick="Button23_Click" />
                <asp:Button ID="Button24" runat="server" Height="53px" Text="B-10" 
            Width="66px" onclick="Button24_Click" />
                <asp:Button ID="Button25" runat="server" Height="53px" Text="B-11" 
            Width="66px" onclick="Button25_Click" />
                <asp:Button ID="Button26" runat="server" Height="53px" Text="B-12" 
            Width="66px" onclick="Button26_Click" />
                <asp:Button ID="Button27" runat="server" Height="53px" Text="B-13" 
            Width="66px" onclick="Button27_Click" /><br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button28" runat="server" Height="53px" Text="C-1" 
            Width="66px" onclick="Button28_Click" />
                <asp:Button ID="Button29" runat="server" Height="53px" Text="C-2" 
            Width="66px" onclick="Button29_Click" />
                <asp:Button ID="Button30" runat="server" Height="53px" Text="C-3" 
            Width="66px" onclick="Button30_Click" />
                <asp:Button ID="Button31" runat="server" Height="53px" Text="C-4" 
            Width="66px" onclick="Button31_Click" />
                <asp:Button ID="Button32" runat="server" Height="53px" Text="C-5" 
            Width="66px" onclick="Button32_Click" />
                <asp:Button ID="Button33" runat="server" Height="53px" Text="C-6" 
            Width="66px" onclick="Button33_Click" /><strong>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</strong><asp:Button 
            ID="Button34" runat="server"
                        Height="53px" Text="C-7" Width="66px" 
            onclick="Button34_Click" />
                <asp:Button ID="Button35" runat="server" Height="53px" Text="C-8" 
            Width="66px" onclick="Button35_Click" />
                <asp:Button ID="Button36" runat="server" Height="53px" Text="C-9" 
            Width="66px" onclick="Button36_Click" />
                <asp:Button ID="Button37" runat="server" Height="53px" Text="C-10" 
            Width="66px" onclick="Button37_Click" />
                <asp:Button ID="Button38" runat="server" Height="53px" Text="C-11" 
            Width="66px" onclick="Button38_Click" />
                <asp:Button ID="Button39" runat="server" Height="53px" Text="C-12" 
            Width="66px" onclick="Button39_Click" />
                <asp:Button ID="Button40" runat="server" Height="53px" Text="C-13" 
            Width="66px" onclick="Button40_Click" /><br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button41" runat="server" Height="53px" Text="D-1" 
            Width="66px" onclick="Button41_Click" />
                <asp:Button ID="Button42" runat="server" Height="53px" Text="D-2" 
            Width="66px" onclick="Button42_Click" />
                <asp:Button ID="Button43" runat="server" Height="53px" Text="D-3" 
            Width="66px" onclick="Button43_Click" />
                <asp:Button ID="Button44" runat="server" Height="53px" Text="D-4" 
            Width="66px" onclick="Button44_Click" />
                <asp:Button ID="Button45" runat="server" Height="53px" Text="D-5" 
            Width="66px" onclick="Button45_Click" />
                <asp:Button ID="Button46" runat="server" Height="53px" Text="D-6" 
            Width="66px" onclick="Button46_Click" /><strong>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</strong><asp:Button 
            ID="Button47" runat="server"
                        Height="53px" Text="D-7" Width="66px" 
            onclick="Button47_Click" />
                <asp:Button ID="Button48" runat="server" Height="53px" Text="D-8" 
            Width="66px" onclick="Button48_Click" />
                <asp:Button ID="Button49" runat="server" Height="53px" Text="D-9" 
            Width="66px" onclick="Button49_Click" />
                <asp:Button ID="Button50" runat="server" Height="53px" Text="D-10" 
            Width="66px" onclick="Button50_Click" />
                <asp:Button ID="Button51" runat="server" Height="53px" Text="D-11" 
            Width="66px" onclick="Button51_Click" />
                <asp:Button ID="Button52" runat="server" Height="53px" Text="D-12" 
            Width="66px" onclick="Button52_Click" />
                <asp:Button ID="Button53" runat="server" Height="53px" Text="D-13" 
            Width="66px" onclick="Button53_Click" /><br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button54" runat="server" Height="53px" Text="E-1" 
            Width="66px" onclick="Button54_Click" />
                <asp:Button ID="Button55" runat="server" Height="53px" Text="E-2" 
            Width="66px" onclick="Button55_Click" />
                <asp:Button ID="Button56" runat="server" Height="53px" Text="E-3" 
            Width="66px" onclick="Button56_Click" />
                <asp:Button ID="Button57" runat="server" Height="53px" Text="E-4" 
            Width="66px" onclick="Button57_Click" />
                <asp:Button ID="Button58" runat="server" Height="53px" Text="E-5" 
            Width="66px" onclick="Button58_Click" />
                <asp:Button ID="Button59" runat="server" Height="53px" Text="E-6" 
            Width="66px" onclick="Button59_Click" /><strong>
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </strong>
                <asp:Button ID="Button60" runat="server" Height="53px" Text="E-7" 
            Width="66px" onclick="Button60_Click" />
                <asp:Button ID="Button61" runat="server" Height="53px" Text="E-8" 
            Width="66px" onclick="Button61_Click" />
                <asp:Button ID="Button62" runat="server" Height="53px" Text="E-9" 
            Width="66px" onclick="Button62_Click" />
                <asp:Button ID="Button63" runat="server" Height="53px" Text="E-10" 
            Width="66px" onclick="Button63_Click" />
                <asp:Button ID="Button64" runat="server" Height="53px" Text="E-11" 
            Width="66px" onclick="Button64_Click" />
                <asp:Button ID="Button65" runat="server" Height="53px" Text="E-12" 
            Width="66px" onclick="Button65_Click" />
                <asp:Button ID="Button66" runat="server" Height="53px" Text="E-13" 
            Width="66px" onclick="Button66_Click" /><br />
                <br />
                </span><br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button67" runat="server" Height="53px" Text="F-1" 
            Width="66px" onclick="Button67_Click" />
        <asp:Button ID="Button68" runat="server" Height="53px" Text="F-2" 
            Width="66px" onclick="Button68_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;
        <asp:Button ID="Button69" runat="server" Height="53px" Text="F-3" 
            Width="66px" onclick="Button69_Click" />
        <asp:Button ID="Button70" runat="server" Height="53px" Text="F-4" 
            Width="66px" onclick="Button70_Click" />
        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button71" runat="server" Height="53px" Text="F-5" 
            Width="66px" onclick="Button71_Click" />
        <asp:Button ID="Button72" runat="server" Height="53px" Text="F-6" 
            Width="66px" onclick="Button72_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button73" runat="server" Height="53px" Text="F-7" 
            Width="66px" onclick="Button73_Click" />
        <asp:Button ID="Button74" runat="server" Height="53px" Text="F-8" 
            Width="66px" onclick="Button74_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button75" runat="server" BackColor="Black" ForeColor="White" 
            onclick="Button75_Click" Text="Go" Width="59px" />
        </div>
    </form>
</body>
</html>
