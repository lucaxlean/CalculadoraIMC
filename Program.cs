﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?"); 
            string nome = Console.ReadLine(); 

            Console.WriteLine ("Qual sua altura em metros?"); 
            float altura = Convert.ToSingle(Console.ReadLine()); 

            Console.WriteLine("Qual seu peso em kg? ex: 54,7");
            float peso = Convert.ToSingle(Console.ReadLine()); 

            double imc = peso / (altura * altura); 

            Console.WriteLine ("{0} sua altura é  {1} e seu peso é {2}", nome, altura , peso);
            Console.WriteLine ("eu imc é {0}", imc); 

        }
    }
}
