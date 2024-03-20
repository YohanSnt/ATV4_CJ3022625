using System.Diagnostics;

namespace ATV4_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            float n, n1, a, s, m, d;

            //Entrada números
            Console.WriteLine("<<CALCULADORA>>\n");
            Console.WriteLine("Digite um número: ");
            n=float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite outro número: ");
            n1= float.Parse(Console.ReadLine());

            //Operações
            Console.WriteLine("\n<<Operações>>\n");
            Console.WriteLine("1- Adição\n");
            Console.WriteLine("2- Subtração\n");
            Console.WriteLine("3- Multiplicação\n");
            Console.WriteLine("4-Divisão\n");
            Console.WriteLine("Opção: ");
            c=int.Parse(Console.ReadLine());

           //OPÇÕES
            switch (c)
            {
                case 1:
                    Console.WriteLine("Adição");
                    a = n + n1;
                    Console.WriteLine("Resultado = {0}",a);
                    break;

                case 2:
                    Console.WriteLine("Subtração");
                    s = n - n1;
                    Console.WriteLine("Resultado = {0}", s);
                    break;

                case 3:
                    Console.WriteLine("Multiplicação");
                    m = n * n1;
                    Console.WriteLine("Resultado = {0}", m);
                    break;

                case 4:
                    Console.WriteLine("Divisão");
                    d = n / n1;
                    Console.WriteLine("Resultado = {0}", d);
                    break;

               default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
