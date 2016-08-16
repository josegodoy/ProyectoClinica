<%@ Page Title="" Language="C#" MasterPageFile="~/AdmCentro.Master" AutoEventWireup="true" CodeBehind="reporteInsumos.aspx.cs" Inherits="Paginas.reporteInsumos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>ID Sesiones:</td>
            <td>
                <asp:DropDownList ID="dllAgendas" runat="server" class="form-control" DataTextField ="id_atencion" DataValueField="id_atencion">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnBuscar" CssClass="btnCrear" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
    <table align="center">
        <tr>
            <td>
                <asp:GridView ID="gdvLista" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" CssClass= "table table-striped table-bordered table-condense">
                    <Columns>
                        <asp:BoundField DataField="id_atencion" HeaderText="ID" SortExpression="id_atencion" />
                        <asp:BoundField DataField="nombre_insumo" HeaderText="Insumo" SortExpression="nombre_insumo" />
                        <asp:BoundField DataField="fechauso" HeaderText="Fecha de uso" SortExpression="fechauso" />
                        <asp:BoundField DataField="horauso" HeaderText="Hora de uso" SortExpression="horauso" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad Utilizada" SortExpression="cantidad" />                     
                    </Columns>
                    <AlternatingRowStyle BackColor="White" />
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
        </tr>
    </table>
</asp:Content>
