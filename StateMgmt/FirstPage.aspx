<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FirstPage.aspx.cs" Inherits="FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Consolas; font-size: xx-large; font-style: italic; font-variant: inherit; text-transform: capitalize; color: #66FFFF; line-height: 10px; vertical-align: 5%; text-align: center; white-space: normal; word-spacing: normal; letter-spacing: normal; text-decoration: underline blink;">
    
        State Management Examples<br />
        <br />
        <br />
        <br />
    
    </div>
        <p style="font-family: Consolas; font-size: large; font-weight: normal; font-style: italic; text-transform: capitalize; color: #000099; line-height: inherit; text-align: left; white-space: normal; word-spacing: normal; letter-spacing: normal; background-color: #FFFFFF">
            Enter Account Number:<asp:TextBox ID="txtAccno" runat="server" BorderColor="#66FFFF" BorderStyle="Outset"></asp:TextBox>
        </p>
        <p style="font-family: Consolas; font-size: large; font-weight: normal; font-style: italic; font-variant: normal; text-transform: capitalize; color: #0033CC; line-height: normal; text-align: left; white-space: normal; word-spacing: normal; letter-spacing: normal">
            Enter City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="txtCity" runat="server" BorderColor="#66FFFF" BorderStyle="Outset"></asp:TextBox>
        </p>
        <p style="font-family: Consolas; font-size: large; font-weight: normal; font-style: italic; font-variant: normal; text-transform: capitalize; color: #0033CC; line-height: normal; text-align: left; white-space: normal; word-spacing: normal; letter-spacing: normal">
            SESSIONID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="btnNext" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" Font-Strikeout="False" ForeColor="Black" OnClick="btnNext_Click" Text="GOTO NEXT PAGE" />
    </form>
</body>
</html>
