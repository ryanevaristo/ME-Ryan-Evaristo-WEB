using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_Ryan_Evaristo.Classes
{
    public class Veiculo
    {
        private string tpTransporte;
        private string placa;
        private string marca;
        private string modelo;
        private int ano;
        private int capacidade;
        private string cpfMotorista;
        public Veiculo() { }

        public string TpTransporte { get => tpTransporte; set => tpTransporte = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public string CpfMotorista { get => cpfMotorista; set => cpfMotorista = value; }


    }
}