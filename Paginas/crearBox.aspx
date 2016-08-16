<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="crearBox.aspx.cs" Inherits="Paginas.crearBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td></td>
            <td ></td>
            <td ></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td >ID:</td>
            <td >
                <asp:Label ID="lblIdBox" runat="server"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td >Tipo:</td>
            <td >
                <asp:DropDownList ID="ddlTipoBox" runat="server" DataValueField="ID_TIPO" DataTextField="NOMBRE_TIPO">
                </asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td ></td>
            <td >Tamaño:</td>
            <td >
                <asp:DropDownList ID="ddlTamanoBox" runat="server" DataValueField="ID_TAMANO" DataTextField="TAMANO">
                </asp:DropDownList>
            </td>
            <td ></td>
        </tr>
        <tr>
            <td></td>
            <td ></td>
            <td >
                <asp:Button ID="btnCrear" runat="server" OnClick="btnCrear_Click" Text="Crear" class="btnCrear"/>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td ></td>
            <td >
                </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
