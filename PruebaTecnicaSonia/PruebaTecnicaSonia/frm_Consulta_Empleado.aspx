<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Consulta_Empleado.aspx.cs" Inherits="PruebaTecnicaSonia.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 113px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:50%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Documento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_Documento" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="Consultar" />
                </td>
            </tr>
            </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Tipo Documento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_tipoDoc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Documento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_NDocumento" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="N° Contrato"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_Contrato" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Cargo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_cargo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="ARL"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_Arl" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label8" runat="server" Text="Fecha Inicio Contrato"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_fechaIni" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Fecha Final Contrato"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_fechaFin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label9" runat="server" Text="Salario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_salario" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
