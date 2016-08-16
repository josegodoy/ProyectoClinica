<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="admSesion.aspx.cs" Inherits="Paginas.admSesion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    
    <link href="dist/bootstrap-clockpicker.min.css" rel="stylesheet" />
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/highlight.min.js"></script>
    <script src="dist/jquery-clockpicker.min.js"></script> 
    
    <div>
    
        <table class= "table table-striped table-bordered table-condense">
            <tr>
                <td >Sesión No.</td>
                <td >
                    <asp:Label ID="lblId" runat="server"></asp:Label>
                </td>
                <td >Fecha Agendamiento:</td>
                <td>
                    <asp:Label ID="lblFechaAgendamiento" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >Rut Paciente :</td>
                <td >
                    <asp:TextBox ID="txtPaciente"  runat="server" class="form-control" placeHolder ="Ingrese rut sin digito verificador"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="vPaciente" ErrorMessage="(*)Ingrese un Rut del Paciente" ControlToValidate="txtPaciente" ForeColor="Red"></asp:RequiredFieldValidator>

                    <cc1:FilteredTextBoxExtender ID ="txtNumeros" runat="server" FilterType="Numbers" TargetControlID="txtPaciente" >

                    </cc1:FilteredTextBoxExtender>
                </td>
                <td >
                    <asp:Button ID="btnBuscar" class="btnCrear" runat="server" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup ="vPaciente" />
                </td>
                <td>
                    <asp:Label ID="lblPaciente" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >Tipo Tratamiento: </td>
                <td >
                    <asp:DropDownList ID="ddlTratamiento" class="form-control" runat="server" DataTextField="tratamiento" DataValueField="id_tratamiento" AutoPostBack="True" OnSelectedIndexChanged="ddlTratamiento_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td >Fecha Inicio:</td>
                <td >
                    <asp:TextBox ID="txtFechaInicio" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFechaInicio" ErrorMessage="(*)Ingresar una fecha de Inicio" ForeColor="Red" ValidationGroup="vSesion"></asp:RequiredFieldValidator>
                <cc1:calendarextender id="CalendarExtender1" runat="server" targetcontrolid="txtFechaInicio" FirstDayOfWeek="Monday" ></cc1:calendarextender>
                
                </td>
            </tr>
            <tr>
                <td >Descripción:</td>
                <td >
                    <asp:TextBox ID="txtExplicacion" class="form-control" TextMode="MultiLine" runat="server" Height="66px"></asp:TextBox>
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="(*)Escriba una descripción" ForeColor="Red" ValidationGroup="vSesion" ControlToValidate="txtExplicacion"></asp:RequiredFieldValidator>
                
                </td>
                <td >Hora Inicio: </td>
                <td >
                    
                                        
              
                   <asp:TextBox class ="input-group clockpicker" data-placement="top" data-alignment ="left" data-donetext="Aceptar"
                        ID="txthoraInicio"  runat="server" width ="134px" Height = "30px"></asp:TextBox>
                <!--<span class ="input-group-addon">
                    <span class ="glyphicon glyphicon-time"></span>
                </span>-->
         
            <script type ="text/javascript">
                $('.clockpicker').clockpicker();
    </script>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txthoraInicio" ErrorMessage="(*)Ingresar Hora Inicio" ForeColor="Red" ValidationGroup="vSesion"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td ></td>
                <td >
                    </td>
                <td ><strong>Equipo Médico</strong></td>
                <td >
                    </td>
            </tr>
            <tr>
                <td ></td>
                <td >
                    </td>
                <td ></td>
                <td ></td>
            </tr>
            <tr>
                <td >Enfermera</td>
                <td >
                    <asp:DropDownList ID="ddlEnfermera"  class="form-control" runat="server" DataTextField="nombre" DataValueField="rut_fun">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlEnfermera" ErrorMessage="(*)Debe seleccionar una enfermera" ForeColor="Red" ValidationGroup="vSesion"></asp:RequiredFieldValidator>
                </td>
                <td>Auxiliar:</td>
                <td>

                    <asp:DropDownList ID="ddlAuxiliar"  class="form-control" runat="server" DataTextField="nombre" DataValueField="rut_fun">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlAuxiliar" ErrorMessage="(*)Debe seleccionar un auxiliar" ForeColor="Red" ValidationGroup="vSesion"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblEsp" runat="server"></asp:Label>
                    </td>
                <td >
                    <asp:DropDownList ID="ddlFonoKine"  class="form-control" runat="server" DataTextField="nombre" DataValueField="rut_fun">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlFonoKine" ErrorMessage="(*)Debe seleccionar un especialista" ForeColor="Red" ValidationGroup="vSesion"></asp:RequiredFieldValidator>
                </td>
                <td ></td>
                <td >
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Crear Sesión" class="btnCrear" ValidationGroup="vSesion"/>
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
</asp:Content>
