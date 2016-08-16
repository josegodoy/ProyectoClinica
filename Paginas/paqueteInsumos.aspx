<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paqueteInsumos.aspx.cs" Inherits="Paginas.paqueteInsumos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gdvLista" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id_insumo" HeaderText="ID" SortExpression="id_insumo" />
                <asp:BoundField DataField="nombre_insumo" HeaderText="Insumo" SortExpression="nombre_insumo" />
                  <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />                        
            </Columns>
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
