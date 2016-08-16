<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listaBox.aspx.cs" Inherits="Paginas.listaBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 226px;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="4" class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seleccione un Box</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ImageButton ID="btnBox1" runat="server" OnClick="btnBox1_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox1" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo1" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox2" runat="server" OnClick="btnBox2_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox2" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo2" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox3" runat="server" OnClick="btnBox3_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox3" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo3" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox4" runat="server" OnClick="btnBox4_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox4" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo4" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ImageButton ID="btnBox5" runat="server" OnClick="btnBox5_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox5" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo5" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox6" runat="server" OnClick="btnBox6_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox6" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo6" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox7" runat="server" OnClick="btnBox7_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox7" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo7" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox8" runat="server" OnClick="btnBox8_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox8" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo8" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ImageButton ID="btnBox9" runat="server" OnClick="btnBox9_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox9" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo9" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox10" runat="server" OnClick="btnBox10_Click1" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox10" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo10" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox11" runat="server" OnClick="btnBox11_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox11" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo11" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano11" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="btnBox12" runat="server" OnClick="btnBox12_Click" />
                    <br />
                    Box N:<asp:Label ID="lblIdBox12" runat="server"></asp:Label>
                    <br />
                    Tipo:<asp:Label ID="lblTipo12" runat="server"></asp:Label>
                    <br />
                    Tamaño:<asp:Label ID="lblTamano12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

