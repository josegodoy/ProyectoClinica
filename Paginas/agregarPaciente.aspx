<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="agregarPaciente.aspx.cs" Inherits="Paginas.agregarPaciente" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    <div id="contenedorTabla">
           <table class="principal" align="center">
               <tr>
                   <td ></td>
                   <td ></td>
                   <td ><strong>Ingresar nuevo Paciente</strong> </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Rut :</td>
                   <td >
                       <asp:TextBox ID="txtRut" placeholder="Ej:12345678" runat="server"  AutoPostBack = "true" OnTextChanged="txtRut_TextChanged"></asp:TextBox>
                       -<asp:Label ID="txtDv" runat="server"></asp:Label>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRut" ErrorMessage="(*)Ingrese Rut" BackColor="White" BorderColor="Black" ForeColor="Red"></asp:RequiredFieldValidator>
                       
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Nombre:</td>
                   <td >
                       <asp:TextBox ID="txtNombre" placeholder="Ej:Juan"   runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="(*)Ingrese Nombre" BorderColor="Red" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Apellido Paterno:</td>
                   <td >
                       <asp:TextBox ID="txtAPaterno" placeholder="Ej:Perez"  runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAPaterno" ErrorMessage="(*)Ingrese Apellido Paterno" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Apellido Materno:</td>
                   <td >
                       <asp:TextBox ID="txtAMaterno" placeholder="Ej:Silva"  runat="server"  ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="(*)Ingrese Apellido Materno" ControlToValidate="txtAMaterno" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Fecha Nacimiento:</td>
                   <td >
                       <asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
                       <cc1:calendarextender id="CalendarExtender2" runat="server" targetcontrolid="txtFechaNac" FirstDayOfWeek="Monday" ></cc1:calendarextender>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="(*)Ingrese Fecha de Nacimiento" ControlToValidate="txtFechaNac" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Dirección:</td>
                   <td >
                       <asp:TextBox ID="txtDireccion" placeholder="Ej: Alvarez 234, Viña del Mar"  runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDireccion" ErrorMessage="(*)Ingrese Dirección" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Fono:</td>
                   <td >
                       <asp:TextBox ID="txtFono" placeholder="Ej:975534678" runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtFono" ErrorMessage="(*)Ingrese Telefono" ForeColor="Red"></asp:RequiredFieldValidator>
                       <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtFono" ErrorMessage="(*)Solo numeros" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                   </td>
               </tr>
                <tr>
                   <td ></td>
                   <td ></td>
                   <td >
                        <asp:Button CssClass="btnCrear" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                   </td>
               </tr>
      
            
        <tr>
            <td ></td>
            <td></td>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        </div>
</asp:Content>
