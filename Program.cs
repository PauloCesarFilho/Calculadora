using System;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool opcaoSair = false;
            while (!opcaoSair)
            {
                Console.WriteLine("Seja bem vindo! Selecione uma opcao:\n");
                Console.WriteLine(" 1 - Soma\n 2 - Subtracao\n 3 - Divisao\n 4 - Multiplicacao\n 5 - Potencia\n 6 - Raiz\n 7 - Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine(opcao);                

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;                      
                    case Menu.Sair:
                        opcaoSair = true;
                        break;
                }
                Console.Clear();

            }

            
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtracao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicacao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a * (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potencia de um numero: ");
            Console.WriteLine("Digite a base: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            float b = float.Parse(Console.ReadLine());
            double resultado = Math.Pow(a,b);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite o numero: ");
            float a = float.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }

    }
}


            

        
                
            




