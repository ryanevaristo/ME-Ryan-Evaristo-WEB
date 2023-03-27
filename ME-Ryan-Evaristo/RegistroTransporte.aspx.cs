using ME_Ryan_Evaristo.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ME_Ryan_Evaristo
{
    public partial class RegistroTransporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.PlacaVeiculo = TbPlacaVeiculo.Text;
            registro.CpfPassageiro = TbCPFPassageiro.Text;
            registro.DataTransporte = DateTime.Parse(TbDataTransporte.Text);
            registro.Hora = registro.DataTransporte.ToShortTimeString();
            registro.KmTotais = int.Parse(TbKmTotal.Text);
            registro.Total();
            ArrayList registros;
            ArrayList passageiros;
            ArrayList veiculos;
            if (Session["registros"] != null)
            {
                registros = (ArrayList)(Session["registros"]);
                veiculos = (ArrayList)(Session["veiculos"]);
                passageiros = (ArrayList)(Session["passageiros"]);

                foreach (Passageiro cpf in passageiros)
                {
                    foreach (Veiculo placaV in veiculos)
                    {
                        if (!cpf.Cpf.Equals(TbCPFPassageiro.Text))
                        {

                            Response.Write("<script>alert('Esse Passageiro não existe!')</script>");
                        } 
                        else if (!placaV.Placa.Equals(TbPlacaVeiculo.Text)) {
                            Response.Write("<script>alert('Essa Placa não existe!')</script>");
                        }
                        else
                        {
                            registros.Add(registro);
                            Session["registros"] = registros;
                            string url = "Home.aspx";
                            Response.Redirect(url);
                        }

                    }
                    


                }

            }
            else
            {
                veiculos = (ArrayList)(Session["veiculos"]);
                passageiros = (ArrayList)(Session["passageiros"]);
                if (passageiros != null && veiculos != null)
                {
                    foreach (Passageiro cpf in passageiros)
                    {
                        foreach (Veiculo placaV in veiculos)
                        {
                            if (!cpf.Cpf.Equals(TbCPFPassageiro.Text))
                            {

                                Response.Write("<script>alert('Esse Passageiro não existe!')</script>");
                            }
                            else if (!placaV.Placa.Equals(TbPlacaVeiculo.Text))
                            {
                                Response.Write("<script>alert('Essa Placa não existe!')</script>");
                            }
                            else
                            {
                                registros = new ArrayList();
                                registros.Add(registro);
                                Session["registros"] = registros;
                                string url = "Home.aspx";
                                Response.Redirect(url);
                            }

                        }



                    }

                }else
                {
                    Response.Write("<script>alert('Cadastre um Passageiro e um Veiculo')</script>");
                }

            }

        }
    }
}