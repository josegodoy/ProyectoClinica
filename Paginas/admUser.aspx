<%@ Page Title="" Language="C#" MasterPageFile="~/admIns.Master" AutoEventWireup="true" CodeBehind="admUser.aspx.cs" Inherits="Paginas.admUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>

    <div class="form-group">
        <div align="center">   
            
            <strong>Crear Nuevo Funcionario</strong>
        </div>
           <table class= "table table-striped table-bordered table-condense">
               <tr>
                   <td  >Rut :</td>
                   <td  >
                       <asp:TextBox ID="txtRut" class="form-control" placeholder="Ej:12345678" runat="server" AutoPostBack="true" OnTextChanged="txtRut_TextChanged"></asp:TextBox>
                       <cc1:FilteredTextBoxExtender ID ="FilteredTextBoxExtender2" runat="server" FilterType="Numbers" TargetControlID="txtRut" >
                        </cc1:FilteredTextBoxExtender>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRut" ErrorMessage="(*)Ingrese Rut" BackColor="White" BorderColor="Black" ForeColor="Red"></asp:RequiredFieldValidator>
                       
                   </td>
                   <td  >
                       -<asp:Label ID="txtDv" runat="server"></asp:Label>
                       
                   </td>
                   <td >
                       </td>
               </tr>
               <tr>
                   <td  >Nombre y Apellidos:</td>
                   <td >
                       <div>
                           <asp:TextBox ID="txtNombre" placeholder="Ej:Juan"  class="form-control" runat="server" ></asp:TextBox>
                       </div>
                       
                   </td>
                   <td >
                       <asp:TextBox ID="txtPaterno" class="form-control" placeholder="Ej:Perez"  runat="server"></asp:TextBox>
                       </td>
                   <td>
                       <asp:TextBox ID="txtMaterno" class="form-control" placeholder="Ej:Silva"  runat="server"  ></asp:TextBox>
                       </td>
               </tr>
               <tr>
                   <td  ></td>
                   <td >
                       
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="(*)Ingrese Nombre" BorderColor="Red" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
                   <td >
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="(*)Ingrese Apellido Materno" ControlToValidate="txtMaterno" ForeColor="Red"></asp:RequiredFieldValidator>
                       </td>
                   <td>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPaterno" ErrorMessage="(*)Ingrese Apellido Paterno" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td  >Dirección:</td>
                   <td>
                       <asp:TextBox ID="txtDireccion" class="form-control" placeholder="Ej: Alvarez 234, Viña del Mar"  runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDireccion" ErrorMessage="(*)Ingrese Dirección" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
                   <td>

                       Fono:

                   </td>
                   <td>

                       <asp:TextBox ID="txtFono" class="form-control" placeholder="Ej:975534678" runat="server" ></asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID ="txtNumeros" runat="server" FilterType="Numbers" TargetControlID="txtFono" >
                        </cc1:FilteredTextBoxExtender>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFono" ErrorMessage="(*)Ingrese Telefono" ForeColor="Red"></asp:RequiredFieldValidator>
                      

                   </td>
               </tr>
               <tr>
                   <td >Correo Electronico:</td>
                   <td  colspan="3">
                       <asp:TextBox ID="txtCorreo" class="form-control" placeholder="ejemplo@mail.com"  runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCorreo" ErrorMessage="(*)Ingrese Correo" ForeColor="Red"></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreo" ErrorMessage="(*)Correo No valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                   </td>
                   <td>

                   </td>
               </tr>
               <tr>
                   <td  >Cargo:</td>
                   <td  >
                       <asp:DropDownList ID="ddlCargo" class="form-control" runat="server" DataValueField="ID_CARGO" DataTextField="NOMBRE_CARGO">
                       </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
            ErrorMessage="(*)Seleccione un Cargo" 
    ControlToValidate="ddlCargo" ForeColor="Red"/>
                   </td>
                   <td  >
                       Sede:</td>
                   <td >
                       <asp:DropDownList ID="ddlSede" class="form-control" runat="server"  DataValueField="ID_CENTRO" DataTextField="NOMBRE_CENTRO">
                       </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
            ErrorMessage="(*)Seleccione una Sede" 
    ControlToValidate="ddlSede" ForeColor="Red"/>
                       </td>
               </tr>
                       </table>

                    <div align="center">   
            
            <strong>Autenticación de Funcionario</strong>
        </div>
        <table class= "table table-striped table-bordered table-condense">
               <tr>
                   <td >N.&nbsp;&nbsp; Usuario:</td>
                   <td >
                       <asp:TextBox ID="txtLogginNombre" class="form-control" placeholder="j.perez"  runat="server"  OnTextChanged="txtLogginNombre_TextChanged"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" placeholder="Ej:12345678"  runat="server" ControlToValidate="txtLogginNombre" ErrorMessage="(*)Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
                   <td >
                       Contraseña:</td>
                   <td>
                       <asp:TextBox ID="txtLogginPass" class="form-control" placeholder="1234"  runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtLogginPass" ErrorMessage="(*)Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                       </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >
                      <asp:Button CssClass="btnCrear" ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />
                   </td>
                   <td >
                       
                       <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                       </td>
                   <td>
                       </td>
               </tr>
               </table>
           </div>
</asp:Content>
