<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Paginas.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="css/estilos.css"  type="text/css"/>
    <title></title>
</head>
<body>
    <div id="wrapper">
       <div id="top">

       </div>

        <header>
    <br/>
    <br/>

      <h1>Clínica de Rehabilitación EduDown</h1>
      <h2>Sistema para Funcionarios</h2>


  </header>

    <nav>


  </nav>

       <article>
<div id="login">
  <form id="Form1" runat="server">
    <label for="nombre">Nombre de Usuario</label>
      <asp:TextBox ID="txtNombreLogg" class="form-control" runat="server"></asp:TextBox>

    <label for="pass">Contraseña:</label>
      <asp:TextBox ID="TxtPassLogg" TextMode="Password"  class="form-control" runat="server"></asp:TextBox>
     
 <asp:Button ID="BtnAcceder" runat="server"   Text="Acceder" OnClick="BtnAcceder_Click" class="btn primary-primary"  />
      <br />
      
      <br />
      
      <asp:Label ID="lblMsj" runat="server" ForeColor="Red" ></asp:Label>
      <br />
      
  </form>
</div>


       </article>

       <footer>

       </footer>

   </div>
</body>
</html>
