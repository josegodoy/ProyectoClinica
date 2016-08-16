<%@ Page Title="" Language="C#" MasterPageFile="~/AdmCentro.Master" AutoEventWireup="true" CodeBehind="centroListarMedicos.aspx.cs" Inherits="Paginas.centroListarMedicos" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    <table align="center">
        <tr>
            <td ></td>
            <td ><strong>Lista de Equipos Médicos</strong></td>
            <td></td>
        </tr>
        <tr>
            <td >Seleccione Fecha:</td>
            <td >
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                <cc1:calendarextender id="CalendarExtender1" runat="server" targetcontrolid="txtFecha" FirstDayOfWeek="Monday" ></cc1:calendarextender>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" CssClass="btnBuscar" Text="Buscar" OnClick="btnListar_Click"/>
            </td>
        </tr>
        <tr>
            <td ></td>
            <td >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecha" ErrorMessage="(*)Inserte una fecha" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td></td>
        </tr>
    </table>

  
    
    <table style="width: 100%;">
        <tr>
            <td ></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td ></td>
            <td>
                <asp:GridView ID="gdvListar" runat="server" BackColor="White" AutoGenerateColumns="False" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" CssClass= "table table-striped table-bordered table-condense">
                    <Columns>
                        <asp:BoundField DataField="ID_ATENCION" HeaderText="No.Atención" SortExpression="ID_ATENCION" />
                        <asp:BoundField DataField="rut_funcionario" HeaderText="Rut" SortExpression="rut_funcionario" />
                        <asp:BoundField DataField="NOMBRE_FUN" HeaderText="Nombre" SortExpression="NOMBRE_FUN" />
                        <asp:BoundField DataField="APATERNO_FUN" HeaderText="Apellido" SortExpression="APATERNO_FUN" />
                        <asp:BoundField DataField="NOMBRE_CARGO" HeaderText="Cargo" SortExpression="NOMBRE_CARGO" />   
                        <asp:BoundField DataField="FechaAgendamiento" HeaderText="Fecha Agendamiento" SortExpression="FechaAgendamiento" />   
                                                 
                    </Columns>          
                     <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                               <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                               <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                               <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                               <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                               <SortedAscendingCellStyle BackColor="#F1F1F1" />
                               <SortedAscendingHeaderStyle BackColor="#594B9C" />
                               <SortedDescendingCellStyle BackColor="#CAC9C9" />
                               <SortedDescendingHeaderStyle BackColor="#33276A" />
                           </asp:GridView>
            </td>
            <td></td>
        </tr>
        <tr>
            <td ></td>
            <td>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
