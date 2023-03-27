using ME_Ryan_Evaristo.Classes;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ME_Ryan_Evaristo
{
    public partial class CdVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCdVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.TpTransporte = ddlTransporte.SelectedIndex.ToString();
            veiculo.Placa = TbPlaca.Text;
            veiculo.Marca = TbMarca.Text;
            veiculo.Modelo = TbModelo.Text;
            veiculo.Ano = int.Parse(TbAno.Text);
            veiculo.Capacidade = int.Parse(TbCapacidade.Text);
            veiculo.CpfMotorista = TbCpfMotorista.Text;

            ArrayList veiculos;
            ArrayList motoristas;
            if (Session["veiculos"] != null)
            {
                veiculos = (ArrayList)(Session["veiculos"]);
                foreach (Veiculo placa in veiculos)
                {
                    if (placa.Placa.Equals(TbPlaca.Text))
                    {
                        Response.Write("<script>alert('Essa Placa já existe!')</script>");
                    }
                    else
                    {
                        veiculos.Add(veiculo);
                        Session["veiculos"] = veiculos;
                        string url = "Home.aspx";
                        Response.Redirect(url);
                    }


                }
            }
            else
            {
                motoristas = (ArrayList)(Session["motoristas"]);
                if (motoristas != null )
                {
                    foreach (Pessoa cpf in motoristas)
                    {
                       
                        if (!cpf.Cpf.Equals(TbCpfMotorista.Text))
                        {

                            Response.Write("<script>alert('Esse Motorista não existe!')</script>");
                        }
                       
                        else
                        {
                            veiculos = new ArrayList();
                            veiculos.Add(veiculo);
                            Session["veiculos"] = veiculos;
                            string url = "Home.aspx";
                            Response.Redirect(url);
                        }

                        



                    }

                }
                else
                {
                    Response.Write("<script>alert('Cadastre um Motorista primeiro')</script>");
                }
            }
        }
    }
}