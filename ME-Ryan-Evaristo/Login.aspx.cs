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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ArrayList array;
            if (Session["array"] != null)
            {
                bool validaLogin = false;
                array = (ArrayList)(Session["array"]);
                foreach (Usuario usuario in array)
                {
                    if (usuario.Email.Equals(TbLogin.Text) && usuario.Senha.Equals(TbSenha.Text))
                    {
                        validaLogin = true;
                    }
                }
                if (validaLogin)
                {
                    string url = "Home.aspx";
                    Response.Redirect(url);
                }
                else
                {
                    Response.Write("<script>alert('Erro! Email ou Senha inválidos!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Erro! Email ou Senha inválidos!')</script>");
            }
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            string url = "Cadastro.aspx";
            Response.Redirect(url);
        }
    }
    }