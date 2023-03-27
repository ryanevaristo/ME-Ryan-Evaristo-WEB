<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRegistroTransporte.aspx.cs" Inherits="ME_Ryan_Evaristo.ViewRegistroTransporte" %>

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
        .container {
            justify-content: space-around;
            margin: auto;
            margin-top: 5%;
            background-color: #edeaeaff;
            padding: 2rem;
            border-radius: 1rem;
        }

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <% ArrayList transportes = (ArrayList)Session["registros"];%>

            <%
                if(transportes == null)
                    
                {%>

                <h1> Não Existe nenhum Registro</h1>

                <% } 
                else 
                {
                %>
                <% foreach (ME_Ryan_Evaristo.Classes.Registro transporte in transportes) { %>
              
            <table class="table">
                  <thead>
                    <tr>
                      <th scope="col">Placa do Veiculo</th>
                      <th scope="col">Cpf do Passageiro</th>
                      <th scope="col">Data do Transporte</th>
                      <th scope="col">Hora </th>
                      <th scope="col">Total de KM </th>
                       <th scope="col">Valor Total </th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      
                        <td><%= transporte.PlacaVeiculo %></td>
                        <td><%= transporte.CpfPassageiro %></td>
                        <td><%= transporte.DataTransporte.ToShortDateString() %></td>
                        <td><%= transporte.Hora %></td>
                        <td><%= transporte.KmTotais %></td>
                        <td><%= "R" +transporte.ValorTotal.ToString("C") %></td>
                    </tr>
                    
                  </tbody>
              </table>
            <% } %>
                <% } %>

        </div>
    </form>
</body>
</html>
