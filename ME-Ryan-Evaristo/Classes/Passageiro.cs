using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_Ryan_Evaristo.Classes
{
    public class Passageiro : Pessoa
    {
        private string cidade;
        private string uf;
        public Passageiro() { }

        public Passageiro(string cidade, string uf)
        {
            this.cidade = cidade;
            this.uf = uf;
        }

        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }

    }
}