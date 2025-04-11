using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_sistema_reserva_hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; } = null!;
        public int DiasReservados { get; set; }


        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                Console.WriteLine("Quantidade de hospedes confirmada!!");
            }
            else
            {
                throw new Exception("Quantidade de hospedes não permitida!!");
            }
        }


        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10) { valor *= 0.9m; }
            return valor;
        }


        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }


    }








}
