using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interface
{
    public interface ITabelaDesconto
    {
        /// <summary>
        /// Calcula o desconto referente ao salário especificado.
        /// </summary>
        /// <param name="salario">O salário que se deseja calcular o desconto.</param>
        decimal CalcularDesconto(decimal salario);

        /// <summary>
        /// Verifica se a tabela pode calcular o desconto para o ano especificado.
        /// </summary>
        /// <param name="data">A data que se deseja calcular o desconto.</param>
        bool ExisteCalculoPeriodo(DateTime data);
    }
}
