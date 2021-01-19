using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Table
{
    class Table2012 : TableDefault
    {
        public Table2012()
        {
            Faixas.Add(new Faixa(1000.00M, Desconto.SetePorcento));
            Faixas.Add(new Faixa(1000.01M, 1500.00M, Desconto.OitoPorcento));
            Faixas.Add(new Faixa(1500.01M, 3000.00M, Desconto.NovePorcento));
            Faixas.Add(new Faixa(3000.01M, 4000.00M, Desconto.OnzePorcento));
            Teto = 500.00M;
        }
        public override bool ExisteCalculoPeriodo(DateTime data)
        {
            return data.Year == 2012;
        }
    }
}
