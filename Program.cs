using System;

namespace TituloCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            TituloCalc();
            Console.WriteLine("SELECIONE A OPERAÇÃO:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão e Módulo");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("O que deseja fazer: ");
            int operacao = int.Parse(Console.ReadLine()!);

            switch (operacao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: DivisaoModulo(); break;
                case 0: Sair(); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }

        }

        static void TituloCalc()
        {
            Console.WriteLine("## CALCULADORA ##");
        }
        static void Soma()
        {
            Console.Clear();
            TituloCalc();
            Console.WriteLine("SOMA");
            Console.WriteLine("Primeiro valor (Parcela 1): ");
            float vlrSoma1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor (Parcela 2): ");
            float vlrSoma2 = float.Parse(Console.ReadLine()!);

            float resultadoSoma = vlrSoma1 + vlrSoma2;
            Console.WriteLine($"Resultado (Total/Soma): {resultadoSoma}");
            Thread.Sleep(3500);
            Menu();
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            TituloCalc();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Primeiro valor (Minuendo): ");
            float vlrSubtracao1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor (Subtraendo): ");
            float vlrSubtracao2 = float.Parse(Console.ReadLine()!);

            float resultadoSubtracao = vlrSubtracao1 - vlrSubtracao2;
            Console.WriteLine($"Resultado (Diferença/Resto): {resultadoSubtracao}");
            Thread.Sleep(3500);
            Menu();
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            TituloCalc();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Primeiro valor (Fator-Multiplicando):");
            float vlrMultiplicacao1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor (Fator-Multiplicador):");
            float vlrMultiplicacao2 = float.Parse(Console.ReadLine()!);

            float resultadoMultiplicacao = vlrMultiplicacao1 * vlrMultiplicacao2;
            Console.WriteLine($"Resultado (Produto): {resultadoMultiplicacao}");
            Thread.Sleep(3500);
            Menu();
            Console.ReadKey();
        }

        static void DivisaoModulo()
        {
            Console.Clear();
            TituloCalc();
            Console.WriteLine("DIVISÃO E MÓDULO");
            Console.WriteLine("Primeiro valor (Dividendo): ");
            float vlrDivisao1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Segundo valor (Divisor): ");
            float vlrDivisao2 = float.Parse(Console.ReadLine()!);

            float resultadoDivisao = vlrDivisao1 / vlrDivisao2;
            float resultadoModulo = vlrDivisao1 % vlrDivisao2;
            Console.WriteLine($"Quociente (Resultado): {resultadoDivisao}");
            Console.WriteLine($"Resto: {resultadoModulo}");
            Thread.Sleep(3500);
            Menu();
            Console.ReadKey();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Saindo em...");
            int contador = 3;
            while (contador != 0)
            {
                Console.WriteLine(contador);
                contador--;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Obrigado por utilizar nossa calculadora.");
            System.Environment.Exit(0);
        }
    }
}