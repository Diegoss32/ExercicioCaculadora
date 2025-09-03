
using System;
using System.Collections;
using System.Globalization;

namespace Calculadora{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------calculadora simples ------");
            Console.Write("digite o numero:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("digite o operador(+  -  *  /): ");
            char operado = char.Parse(Console.ReadLine());
            Console.Write("digite o numero: ");
            int b = int.Parse(Console.ReadLine());

            switch (operado)
            {
                case '+':
                    Console.WriteLine($"a soma de {a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"a divisão de {a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"a multiplicação de {a} * {b} = {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"a divisão de {a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("erro de digitação");
                    break;

            }
        }
    }
}