<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tarea_8.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-2.2.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    </style>
</head>
<body>
     
    <form id="form1" runat="server">
    <div>
        <center>
             <div class ="container">
                <div class="row">
                    <div class="btn-group">
                        <div class ="col-md-6">
                            Nombre 
                        </div>
                        <div class ="col-md-6">
                            <asp:TextBox ID="UsuarioTextBox" CssClass="form-control" Height="40"  width="200px" runat="server"></asp:TextBox>
                        </div>
               </div>
                    </div>
                        </div>
                <br />
                <div class="container">
                    <div class ="row">
                        <div class="btn-group">
                            <div class="col-md-6">
                                Contrasena
                            </div>
                            <div class="col-md-6">
                                <asp:TextBox ID="ContrasenaTextBox" CssClass="form-control" Height="40"  width="200px" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
               </div>
                    </div>
                        </div>
                             <br />
                <br />
    
                <div class="container">
                    <div class="row">
                        <div class="btn-group">
                            <div class="col-md-4">
                                <asp:Button ID="InicioButton" runat="server" OnClick="InicioButton_Click" Height="35px" width="100px" Text="Inicio" CssClass="btn btn-primary" />
                             </div>
                            <div class="col-md-4">
                                <asp:Button ID="CancelarButton" runat="server" OnClick="CancelarButton_Click" Height="35px" width="100px" style="margin-left: 15px" Text="Cancelar" CssClass="btn btn-primary"/>
                            </div>
                            <div class="col-md-4">
                                <asp:Label ID="ErrorLabel" style="margin-left : 15px " runat="server"></asp:Label>
                            </div>
                </div>
                    </div>
                        </div>
        </center>
   </div>
   </form>
</body>
</html>
