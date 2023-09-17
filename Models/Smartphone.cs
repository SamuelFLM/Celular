using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public class Smartphone : ISmartphone
    {
        public Smartphone(){}
        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void InstalarAplicativo(string nome)
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }

        public void ReceberLigacao()
        {
            throw new NotImplementedException();
        }
    }
}