using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia() { }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string appName)
        {
            Console.WriteLine($"\nInstalando aplicativo............\n".ToUpper());
            Console.WriteLine($"\nAplicativo:  {appName}\n".ToUpper());
        }
    }
}