<%@ Page Title="" Language="C#" MasterPageFile="~/admIns.Master" AutoEventWireup="true" CodeBehind="admEditar.aspx.cs" Inherits="Paginas.admEditar" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>

     <div id="contenedorTabla">
           <table align="center">
               <tr>
                   <td > </td>
                   <td > <strong>
                       Editar Funcionario Rut:
                       <asp:Label ID="lblRut" runat="server"></asp:Label>
                       -<asp:Label ID="lblDv" runat="server"></asp:Label>
                       </strong>
                   </td>
                   <td > &nbsp;</td>
                   <td > &nbsp;</td>
               </tr>
               <tr>
                   <td >Nombre:</td>
                   <td >
                       <asp:TextBox ID="txtNombreEdit" runat="server" class="form-control" Enabled="False"></asp:TextBox>
                   </td>
                   <td >
                       Dirección:</td>
                   <td >
                       <asp:TextBox ID="txtDireccionEdit" runat="server" class="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDireccionEdit" ErrorMessage="(*)Ingrese una dirección" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td >Apellido Paterno:</td>
                   <td >
                       <asp:TextBox ID="txtPaternoEdit" runat="server" class="form-control" Enabled="False"></asp:TextBox>
                   </td>
                   <td >
                       Correo Electronico:</td>
                   <td >
                       <asp:TextBox ID="txtCorreoEdit" runat="server" class="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCorreoEdit" ErrorMessage="(*)Ingrese un correo electrónico" ForeColor="Red"></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreoEdit" ErrorMessage="(*)Correo No valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                   </td>
               </tr>
               <tr>
                   <td >Apellido Materno:</td>
                   <td >
                       <asp:TextBox ID="txtMaternoEdit" runat="server" Enabled="False"></asp:TextBox>
                   </td>
                   <td >
                       Fono:</td>
                   <td >
                       <asp:TextBox ID="txtFonoEdit" runat="server" class="form-control"></asp:TextBox>
                       <cc1:FilteredTextBoxExtender ID ="FilteredTextBoxExtender2" runat="server" FilterType="Numbers" TargetControlID="txtFonoEdit" >
                        </cc1:FilteredTextBoxExtender>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFonoEdit" ErrorMessage="(*)Ingrese un teléfono" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td >Cargo:</td>
                   <td >
                       <asp:DropDownList ID="ddlCargo" class="form-control" runat="server" DataTextField="NOMBRE_CARGO" DataValueField="ID_CARGO">
                       </asp:DropDownList>
                   </td>
                   <td >
                       Sede:</td>
                   <td >
                       <asp:DropDownList ID="ddlCentro" class="form-control" DataTextField="NOMBRE_CENTRO" DataValueField="ID_CENTRO" runat="server">
                       </asp:DropDownList>
                   </td>
               </tr>
               <tr>
                   <td >Estado:</td>
                   <td >
                       
                       <asp:DropDownList ID="ddlEstado" class="form-control" runat="server" DataTextField="NOMBRE_ESTADO" DataValueField ="ID_ESTADO">
                       </asp:DropDownList>
                       
                   </td>
                   <td >
                       &nbsp;</td>
                   <td >
                       <asp:Button CssClass="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                   </td>
               </tr>
               </table>
           </div>
</asp:Content>
