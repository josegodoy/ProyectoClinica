<%@ Page Title="" Language="C#" MasterPageFile="~/Paciente.Master" AutoEventWireup="true" CodeBehind="loginPaciente.aspx.cs" Inherits="Paginas.loginPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td ></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td >Ingrese su Rut:</td>
            <td>
                <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" placeholder="Ingrese rut sin digito verificador"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRut" ErrorMessage="(*)Escriba su rut" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td ></td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td>
                <asp:Button ID="btnAcceder" runat="server" CssClass="btnCrear" OnClick="btnAcceder_Click" class="btn primary-primary" Text="Acceder" />
            </td>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
