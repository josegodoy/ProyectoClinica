<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="buscarPaciente.aspx.cs" Inherits="Paginas.buscarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
           <table align="center">
               <tr>
                   <td ></td>
                   <td align="center"><strong>Buscar Paciente</strong></td>
                   <td ></td>
               </tr>
               <tr>
             
               </tr>
               <tr>
                   <td > Rut:</td>
                   <td >
                       <asp:TextBox ID="txtRut"  runat="server" Width="184px"></asp:TextBox>
                   </td>
                   <td>
                       <asp:Button ID="Button1" CssClass="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRut" ErrorMessage="Ingrese Rut" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
                   <td>
                       </td>
               </tr>
               </table>

               <br />
                
               <table>
                   <tr>
                       <td>
                <asp:GridView ID="gvLista" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="RUT_PACIENTE" GridLines="Vertical" class= "table table-striped table-bordered table-condense" OnRowDeleting="gvLista_RowDeleting1">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="RUT_PACIENTE" HeaderText="RUT" ReadOnly="True" SortExpression="RUT_PACIENTE" />
                        <asp:BoundField DataField="DV_RUT_PACIENTE" HeaderText="DV" SortExpression="DV_RUT_PACIENTE" />
                        <asp:BoundField DataField="NOMBRE_PACIENTE" HeaderText="NOMBRE" SortExpression="NOMBRE_PACIENTE" />
                        <asp:BoundField DataField="APATERNO_PACIENTE" HeaderText="Apellido Paterno" SortExpression="APATERNO_PACIENTE" />
                        <asp:BoundField DataField="AMATERNO_PACIENTE" HeaderText="Apellido Materno" SortExpression="AMATERNO_PACIENTE" />
                        <asp:BoundField DataField="FECHA_NACIMIENTO" HeaderText="FECHA NACIMIENTO" SortExpression="FECHA_NACIMIENTO" />
                        <asp:BoundField DataField="DIRECCION_PACIENTE" HeaderText="DIRECCION" SortExpression="DIRECCION_PACIENTE" />
                        <asp:BoundField DataField="FONO_PACIENTE" HeaderText="FONO" SortExpression="FONO_PACIENTE" />
                        <asp:BoundField DataField="CANTIDAD_SESIONES" HeaderText="CANTIDAD SESIONES" SortExpression="CANTIDAD_SESIONES" />
                        <asp:BoundField DataField="SESIONES_FINALIZADAS" HeaderText="SESIONES FINALIZADAS" SortExpression="SESIONES_FINALIZADAS" />
                        <asp:BoundField DataField="NOMBRE" HeaderText="ETAPA" SortExpression="NOMBRE" />
                        <asp:HyperLinkField HeaderText ="Modificar" DataNavigateUrlFormatString="modificarPaciente.aspx?id={0}#top" DataNavigateUrlFields="rut_paciente" Text="Modificar" />
                         

                    
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;PACIENTE&quot;"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
     
</asp:Content>
