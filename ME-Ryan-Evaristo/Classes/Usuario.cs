using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_Ryan_Evaristo.Classes
{
    public class Usuario : Pessoa
    {
        private string email;
        private string senha;
        public Usuario() { }


        public string Email { get => email; set => email = value ; }
        public string Senha { get => senha ; set => senha = value;}


    }
}