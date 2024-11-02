using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        // Construtor que recebe o preço inicial e o preço por hora
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com placa {placa.ToUpper()} estacionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }
        }

        // Método para remover um veículo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o valor total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Verifique se digitou a placa corretamente.");
            }
        }

        // Método para listar os veículos estacionados
        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
