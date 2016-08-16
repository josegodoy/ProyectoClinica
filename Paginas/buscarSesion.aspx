<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="buscarSesion.aspx.cs" Inherits="Paginas.buscarSesion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>
    
    <asp:UpdatePanel ID="panel1" runat="server">
        <ContentTemplate>

    <table style="width:100%; height: 23px;">
     
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Desde :<asp:TextBox ID="txtFechaInicio" runat="server"></asp:TextBox>
                <cc1:calendarextender id="CalendarExtender1" runat="server" targetcontrolid="txtFechaInicio" FirstDayOfWeek="Monday" ></cc1:calendarextender>

            </td>
            <td>Hasta :<asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox>
                <cc1:calendarextender id="CalendarExtender2" runat="server" targetcontrolid="txtFechaFin" FirstDayOfWeek="Monday" ></cc1:calendarextender>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Tipo :
                <asp:RadioButton ID="cboFono" runat="server" Text="Fonoaudiología" GroupName="tratamiento" />
            </td>
            <td>
                <asp:RadioButton ID="cboKine" runat="server" Text="Kinesiología" GroupName="tratamiento" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" CssClass="btnBuscar"  Text="Buscar" OnClick="btnBuscar_Click" />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <table style="width: 918px">
        <tr>
            <td class="auto-style1">

                &nbsp;</td>

            <td>

                <asp:GridView ID="gdvLista" runat="server"  DataKeyNames="id_atencion" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"   OnRowCommand="gdvLista_RowCommand" CssClass= "table table-striped table-bordered table-condense" OnSelectedIndexChanged="gdvLista_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="id_atencion" HeaderText="ID" SortExpression="id_atencion" />
                        <asp:BoundField DataField="fecha_agendamiento" HeaderText="F.Agendamiento" SortExpression="fecha_agendamiento" />
                        <asp:BoundField DataField="hora_agendamiento" HeaderText="H.Agendamiento" SortExpression="hora_agendamiento" />
                        <asp:BoundField DataField="rut" HeaderText="Rut Paciente" SortExpression="rut" />
                        <asp:BoundField DataField="nombre_paciente" HeaderText="Nombre Paciente" SortExpression="nombre_paciente" />
                        <asp:BoundField DataField="fecha_inicio" HeaderText="F.Sesión" SortExpression="fecha_inicio" />
                        <asp:BoundField DataField="hora" HeaderText="H.Sesión" SortExpression="hora" />
                        <asp:BoundField DataField="tratamiento" HeaderText="Tipo Tratamiento" SortExpression="tratamiento" />
                        <asp:HyperLinkField HeaderText ="Modificar" DataNavigateUrlFormatString="modificarSesion.aspx?id={0}#top" DataNavigateUrlFields="id_atencion" Text="Modificar" />
                        
                        <%--<asp:HyperLinkField HeaderText="Extender" DataNavigateUrlFields="id_atencion" Text="Extender" />--%>
                        <asp:HyperLinkField HeaderText ="Extender" DataNavigateUrlFormatString="extenderSesion.aspx?id={0}#top" DataNavigateUrlFields="id_atencion" Text="Extender" />
                        
                        <asp:TemplateField HeaderText="Finalizar" ShowHeader="False"  >
                                   <ItemTemplate>
                                       <asp:LinkButton ID="LinkButton1"  runat="server" CommandName="Finalizar" CausesValidation="False" Text="Finalizar" OnClientClick="return confirm('Desea Finalizar la sesión?')"></asp:LinkButton>
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
            </td>

            <td>

                &nbsp;</td>

        </tr>
        
          

    </table>
            </ContentTemplate>
    </asp:UpdatePanel>
         <asp:UpdateProgress ID="ppp1" runat ="server" AssociatedUpdatePanelID="panel1">

        <ProgressTemplate>
            <div id="overlay">
                <div id="modalProgress"></div>
                <div id="theprogress">
                    <img alt="indicator" src="Img/loading.gif" />
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress> 
</asp:Content>
