using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    class Faixa
    {
        private const int CasasDecimais = 2;
        private decimal valorInicial;
        private decimal valorFinal;
        private decimal aliquota;

        internal Faixa(decimal valor, decimal aliquota) : this(decimal.Zero, valor, aliquota){}

        internal Faixa(decimal valorInicial, decimal valorFinal, decimal aliquota)
        {
            this.valorInicial = valorInicial;
            this.valorFinal = valorFinal;
            this.aliquota = aliquota;
        }
        /// <summary>
        /// Verifica se o salário especificado está dentro da faixa.
        /// </summary>
        internal bool SalarioNaFaixa(decimal salario)
        {
            return salario >= valorInicial && salario <= valorFinal;
        }

        /// <summary>
        /// Aplica a alíquota em cima do salário especificado.
        /// </summary>
        internal decimal ValorDesconto(decimal salario)
        {
            return Arrendondar(salario * aliquota);
        }

        private decimal Arrendondar(decimal valor)
        {
            return Math.Round(valor, CasasDecimais);
        }
    }
}
