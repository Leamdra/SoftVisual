using System;

namespace Aula03
{
    class Program
    {
        static double calculaMedia(double[] numeros)
        {
            double media = 0;
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
              soma += numeros[i];
            }
            media = soma / numeros.Length;
            return media;

            //return (n1 + n2) / 2 ;
        }

        static double calculoMediana(double[] numeros){
        
            Array.Sort(numeros);
            int mediana = numeros.Length / 2;

            return numeros[mediana];

        }


        static double calculaModa(double[] numeros)
        {
         double[] repetições = new double[numeros.Length];
         for (int i = 0; i <  numeros.Length ; i++)
         {
             double atual = numeros[i];
             int cont =0;

          for (int j = 0; j < numeros.Length; j++)
          {
            if(numeros[j] == atual)
            {
                cont++;
            }
          }
          repetições[i] = cont;
         }
            int maior = 0;
             for (int i = 1; i < repetições.Length; i++)
            {
             if(repetições[i] > repetições[i - 1])
             {
                 maior = i;
             }
            }
            return numeros[maior];
        }
        static void Main(string[] args)
        {

            double[] numeros = {123, 354, 66, 55, -1, 1.4, 66, 66, 55, 8, 9, 9};
            double media = calculaMedia(numeros);
            Console.WriteLine("a media é: " + media);
            double mediana = calculoMediana(numeros);
            Console.WriteLine("a mediana é "+ mediana);
            double moda = calculaModa(numeros);
            Console.WriteLine("sua moda é: " + moda);

            //Console.WriteLine("Informe o 1° valor: ");
            //double n1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("O seu 1° valor é: " + n1);

            //Console.WriteLine("Informe o 2° valor: ");
            //double n2 = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("O seu 2° valor é: " + n2);

    
            //double media = calculaMedia(n1, n2);

           // Console.WriteLine("A sua media é: " + media);


        }
    }
}

