using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um valor que represente Δd e Δt para ser feito a velocidade média de um carro.");
            Console.Write("Δd:");
            double Δd=Convert.ToDouble(Console.ReadLine());
            Console.Write("Δt:");
            double Δt=Convert.ToDouble(Console.ReadLine());
            double resultado=Δd / Δt;
            Console.Clear();
            Console.WriteLine($"Velocidade média do carro é= {resultado} m/s");
        }
    }
}
