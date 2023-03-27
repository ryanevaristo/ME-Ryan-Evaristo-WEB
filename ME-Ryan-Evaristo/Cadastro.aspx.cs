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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Email = TbEmail.Text;
            user.Cpf = TbCPF.Text;
            user.Nome = TbNome.Text;
            user.Endereco = TbEndereco.Text;
            user.DataNasci = DateTime.Parse(TbDtNasc.Text);
            user.Senha = TbSenha.Text;
            ArrayList array;
            ArrayList cpfList;
            if (Session["array"] != null)
            {
                cpfList = (ArrayList)(Session["cpfList"]);
                array = (ArrayList)(Session["array"]);
                foreach (string usuario in cpfList)
                {
                    if (usuario.Equals(TbCPF.Text))
                    {
                        
                        Response.Write("<script>alert('Esse CPF já existe!')</script>");
                    }
                    else
                    {
                        cpfList.Add(TbCPF.Text);
                        array.Add(user);
                        Session["array"] = array;
                        Session["cpfList"] = cpfList;
                        string url = "Login.aspx";
                        Response.Redirect(url);
                    }


                }

            }
            else
            {
                array = new ArrayList();
                cpfList = new ArrayList();
                cpfList.Add(TbCPF.Text);
                array.Add(user);
                Session["cpfList"] = cpfList;
                Session["array"] = array;
                string url = "Login.aspx";
                Response.Redirect(url);

            }
            

        }
    }
}