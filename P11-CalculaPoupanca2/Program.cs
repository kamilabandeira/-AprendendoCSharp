using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança 2");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine(
                    "Após" + contadorMes +
                    " meses, você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
