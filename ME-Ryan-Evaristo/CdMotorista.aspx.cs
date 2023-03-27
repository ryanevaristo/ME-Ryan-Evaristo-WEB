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
    public partial class CdMotorista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCdMotorista_Click(object sender, EventArgs e)
        {
            Pessoa motorista = new Pessoa();
            motorista.Nome = TbNome.Text;
            motorista.Cpf = TbCPF.Text;
            motorista.Endereco = TbEndereco.Text;
            motorista.DataNasci = DateTime.Parse(TbDtNasc.Text);
            ArrayList motoristas;
            ArrayList cpfList;
            if (Session["motoristas"] != null)
            {

                motoristas = (ArrayList)(Session["motoristas"]);
                cpfList = (ArrayList)(Session["cpfList"]);

                foreach (Pessoa cpf in motoristas)
                {
                    if (cpf.Cpf.Equals(TbCPF.Text))
                    {

                        Response.Write("<script>alert('Esse CPF já existe!')</script>");
                    }
                    else
                    {
                        motoristas.Add(motorista);
                        cpfList.Add(TbCPF.Text);
                        Session["motoristas"] = motoristas;
                        Session["cpfList"] = cpfList;
                        string url = "Home.aspx";
                        Response.Redirect(url);
                    }


                }

            }
            else
            {

                cpfList = (ArrayList)(Session["cpfList"]);
                motoristas = new ArrayList();
                motoristas.Add(motorista);
                Session["motoristas"] = motoristas;
                string url = "Home.aspx";
                Response.Redirect(url);



            }
        }
    }
}