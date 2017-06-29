<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Sample Site - Test<br />
        <br />
        <asp:Button ID="BTN1" runat="server" Text="ClickMe" OnClick="BTN1_Click" />
        <br />
        <br />
        <asp:TextBox ID="TXT1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BTN2" runat="server" Text="Clear" OnClick="BTN2_Click" Visible="False" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
