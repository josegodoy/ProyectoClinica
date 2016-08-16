<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insumos.aspx.cs" Inherits="Paginas.insumos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
            <tr>
                <td></td>
                <td></td>
                <td>
                    <asp:Label ID="lblAgenda" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:GridView ID="gdvLista" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="id_insumo" HeaderText="ID" SortExpression="nombre_insumo" />
                            <asp:BoundField DataField="nombre_insumo" HeaderText="Nombre" SortExpression="nombre_insumo" />
                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />
                             <asp:TemplateField HeaderText ="Escribir Cantidad">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtCant" runat="server"  />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:Button ID="btnInsumos" runat="server" OnClick="btnInsumos_Click" Text="Aceptar" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td>
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    </td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
