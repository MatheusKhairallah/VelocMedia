using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule a velocidade média em que Δd é igual a 100m e Δt 15s:");
            int Δd=100;
            int Δt =15;
            int resultado=Δd / Δt;
            Console.ReadKey();
            Console.WriteLine($"Velocidade média é= {resultado} m/s");
        }
    }
}
