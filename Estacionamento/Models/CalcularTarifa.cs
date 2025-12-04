using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class CalcularTarifa
    {
        public static void Tarifa(decimal pInicial, decimal tarifa)
        {
            Console.WriteLine($"O Valor total a pagar foi de: R${pInicial * tarifa}");
        }
}
}