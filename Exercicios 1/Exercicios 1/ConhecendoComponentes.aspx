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
                    <td class="auto-style1">Empresa:</td>
                    <td class="auto-style2">Site:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSite" runat="server" Width="395px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAddress" runat="server" Width="440px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:ListBox ID="listAddress" runat="server" Width="401px" SelectionMode="Multiple">
                        </asp:ListBox>
                        <br />
                        <br />
                        <asp:DropDownList ID="dlistSite" runat="server" Width="399px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        Opções<br />
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Adicionar Site" />
                        <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Selecionar Site" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
