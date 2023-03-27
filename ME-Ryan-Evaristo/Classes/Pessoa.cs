using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_Ryan_Evaristo.Classes
{
    public class Pessoa
    {
        private string nome;
        private DateTime dataNasci;
        private string endereco;
        private string cpf;

        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime dataNasci, string endereco, string cpf)
        {
            this.nome = nome;
            this.dataNasci = dataNasci;
            this.endereco = endereco;
            this.cpf = cpf;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasci { get => dataNasci; set => dataNasci = value; }
        public string Endereco { get => endereco; set => endereco = value; }

    }


}