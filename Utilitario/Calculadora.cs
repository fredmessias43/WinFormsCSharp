using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDaDivisao.Utilitario
{
    class Calculadora
    {
        public double RetornaValor(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new ArgumentException("O dividendo não pode ser 0");
            }
            double valor = num1 / num2;

            return valor;
        }

        public double RetornaResto(double num1,double num2)
        {
            double resto = num1 % num2;

            return resto;
        }
    }
}
