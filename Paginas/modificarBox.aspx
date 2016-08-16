<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="modificarBox.aspx.cs" Inherits="Paginas.modificarBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table align="center">
    <tr>
       
        <td align="center"><strong>Lista Box de Atención</strong></td>
       
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gdvLista" runat="server" BackColor="White" AutoGenerateColumns="false" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" CssClass= "table table-striped table-bordered table-condense">
               <Columns>
                       <asp:BoundField DataField="id_box" HeaderText="ID" SortExpression="id_box" />
                        <asp:BoundField DataField="nombre_tipo" HeaderText="Tipo" SortExpression="nombre_tipo" />
                        <asp:BoundField DataField="tamano" HeaderText="Tamaño" SortExpression="tamano" />
                        <asp:BoundField DataField="estado" HeaderText="Estado Actual" SortExpression="estado" />
                   <asp:HyperLinkField HeaderText ="Modificar" DataNavigateUrlFormatString="modificarBoxEnfermera.aspx?id={0}#top" DataNavigateUrlFields="id_box" Text="Modificar" />

               </Columns>
                 <AlternatingRowStyle BackColor="#DCDCDC" />
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
        </td>
        </tr>
            <tr>
        <td align="center">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>
    </table>
</asp:Content>
