using System.Diagnostics;

namespace ATV4_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;
            Console.WriteLine("1- Exercício 1");
            Console.WriteLine("2- Exercício 2");
            Console.WriteLine("3- Exercício 3");
            Console.WriteLine("4- Exercício 4\n");
            Console.WriteLine("Escolha um exercício: ");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {

                //EX1
                case 1:
                    int dia;
                    Console.WriteLine("<<Dias da semana>>\n");
                    Console.WriteLine(".1\n");
                    Console.WriteLine(".2\n");
                    Console.WriteLine(".3\n");
                    Console.WriteLine(".4\n");
                    Console.WriteLine(".5\n");
                    Console.WriteLine(".6\n");
                    Console.WriteLine(".7\n");
                    Console.WriteLine("Escolha o dia da semana: ");
                    dia = int.Parse(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;

                        case 2:
                            Console.WriteLine("Segunda");
                            break;
                        case 3:
                            Console.WriteLine("Terça");
                            break;

                        case 4:
                            Console.WriteLine("Quarta");
                            break;
                        case 5:
                            Console.WriteLine("Quinta");
                            break;

                        case 6:
                            Console.WriteLine("Sexta");
                            break;

                        case 7:
                            Console.WriteLine("Sábado");
                            break;

                    }

                    break;

                //EX2
                case 2:
                    int pag;
                    float compra, d;

                    Console.WriteLine("<<COMPRA>>\n");
                    Console.WriteLine("Valor total da sua compra: ");
                    compra = float.Parse(Console.ReadLine());

                    Console.WriteLine("<<Formas de pagamento>>\n");
                    Console.WriteLine("1- À vista no dinheiro (15% DESC.)");
                    Console.WriteLine("2- À vista no PIX (10% DESC.)");
                    Console.WriteLine("3- No débito (5% ACRESC.)");
                    Console.WriteLine("4- No cartão de crédito (10% ACRESC.)\n");
                    Console.WriteLine(":");
                    pag=int.Parse(Console.ReadLine());

                    switch (pag)
                    {
                        case 1:

                            d = compra - 15 / 100 * compra;
                          
                            Console.WriteLine("Total compra = "+ d);
                            break;

                        case 2:

                            d = compra - (10 / 100 * compra); 
                            
                            Console.WriteLine("Total compra = "+ d);
                            break;

                        case 3:

                            d = compra + (5 / 100 * compra);
                           
                            Console.WriteLine("Total compra = "+ d);
                            break;

                        case 4:

                           d = compra + (10 / 100 * compra);
                           
                            Console.WriteLine("Total compra = "+ d);
                            break;
                    } break;


                //EX4
                case 4:

                    int c = 5;
                    float n, n1, a, s, m, div;

                    //Entrada números
                    Console.WriteLine("<<CALCULADORA>>\n");
                    Console.WriteLine("Digite um número: ");
                    n = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    n1 = float.Parse(Console.ReadLine());

                    //Operações
                    Console.WriteLine("\n<<Operações>>\n");
                    Console.WriteLine("1- Adição\n");
                    Console.WriteLine("2- Subtração\n");
                    Console.WriteLine("3- Multiplicação\n");
                    Console.WriteLine("4-Divisão\n");
                    Console.WriteLine("Opção: ");
                    c = int.Parse(Console.ReadLine());

                    //OPÇÕES
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Adição");
                            a = n + n1;
                            Console.WriteLine("Resultado = {0}", a);
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
                            div = n / n1;
                            Console.WriteLine("Resultado = {0}", div);
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;

                }break;
            }
        }
    }
}

    

