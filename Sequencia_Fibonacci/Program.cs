using System;

namespace Sequencia_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int indiceUltimoElemento = 1;
            int indicePenultimoElemento = 0;

            var sequenciaDeFibonacci = new List<int> { 1, 1 };

            System.Console.WriteLine("informe a quantidade de elementos da sequência.\n " +
                "Maior que 0 e até 45");

            int tamanhoSequencia = int.Parse(Console.ReadLine());

            if (tamanhoSequencia <= 0 || tamanhoSequencia > 45)
            {
                System.Console.WriteLine("Número inválido.");
                return;
            }               

            while (sequenciaDeFibonacci.Count < tamanhoSequencia)
            {
                var proximoElemento = sequenciaDeFibonacci[indicePenultimoElemento] + sequenciaDeFibonacci[indiceUltimoElemento];

                sequenciaDeFibonacci.Add(proximoElemento);

                indiceUltimoElemento++;
                indicePenultimoElemento++;
            }

            Console.WriteLine("Os "+tamanhoSequencia+" primeiros elementos da Sequência de Fibonacci são:");

            foreach (var elemento in sequenciaDeFibonacci)
            {
                Console.WriteLine(elemento); 
            }

        }
    }
}