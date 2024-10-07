using System.Runtime.CompilerServices;

namespace SistemaDeReserva.Models
{
    public class Reservas
    {
        private decimal precoPorDiaria = 0;
        private List<string> reserva = new List<string>();

        public Reservas(decimal precoPorDiaria)
        {
            this.precoPorDiaria=precoPorDiaria;
        }
        public void AdicionarReserva()
        {
            Console.WriteLine("Digite o nome do cliente:");
            string cliente = Console.ReadLine();
            
            reserva.Add(cliente);
            Console.WriteLine($"{cliente} foi hospedado com sucesso!");
        }
        public void RemoverReserva()
        {
            Console.WriteLine("Digite o nome do cliente para remover:");
            string cliente = Console.ReadLine();

            if(reserva.Any())
            {
                Console.WriteLine("Digite quantas diárias o cliente permaneceu no hotel:");
                int dias = int.Parse(Console.ReadLine());

                decimal valorTotal = precoPorDiaria * dias;

                reserva.Remove(cliente);

                Console.WriteLine($"O cliente {cliente} foi removido com sucesso e o preço total foi de: R$ {valorTotal}");
            }
            else
                Console.WriteLine("Desculpa, esse cliente não está hospedado aqui. Confira se digitou corretamente");
        }
        public void ListarReserva()
        {
            if(reserva.Any())
            {
                Console.WriteLine("Os clientes hospedados são:");
                foreach (var cliente in reserva)
                {
                    Console.WriteLine(cliente);
                }
            }
            else
                Console.WriteLine("Não há clientes hospedados.");
        }
        

    }
}
