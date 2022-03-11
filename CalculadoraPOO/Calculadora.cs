using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    class Historico
    {
        public decimal primeiroNumero;
        public decimal segundoNumero;
        public string op;
        public decimal resultado;
    }

    internal class Calculadora
    {
       public Historico[] historicoOperacoes;

        public Calculadora()
        {

        }

        public decimal adicao(decimal a, decimal b)
        {
            decimal resultado = a + b;
            CriaEntrada(a, b, "+", resultado);
            return resultado;
        }

        private void CriaEntrada(decimal a, decimal b, string op, decimal resultado)
        {
            Historico entrada = new Historico();
            entrada.op = op;
            entrada.primeiroNumero = a;
            entrada.segundoNumero = b;
            entrada.resultado = resultado;

            for(int i = 0; i < 10; i++)
            {
                if (historicoOperacoes[i] == null)
                {
                    historicoOperacoes[i] = entrada;
                    break;
                }
            }
        }

        public decimal subtracao(decimal a, decimal b)
        {
            decimal resultado = a + b;
            CriaEntrada(a, b, "-", resultado);
            return resultado;
        }

        public decimal multiplicacao(decimal a, decimal b)
        {
            decimal resultado = a * b;
            CriaEntrada(a, b, "*", resultado);
            return resultado;
        }

        public decimal divisao(decimal a, decimal b)
        {
            decimal resultado = a / b;
            CriaEntrada(a, b, "/", resultado);
            return resultado;
            
        }

        public void VisualizarHistorico()
        {
            foreach (Historico item in historicoOperacoes)
            {
                if (item != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(item.primeiroNumero + " " + item.op + " " + item.segundoNumero + " = " + item.resultado);

                }
            }
        }
    }
}
