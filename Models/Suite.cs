using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_sistema_reserva_hotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tiposuite, int capacidade, decimal valordiaria)
        {
            TipoSuite = tiposuite;
            Capacidade = capacidade;
            ValorDiaria = valordiaria;
        }
    }
}