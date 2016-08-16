<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="extenderSesion.aspx.cs" Inherits="Paginas.extenderSesion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap.min.js"></script>
    
    <link href="dist/bootstrap-clockpicker.min.css" rel="stylesheet" />
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/highlight.min.js"></script>
    <script src="dist/jquery-clockpicker.min.js"></script> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

      

</head>
<body>
   
 
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    <div>
    
        <table>
            <tr>
                <td ></td>
                <td >Extender Sesión Número :<asp:Label ID="lblId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >Fecha Extensión:</td>
                <td >
                    <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                    <cc1:calendarextender id="CalendarExtender1" runat="server" targetcontrolid="txtFecha" FirstDayOfWeek="Monday" ></cc1:calendarextender>
                
                </td>
            </tr>
            <tr>
                <td >Hora Extensión:</td>

                <td >
                   
              
                   <asp:TextBox class ="input-group clockpicker" data-placement="bottom" data-alignment ="left" data-donetext="Aceptar"
                        ID="txtHoraExtension"  runat="server"></asp:TextBox>
            
            <script type ="text/javascript">
                $('.clockpicker').clockpicker();
    </script>
                </td>


            
            </tr>
            <tr>
                <td ></td>

                <td >
                                                            </td>
            </tr>
            <tr>
                <td ></td>

                <td >
                                                            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                                                            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
