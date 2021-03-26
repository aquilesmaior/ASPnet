<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Exercicios_1.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello World - Aula 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="btnExecutar" runat="server" OnClick="btnExecutar_Click" Text="Executar" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Escreva o que deseja informar na caixa de texto"></asp:Label>
    </form>
</body>
</html>
