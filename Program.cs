using System;

namespace InvertaOsCaracteresDeUmString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto que sera invertido: ");

            string novaStr = string.Empty;
            string strOriginal = Console.ReadLine();

            for (int indice = strOriginal.Length - 1; indice >= 0; indice--)
            {
                novaStr += strOriginal[indice];
            }
            Console.WriteLine("Texto invertido: ");
            Console.WriteLine(novaStr);
            Console.ReadKey();
        }
    }
}
