<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"  Inherits="ME_Ryan_Evaristo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Content/Bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        body {
            background-color: #2a4be6;
            background-repeat:no-repeat;
            background-attachment:fixed;
        }
        .form-signin {
            max-width: 500px;
            margin: auto;
            margin-top: 5%;
            background-color: #edeaeaff;
            padding: 2rem;
            border-radius: 1rem;
        }
        
    </style>
</head>


<body>
  <div class="form-signin">
      <form id="form1" runat="server">
          <div class="form-outline mb-4">
              <asp:Label ID="Label1" runat="server" Text="Login" CssClass="form-label"></asp:Label>
              <asp:TextBox ID="TbLogin" runat="server" CssClass="form-control" type="email"></asp:TextBox>
         </div>

          <div class="form-outline mb-4">
              <asp:Label ID="Senha" runat="server" Text="Senha" CssClass="form-label"></asp:Label>
              <asp:TextBox ID="TbSenha" runat="server" CssClass="form-control" type="password"></asp:TextBox>
          </div>
    

  <div class="row mb-4">
    <div class="col d-flex justify-content-center">
        </div>
      </div>
        <div class="mt-sm-4">
            <asp:Button ID="btnLogin" runat="server"  Text="Entrar" CssClass="btn btn-success btn-md" OnClick="btnLogin_Click"/>
            <asp:Button ID="btnCadastro" runat="server"  Text="Registre-se" CssClass="btn btn-primary btn-md" OnClick="btnCadastro_Click"/>
        </div>
</form>
  </div>
</body>
</html>
