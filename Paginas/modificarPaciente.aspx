<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="modificarPaciente.aspx.cs" Inherits="Paginas.modificarPaciente" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    <div id="contenedorTabla">
           <table align="center">
               <tr>
                   <td ></td>
                   <td > </td>
                   <td >Editar Paciente Rut:
                       <asp:Label ID="lblRut" runat="server"></asp:Label>
                -<asp:Label ID="lblDv" runat="server"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td ></td>
                   <td >
                       </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Nombre:</td>
                   <td >
                       <asp:TextBox ID="txtNombre" runat="server" Width="199px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="(*)Debe haber un nombre" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Apellido Paterno:</td>
                   <td >
                       <asp:TextBox ID="txtAPaterno" runat="server" Width="199px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAPaterno" ErrorMessage="(*)Debe haber un apellido" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Apellido Materno:</td>
                   <td >
                       <asp:TextBox ID="txtAMaterno" runat="server" Width="199px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAMaterno" ErrorMessage="(*)Debe haber un apellido" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Direccion:</td>
                   <td >
                       <asp:TextBox ID="txtDireccion" runat="server" Width="199px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDireccion" ErrorMessage="(*)Escriba una dirección" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Fecha Nacimiento:</td>
                   <td >
                       <asp:TextBox ID="txtFechaNac" runat="server" Width="199px"></asp:TextBox>
                       <cc1:calendarextender id="CalendarExtender1" runat="server" targetcontrolid="txtFechaNac" FirstDayOfWeek="Monday" ></cc1:calendarextender>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtFechaNac" ErrorMessage="(*)Seleccione una fecha" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Fono:</td>
                   <td >
                        <cc1:FilteredTextBoxExtender ID ="txtNumeros" runat="server" FilterType="Numbers" TargetControlID="txtFono" ></cc1:FilteredTextBoxExtender>
                       <asp:TextBox ID="txtFono" runat="server" Width="199px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFono" ErrorMessage="(*)Debe haber un fono" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
        
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:Button CssClass="btnModificar" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
            </td>
        </tr>
    </table>
        </div>
</asp:Content>
