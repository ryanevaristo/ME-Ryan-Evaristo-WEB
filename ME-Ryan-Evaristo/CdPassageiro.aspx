<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CdPassageiro.aspx.cs" Inherits="ME_Ryan_Evaristo.CdPassageiro" %>

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
        <h1>Cadastro do Passageiro</h1>
        <form id="form1" runat="server">

            
            <div class="form-outline mb-4">
                <asp:Label ID="Nome" runat="server" Text="Nome" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbNome" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="CPF" runat="server" Text="CPF" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbCPF" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="dataNasc" runat="server" Text="Data Nascimento" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbDtNasc" runat="server" CssClass="form-control" type="date"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="endereco" runat="server" Text="Endereço" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbEndereco" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="cidade" runat="server" Text="Cidade" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbCidade" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
                <asp:Label ID="uf" runat="server" Text="UF" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TbUf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
    
            <div class="mt-sm-4">
                <asp:Button ID="btnCdPassageiro" runat="server" OnClick="btnCdPassageiro_Click" Text="Cadastrar" CssClass="btn btn-primary btn-md" />
            </div>
           </form>
  </div>
</body>
</html>
