<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CdVeiculo.aspx.cs" Inherits="ME_Ryan_Evaristo.CdVeiculo" %>

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
        <h1>Cadastro Veiculo</h1>
        <form id="form1" runat="server">

            
            <div class="form-outline mb-4">
                <asp:Label ID="tp_tranposte" runat="server" Text="Tipo de Transporte" CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="ddlTransporte" runat="server" CssClass="form-control">
                    <asp:ListItem>Selecione</asp:ListItem>
                    <asp:ListItem Value="C">Carro</asp:ListItem>
                    <asp:ListItem Value="V">Van</asp:ListItem>
                    <asp:ListItem Value="O">Ônibus</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="PLACA" runat="server" Text="Placa" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbPlaca" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="marca" runat="server" Text="Marca" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbMarca" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="modelo" runat="server" Text="Modelo" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbModelo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="ano" runat="server" Text="Ano" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbAno" runat="server" CssClass="form-control" type="number"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="capacidade" runat="server" Text="Capacidade" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbCapacidade" runat="server" CssClass="form-control" type="number"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="CPF_MOT" runat="server" Text="CPF do Motorista" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbCpfMotorista" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
    
            <div class="mt-sm-4">
                <asp:Button ID="btnCdVeiculo" runat="server"  Text="Cadastrar" OnClick="btnCdVeiculo_Click" CssClass="btn btn-primary btn-md" />
            </div>
           </form>
  </div>
</body>
</html>
