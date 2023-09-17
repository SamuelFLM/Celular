using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone() { }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome}\n");
            Console.WriteLine($"Modelo:  {base.Modelo}\n");
            Console.WriteLine($"Memoria: {base.Memoria}\n");
        }
    }
}