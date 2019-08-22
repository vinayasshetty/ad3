<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AssgmtFirst.aspx.cs" Inherits="AssgmtFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter Word&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="txtword" runat="server"></asp:TextBox>
        <br />
        Enter Meaning:<asp:TextBox ID="TxtMeaning" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="btnstore" runat="server" OnClick="btnstore_Click" Text="STORE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnfinish" runat="server" OnClick="btnfinish_Click" Text="FINISH" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
