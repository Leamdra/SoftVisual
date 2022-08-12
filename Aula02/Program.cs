using System;

namespace Aula02 // namespace o que é ? --> container de classe 
{
    class Program // classe o que é ? uma struct que tem variaveis dentro 
    {
        static void Main(string[] args) // apena suma função main, pois o programa começa pelo main ps se tiver mais de uma main o leitor fica confuso
        {
            try
            {

                 Console.WriteLine("Informe uma largura: ");
                 //double area = CalculaArea(35.0, 3.0);
                 //Console.WriteLine(area);
                 double largura = Convert.ToDouble(Console.ReadLine()); //vai ler os dados ate o enter (\.n)
                 Console.WriteLine("sua largura é: " + largura);

                  Console.WriteLine("Informe a sua altura: ");
                 double altura = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("sua altura é: " + altura);

                 double area = CalculaArea(largura, altura);
                Console.WriteLine("A area é: ");
                Console.WriteLine(area);

            } catch(Exception erro) 
            {
                Console.WriteLine(erro.Message);
            }
           

        }

        static double CalculaArea(double largura, double altura)
        {
            return largura * altura; 
            
        }
    }
}
