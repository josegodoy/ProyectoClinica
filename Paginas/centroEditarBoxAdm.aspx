<%@ Page Title="" Language="C#" MasterPageFile="~/AdmCentro.Master" AutoEventWireup="true" CodeBehind="centroEditarBoxAdm.aspx.cs" Inherits="Paginas.centroEditarBoxAdm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>ID Box:</td>
            <td>
                <asp:Label ID="lblIdBox" runat="server"></asp:Label>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Tipo:</td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control" DataTextField="nombre_tipo" DataValueField="id_tipo">
                </asp:DropDownList>
            </td>
            <td>Estado:</td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control" DataTextField="estado" DataValueField="id_estado">
                </asp:DropDownList>
            </td>
            <td>Tamaño:</td>
            <td>
                <asp:DropDownList ID="ddlTamano" runat="server" CssClass="form-control" DataTextField="tamano" DataValueField="id_tamano">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="btnModificar" runat="server" CssClass="btnCrear" OnClick="btnModificar_Click" Text="Modificar" />
            </td>
            <td></td>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
