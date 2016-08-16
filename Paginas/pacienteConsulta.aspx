<%@ Page Title="" Language="C#" MasterPageFile="~/Paciente.Master" AutoEventWireup="true" CodeBehind="pacienteConsulta.aspx.cs" Inherits="Paginas.pacienteConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Seleccione una sede:</td>
            <td>
                <asp:DropDownList ID="ddlCentro" runat="server" class="form-control" DataTextField="nombre_centro" DataValueField="id_centro" AutoPostBack="True" OnSelectedIndexChanged="ddlCentro_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Médicos:</td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlMedicos" runat="server" class="form-control" DataTextField="nombre" DataValueField="rut">
        </asp:DropDownList></td>
            <td><asp:Button ID="btnMedicos" runat="server" CssClass="btnCrear" OnClick="btnMedicos_Click" Text="Informacion" /></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Kinesiólogos</td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="ddlKine" runat="server" class="form-control" DataTextField="nombre" DataValueField="rut">
                </asp:DropDownList></td>
            <td><asp:Button ID="btnKine" runat="server" OnClick="btnKine_Click" Text="Informacion" CssClass="btnCrear" /></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Fonoaudiólogos</td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:DropDownList ID="dllFono" runat="server" class="form-control" DataTextField="nombre" DataValueField="RUT">
        </asp:DropDownList>
        </td>
            <td><asp:Button ID="btnFono" runat="server" OnClick="btnFono_Click" Text="Informacion" Cssclass="btnCrear" /></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="lblPrueba" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gdvListaMedicos" runat="server" CssClass= "table table-striped table-bordered table-condense" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                        <asp:BoundField DataField="horario" HeaderText="Horario" SortExpression="horario" />
                        <asp:BoundField DataField="fono_centro" HeaderText="Fono Centro" SortExpression="fono_centro" />
                        <asp:BoundField DataField="nombre_estado" HeaderText="Estado" SortExpression="nombre_estado" />
                        
              
                        

                    </Columns>
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
