using ME_Ryan_Evaristo.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ME_Ryan_Evaristo
{
    public partial class CdPassageiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCdPassageiro_Click(object sender, EventArgs e)
        {
            Passageiro psg = new Passageiro();
            psg.Nome = TbNome.Text;
            psg.Cpf = TbCPF.Text;
            psg.DataNasci = DateTime.Parse( TbDtNasc.Text );
            psg.Endereco = TbEndereco.Text;
            psg.Cidade = TbCidade.Text;
            psg.Uf = TbUf.Text;
            ArrayList passageiros;
            ArrayList cpfList;
            if (Session["passageiros"] != null)
            {
                cpfList = (ArrayList)(Session["cpfList"]);
                passageiros = (ArrayList)(Session["passageiros"]);
                
                foreach (Passageiro cpf in passageiros)
                {
                    if (cpf.Cpf.Equals(TbCPF.Text))
                    {

                        Response.Write("<script>alert('Esse CPF já existe!')</script>");
                    }
                    else
                    {
                        passageiros.Add(psg);
                        cpfList.Add(TbCPF.Text);
                        Session["passageiros"] = passageiros;
                        Session["cpfList"] = cpfList;
                        string url = "Home.aspx";
                        Response.Redirect(url);
                    }


                }

            }
            else
            {

                cpfList = (ArrayList)(Session["cpfList"]);
                passageiros = new ArrayList();
                passageiros.Add(psg);
                Session["passageiros"] = passageiros;
                string url = "Home.aspx";
                Response.Redirect(url);
            
                

            }

        }
    }
}