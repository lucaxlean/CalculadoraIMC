using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo individuo1 = new Individuo (66, 1.78);  
            Console.WriteLine(individuo1.Classificar()); 
            Console.WriteLine(individuo1.ReajusteDePeso());

        }
    }
}
