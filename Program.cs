using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiro;
            string segundo;
            string terceiro;
            
            double primeiro1;
            double segundo1;
            double terceiro1;
            
            double somade3;
            double unico = 3;
            double valor;

            Console.WriteLine("Calcule a media aritmética de 3 lados");
            Console.WriteLine("Digite o primeiro lado:");
            primeiro = Console.ReadLine();
            Console.WriteLine("Digite o segundo lado:");
            segundo = Console.ReadLine();
            Console.WriteLine("Digite o terceiro lado:");
            terceiro = Console.ReadLine();

            primeiro1 = Convert.ToDouble(primeiro);
            segundo1 = Convert.ToDouble(segundo);
            terceiro1 = Convert.ToDouble(terceiro); 

            somade3 = primeiro1 + segundo1 + terceiro1;
            
            valor = somade3 / unico;

            Console.WriteLine(valor);
           

        }
    }
}
