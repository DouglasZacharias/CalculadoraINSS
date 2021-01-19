using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Table
{
    internal class Table2011 : TableDefault
    {
        public Table2011()
        {
            Faixas.Add(new Faixa(1106.90M, Desconto.OitoPorcento));
            Faixas.Add(new Faixa(1106.91M, 1844.83M, Desconto.NovePorcento));
            Faixas.Add(new Faixa(1844.84M, 3689.66M, Desconto.OnzePorcento));
            Teto = 405.86M;
        }
        public override bool ExisteCalculoPeriodo(DateTime data)
        {
            return data.Year == 2011;
        }
    }
}
