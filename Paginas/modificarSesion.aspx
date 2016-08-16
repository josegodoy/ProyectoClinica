<%@ Page Title="" Language="C#" MasterPageFile="~/Enfermera.Master" AutoEventWireup="true" CodeBehind="modificarSesion.aspx.cs" Inherits="Paginas.modificarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  

  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True" ScriptMode="Release" ></asp:ScriptManager>

     <script language="JavaScript">



         function url() {

             hidden = open('insumos.aspx', 'NewWindow', 'top=0,left=0,width=800,height=600,status=yes,resizable=yes,scrollbars=yes');

         }

         function urlPaquete() {

             hidden = open('paqueteInsumos.aspx', 'NewWindow', 'top=0,left=0,width=600,height=400,status=yes,resizable=yes,scrollbars=yes');

         }

</script>

    <asp:UpdatePanel ID="p1" runat="server">
        <ContentTemplate>

            <table  class= "table table-striped table-bordered table-condense">
                <tr>
                    <td ></td>
                    <td ></td>
                    <td > Seleccione Box</td>
                    <td></td>
                </tr>
                <tr>
                    <td >Sesión Número:</td>
                    <td >
                        <asp:Label ID="lblId" runat="server"></asp:Label>
                    </td>
                    <td rowspan="22" >
                      
                        <asp:ImageButton ID="box1" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box1_Click" />
                       
                        
                        
                        <asp:ImageButton ID="box2" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box2_Click"/>
                           
                        
                        
                        <asp:ImageButton ID="box3" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box3_Click"/>
                          
                        
                        
                        <asp:ImageButton ID="box4" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box4_Click"/>
                   
                      
                        <br />  &nbsp;&nbsp;&nbsp; 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 4<br />
                    <br />
                        <asp:ImageButton ID="box5" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box5_Click"/>
                          
                          
                                                  
                        <asp:ImageButton ID="box6" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box6_Click"/>
                          
                        
                          
                        <asp:ImageButton ID="box7" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box7_Click"/>
                             
                        
                             
                        <asp:ImageButton ID="box8" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box8_Click"/>
                        
                         
                          
                        <br />
                         &nbsp;&nbsp;&nbsp; 5&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 6&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 7&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 8 <br /><asp:ImageButton ID="box9" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box9_Click"/>
                             
                        <asp:ImageButton ID="box10" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box10_Click"/>
                    
                        
                    
                        <asp:ImageButton ID="box11" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box11_Click"/>
                            
                        
                            
                        <asp:ImageButton ID="box12" runat="server" ImageUrl="Img/boxDisponible.png" OnClick="box12_Click"/>
                   
                        <br />
                        &nbsp;&nbsp;&nbsp; 9&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 10&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 11&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12  <br /> 
                        <img alt=""  src="Img/descripcionEstadoBox.png" />
                        
                             <br />
                   
                        </td>
                    <td>
                        <asp:Label ID="lblBox1" runat="server"></asp:Label>
                    </td>
                    
                </tr>
             
             
                
              
                <tr>
                    <td >Fecha Agenda:</td>
                    <td >
                        <asp:Label ID="lblFecha" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblBox2" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >Fecha Inicio:</td>
                    <td >
                        <asp:Label ID="lblFechaInicio" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblBox3" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td ></td>
                    <td>
                        <asp:Label ID="lblBox4" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >Fecha Fin:</td>
                    <td >
                        <asp:Label ID="lblFechaFin" runat="server"></asp:Label>
                    </td>
                    <td >
                        <asp:Label ID="lblBox5" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td ></td>
                    <td >
                        <asp:Label ID="lblBox6" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >Paciente:</td>
                    <td >
                        <asp:Label ID="lblPaciente" runat="server"></asp:Label>
                    </td>
                    <td >
                        <asp:Label ID="lblBox7" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td >
                        </td>
                    <td >
                        <asp:Label ID="lblBox8" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >Tratamiento</td>
                    <td >
                        <asp:Label ID="lblTratamiento" runat="server"></asp:Label>
                    </td>
                    <td >
                        <asp:Label ID="lblBox9" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td ></td>
                    <td >
                        <asp:Label ID="lblBox10" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >Box:</td>
                    <td >
                        <asp:Label ID="lblBox" runat="server"></asp:Label>
                    </td>
                    <td >
                        <asp:Label ID="lblBox11" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td ></td>
                    <td >
                        <asp:Label ID="lblBox12" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td ></td>
                    <td >
                        
                        <asp:Button ID="btnInsumo" runat="server" Text="Obtener Insumos" class="btnCrear" OnClick="btnInsumo_Click1"  />
                    </td>
                    <td></td>
                    
                </tr>
           
              
                
           
              
                <tr>
                    <td ></td>
                    <td >
                        <asp:Button ID="btnPaquete" runat="server" CssClass="btnCrear" OnClick="btnPaquete_Click" Text="Ver Paquete Insumos" />
                    </td>
                    <td>
                        <asp:Button ID="btnModificar" runat="server" class="btnBuscar" OnClick="btnModificar_Click" Text="Modificar" />
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
           
              
                
           
              
            </table>

            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
