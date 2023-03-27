<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ME_Ryan_Evaristo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .container{
            max-width: 60rem;
            height: 100%;
            max-height: 20rem;
            margin-top: 5%;
            background-color: #edeaeaff;
            padding: 2rem;
            border-radius: 1rem;
        }
        body {
            background-color: #2a4be6;
            background-repeat:no-repeat;
            background-attachment:fixed;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="background-color: antiquewhite">
            <h1>Bem vindo ao sistema :)</h1>
            <ul class="nav">
                  <li class="nav-item">
                    <a class="nav-link active" href="CdPassageiro.aspx">Cadastrar Passageiros</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="CdMotorista.aspx">Cadastrar Motoristas</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="CdVeiculo.aspx">Cadastrar Veiculo</a>
                  </li>
                <li class="nav-item">
                    <a class="nav-link" href="RegistroTransporte.aspx">Registro de Transporte</a>
                  </li>
                <li class="nav-item">
                    <a class="nav-link" href="CdVeiculo.aspx">Relatório Financeiro</a>
                  </li>
                <li class="nav-item">
                    <a class="nav-link" href="ViewRegistroTransporte.aspx">Consulta Registro Transporte</a>
                  </li>
                
             </ul>
        </div>
    </form>
</body>
</html>
