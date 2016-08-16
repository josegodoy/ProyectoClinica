<%@ Page Title="" Language="C#" MasterPageFile="~/AdmCentro.Master" AutoEventWireup="true" CodeBehind="centroAgregarBox.aspx.cs" Inherits="Paginas.centroAgregarBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
    <tr>
        <td ></td>
        <td ><strong>Crear Box de Atención</strong></td>
        <td></td>
    </tr>
    <tr>
        <td ></td>
        <td ></td>
        <td></td>
    </tr>
    <tr>
        <td >ID:</td>
        <td >
            <asp:Label ID="lblIDbox" runat="server"></asp:Label>
        </td>
        <td></td>
    </tr>
    <tr>
        <td >Tipo:</td>
        <td >
            <asp:DropDownList ID="ddlTipoBoxAdd" runat="server" DataTextField="NOMBRE_TIPO" DataValueField="ID_TIPO">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td >Tamaño:</td>
        <td >
            <asp:DropDownList ID="dllTamañoAdd" runat="server" DataTextField="TAMANO" DataValueField="ID_TAMANO">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td ></td>
        <td >
            <asp:Button ID="btnAgregar" runat="server" CssClass="btnBuscar" OnClick="btnAgregar_Click" Text="Agregar" />
        </td>
        <td>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
