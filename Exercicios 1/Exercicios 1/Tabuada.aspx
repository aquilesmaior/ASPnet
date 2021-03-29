<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="Exercicios_1.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <h1>Tabuada</h1>
        </div>
        <asp:DropDownList ID="dpNum" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnExecutar" runat="server" OnClick="btnExecutar_Click" Text="Exibir Tabuada" />
        <br />
        <asp:ListBox ID="lbxDados" runat="server" OnSelectedIndexChanged="lbxDados_SelectedIndexChanged" BackColor="Black" ForeColor="#66FF66" Height="251px" Visible="False" Width="74px"></asp:ListBox>
        <asp:Table ID="tbDados" runat="server" Height="305px" Visible="False" Width="213px">
        </asp:Table>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
