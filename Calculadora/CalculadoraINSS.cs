using INSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Interface;
using Calculadora.Table;

namespace Calculadora
{
    public class CalculadoraINSS : ICalculadorInss
    {
        private IList<ITabelaDesconto> tables;
        public CalculadoraINSS()
        {
            tables = new List<ITabelaDesconto>();
            tables.Add(new Table2011());
            tables.Add(new Table2012());
        }
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            foreach (ITabelaDesconto tabela in tables)
            {
                if (tabela.ExisteCalculoPeriodo(data))
                    return tabela.CalcularDesconto(salario);
            }
            return decimal.Zero;
        }
    }
}
