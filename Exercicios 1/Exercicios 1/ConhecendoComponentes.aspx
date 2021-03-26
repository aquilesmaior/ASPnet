<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConhecendoComponentes.aspx.cs" Inherits="Exercicios_1.ConhecendoComponentes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conhecendo os Componentes - Parte 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 414px;
        }
        .auto-style2 {
            width: 461px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Site</td>
                    <td class="auto-style2">Endereço</td>
                    <td>Opções</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSite" runat="server" Width="395px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAddress" runat="server" Width="440px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Adicionar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="dlistSite" runat="server">
                            <asp:ListItem Value="0">Aquiles</asp:ListItem>
                            <asp:ListItem Value="1">Music</asp:ListItem>
                            <asp:ListItem Value="2">Games</asp:ListItem>
                            <asp:ListItem Value="3">Bruce</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style2">
                        <asp:ListBox ID="lista" runat="server" Width="380px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
