using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public abstract class Smartphone : ISmartphone
    {
        public Smartphone(){}
        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public abstract void InstalarAplicativo(string nome);

        public void Ligar()
        {
            Console.WriteLine($"Ligando smartphone\n".ToUpper());
            Console.WriteLine($"Modelo: {Modelo}\n");
            Console.WriteLine($"IMEI: {IMEI}\n");
            Console.WriteLine($"Mémoria: {Memoria} de RAM\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação".ToUpper());
            Console.WriteLine($"Número: {Numero}");
        }
    }
}