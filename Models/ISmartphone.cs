using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public interface ISmartphone
    {
        void Ligar();
        void ReceberLigacao();
        abstract void InstalarAplicativo(string nome);   
    }
}