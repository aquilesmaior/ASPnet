<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiasDeVida.aspx.cs" Inherits="Exercicios_1.DiasDeVida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Width="667px">
            </asp:Table>
        </div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="lbResultado" runat="server" Text="Dias de vida!!!"></asp:Label>
    </form>
</body>
</html>
