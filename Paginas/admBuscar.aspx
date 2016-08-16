<%@ Page Title="" Language="C#" MasterPageFile="~/admIns.Master" AutoEventWireup="true" CodeBehind="admBuscar.aspx.cs" Inherits="Paginas.admBuscar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/estilos2.css"  type="text/css"/>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 
           <table align="center">
               <tr>
                   <td ></td>
                   <td > <strong>Buscar Funcionario</strong></td>
                   <td class="auto-style7"></td>
               </tr>
               <tr>
                   <td >Rut:</td>
                   <td >
                       <asp:TextBox ID="txtRutBuscar"  class="form-control" runat="server" Width="184px" ></asp:TextBox>
                   </td>
                   <td>
                       <asp:Button CssClass="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                   </td>
               </tr>
               <tr>
                   <td ></td>
                   <td >Escribir rut sin código verificador
                   </td>
                   <td>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRutBuscar" ErrorMessage="Ingrese Rut" ForeColor="Red"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               </table>

             

                
               <table>
                
                   <tr>
                       <td>
                            <asp:GridView ID="gdvLista" runat="server" AutoGenerateColumns="False" DataKeyNames="RUT_FUN" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowDeleting="gdvLista_RowDeleting" CssClass= "table table-striped table-bordered table-condense">
                                <AlternatingRowStyle BackColor="#DCDCDC" />
                           <Columns>
                               <asp:BoundField DataField="RUT_FUN" HeaderText="RUT" SortExpression="RUT_FUN" />
                               <asp:BoundField DataField="DV_RUT_FUN" HeaderText="DV" SortExpression="DV_RUT_FUN" />
                               <asp:BoundField DataField="NOMBRE_FUN" HeaderText="NOMBRE" SortExpression="NOMBRE_FUN" />
                               <asp:BoundField DataField="APATERNO_FUN" HeaderText="A.PATERNO" SortExpression="APATERNO_FUN" />
                               <asp:BoundField DataField="AMATERNO_FUN" HeaderText="A.MATERNO" SortExpression="AMATERNO_FUN" />
                               <asp:BoundField DataField="NOMBRE_CARGO" HeaderText="CARGO" SortExpression="NOMBRE_CARGO" />
                               <asp:BoundField DataField="NOMBRE_CENTRO" HeaderText="CENTRO" SortExpression="NOMBRE_CENTRO" />
                               <asp:BoundField DataField="FONO_FUNCIONARIO" HeaderText="TELEFONO" SortExpression="FONO_FUNCIONARIO" />
                               <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                               <asp:BoundField DataField="DIRECCION_FUNCIONARIO" HeaderText="DIRECCION" SortExpression="DIRECCION_FUNCIONARIO" />
                               <asp:BoundField DataField="NOMBRE_ESTADO" HeaderText="ESTADO" SortExpression="NOMBRE_ESTADO" />
                               <asp:HyperLinkField HeaderText ="Modificar" DataNavigateUrlFormatString="admEditar.aspx?id={0}#top" DataNavigateUrlFields="rut_fun" Text="Modificar" />

                               <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" OnClientClick="return confirm('Deseas eliminar al Funcionario?')"></asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>

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
                           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;ADMINISTRADORESSEDE&quot;"></asp:SqlDataSource>
                       </td>
                   </tr>
                   <tr>
                       <td>
                            
                            <asp:Label ID="lblMen" runat="server" ForeColor="Blue"></asp:Label>
                       </td>
                   </tr>
               </table>

       
</asp:Content>
