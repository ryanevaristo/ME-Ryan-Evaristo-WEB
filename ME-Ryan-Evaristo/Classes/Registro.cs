using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace ME_Ryan_Evaristo.Classes
{
    public class Registro
    {
        private string placaVeiculo;
        private string cpfPassageiro;
        private DateTime dataTransporte;
        private string hora;
        private int kmTotais;
        private double valorTotal;

        public Registro() { }

        public Registro(string placaVeiculo, string cpfPassageiro, DateTime dataTransporte, string hora, int kmTotais, double valorTotal)
        {
            this.placaVeiculo = placaVeiculo;
            this.cpfPassageiro = cpfPassageiro;
            this.dataTransporte = dataTransporte;
            this.hora = hora;
            this.kmTotais = kmTotais;
            this.valorTotal = valorTotal;
        }

        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
        public string CpfPassageiro { get => cpfPassageiro; set => cpfPassageiro = value; }
        public DateTime DataTransporte { get => dataTransporte; set => dataTransporte = value; }
        public string Hora { get => hora; set => hora = value; }
        public int KmTotais { get => kmTotais; set => kmTotais = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Func Total()
        {
            ValorTotal = KmTotais * 0.40;
            return ValorTotal;
        }

    }
}