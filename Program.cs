using Desafio_sistema_reserva_hotel.Models;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        hospedes.Add(new Pessoa("Ramon", "Lazaro"));
        hospedes.Add(new Pessoa("Danielle", "Andrade"));
        

        Suite suite = new Suite("Premium", 2, 150.00M);


        Reserva reserva = new Reserva();
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);
        reserva.DiasReservados = 10;


        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da reserva: R${reserva.CalcularValorDiaria()}");

    }
}