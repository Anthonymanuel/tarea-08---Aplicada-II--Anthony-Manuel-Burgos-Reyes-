<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosWeb.aspx.cs" Inherits="Tarea_8.UsuariosWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-2.2.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
        <center>
            <div class="container">
                <div class="row">
                    <div class="btn-group">
                        <div class="col-md-6">
                            <asp:Label ID="Label1" runat="server" Text="Nombre Usuario:"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="NombreUsuarioTextBox" CssClass="form-control" Height="40px" Width="200px" runat="server"></asp:TextBox>
                         </div>
                        </div>
                    </div>
                </div>
            <br />
            <div class="container">
                <div class="row">
                    <div class="btn-group">
                        <div class="col-md-6">
                            <asp:Label ID="Label2" runat="server" Text="Contrasena"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="ContrasenaTextBox" CssClass="form-control" Height="40px" Width="200px" runat="server" TextMode="Password"></asp:TextBox>  
                        </div>
                    </div>
                  </div>
               </div>
                      
            <br />
            <div class="container">
                <div class="row">
                    <div class="btn-group">
                        <div class="col-md-6">
                            <asp:Label ID="Label3" runat="server" Text="Confirmar contrasena"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="ConfirmarContrasenaTextBox"  CssClass="form-control" Height="40px" Width="200px" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        </div>
                    </div>
                </div>
            <br />
            <br />
            <div class="container">
                <div class="row">
                    <div class="btn-group">
                        <div class="col-md-6">
                            <asp:Button ID="RegistrarButton" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="RegistrarButton_Click" Height="35px" Width="100px" />
                        </div>
                        <div class="col-md-6">
                             <asp:Button ID="CancelarButton" runat="server" style="margin-left: 15px " CssClass="btn btn-primary" Text="Cancelar" OnClick="CancelarButton_Click" Height="35px" Width="100px"/>
                        </div>
                       </div>
                    </div>
                </div>
        </center>
    </form>
</body>
</html>
