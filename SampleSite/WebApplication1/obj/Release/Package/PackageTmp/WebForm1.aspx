<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WebForm on Dot Net 2<br />
            <br />
            <br />
            <asp:Button ID="BTN1" runat="server" Text="ClickMe" OnClick="BTN1_Click" />
            <br />
            <br />
            <asp:TextBox ID="TXT1" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
