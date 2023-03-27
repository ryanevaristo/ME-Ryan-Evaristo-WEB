<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroTransporte.aspx.cs" Inherits="ME_Ryan_Evaristo.RegistroTransporte" %>

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
        <h1>Registro do Transporte</h1>
        <form id="form1" runat="server">

            
            <div class="form-outline mb-4">
                <asp:Label ID="PlacaVeiculo" runat="server" Text="Placa do Veiculo" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbPlacaVeiculo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="CPFPassageiro" runat="server" Text="CPF do Passageiro" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbCPFPassageiro" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="dataTransporte" runat="server" Text="Data e Hora da Viagem" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbDataTransporte" runat="server" CssClass="form-control" type="datetime-local"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="KmTotal" runat="server" Text="Km Rodados" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbKmTotal" runat="server" CssClass="form-control" type="number"></asp:TextBox>
            </div>

    
            <div class="mt-sm-4">
                <asp:Button ID="btnRegistro" runat="server"  Text="Cadastrar" OnClick="btnRegistro_Click" CssClass="btn btn-primary btn-md" />
            </div>
           </form>
  </div>
</body>
</html>
