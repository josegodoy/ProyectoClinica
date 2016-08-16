<%@ Page Title="" Language="C#" MasterPageFile="~/AdmCentro.Master" AutoEventWireup="true" CodeBehind="reporteBox.aspx.cs" Inherits="Paginas.reporteBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td ></td>
            <td ></td>
            <td></td>
        </tr>
        <tr>
            <td >Ingrese Número de Box:</td>
            <td >
                <asp:DropDownList ID="ddlBox" runat="server" CssClass="form-control" DataTextField="id_box" DataValueField="id_box">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" CssClass="btnCrear" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td ></td>
            <td ></td>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        </table>
    <table>
        <tr>
            <td>
                <asp:GridView ID="gdvLista" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False"  CssClass= "table table-striped table-bordered table-condense">
                    <Columns>
                        <asp:BoundField DataField="idAtencion" HeaderText="Atencion No." SortExpression="idAtencion" />
                        <asp:BoundField DataField="numeroBox" HeaderText="N.Box" SortExpression="numeroBox" />
                        <asp:BoundField DataField="tipodebox" HeaderText="Tipo Box" SortExpression="tipodebox" />
                        <asp:BoundField DataField="estadoBox" HeaderText="Estado de Box" SortExpression="estadoBox" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" SortExpression="descripcion" />
                        <asp:BoundField DataField="fechaInicio" HeaderText="F.Inicio" SortExpression="fechaInicio" />
                        <asp:BoundField DataField="horaInicio" HeaderText="H.Inicio" SortExpression="horaInicio" />
                        <asp:BoundField DataField="fechaFin" HeaderText="F.Final" SortExpression="fechaFin" />
                        <asp:BoundField DataField="horaFin" HeaderText="H.Final" SortExpression="horaFin" />
                        <asp:BoundField DataField="estadoSesion" HeaderText="Estado Sesión" SortExpression="estadoSesion" />
                        <asp:BoundField DataField="fechaExtension" HeaderText="F.Extensión" SortExpression="fechaExtension" />
                        <asp:BoundField DataField="horaExtension" HeaderText="H.Extensión" SortExpression="horaExtension" />
                        <asp:HyperLinkField HeaderText ="Generar Documento" DataNavigateUrlFormatString="SalidaPDFBox.aspx?id={0}#top" DataNavigateUrlFields="idAtencion" Text="Generar Documento" />


                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
