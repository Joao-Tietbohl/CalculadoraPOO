using System;

namespace CalculadoraPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            decimal primeiroNumero = 0, segundoNumero = 0;
            Calculadora calculadora = new Calculadora();
            calculadora.historicoOperacoes = new Historico[10];

            while (opcao != 6)
            {
                Menu(out opcao,ref primeiroNumero,ref segundoNumero, calculadora);

                Operacoes(opcao, primeiroNumero, segundoNumero, calculadora);               
            }
        }

        private static void OpcaoEhCinco(int opcao, Calculadora calculadora)
        {
             calculadora.VisualizarHistorico();
            
        }

        private static bool Menu(out int opcao,ref decimal primeiroNumero,ref decimal segundoNumero, Calculadora calculadora)
        {
            opcao = 0;
            while (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5 && opcao != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Qual operação você quer realizar?");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Visualizar historico de operações");
                Console.WriteLine("6 - Sair");
                opcao = Int32.Parse(Console.ReadLine());
            }
            if ( opcao == 6)
            {
                return true;
            }

            if( opcao == 5)
            {
                OpcaoEhCinco(opcao, calculadora);
                return true;
            }

            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número");
            primeiroNumero = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            segundoNumero = decimal.Parse(Console.ReadLine());
           
            while (opcao == 4 && segundoNumero == 0)
            {
                Console.WriteLine("Erro! Não existe divisão por zero. Digite outro número");
                segundoNumero = decimal.Parse(Console.ReadLine());
            }

            return true;
        }



        private static void Operacoes(int opcao, decimal primeiroNumero, decimal segundoNumero, Calculadora calculadora)
        {
            switch (opcao)
            {
                case 1:
                    calculadora.adicao(primeiroNumero, segundoNumero);
                    break;

                case 2:
                    calculadora.subtracao(primeiroNumero, segundoNumero);
                    break;

                case 3:
                    calculadora.multiplicacao(primeiroNumero, segundoNumero);
                    break;

                case 4:
                    calculadora.divisao(primeiroNumero, segundoNumero);
                    break;
            }
        }        
    }       
}
