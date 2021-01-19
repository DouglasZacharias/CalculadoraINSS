using Calculadora.Interface;
using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Table
{
    
    internal abstract class TableDefault : ITabelaDesconto
    {
        protected decimal Teto { get; set; }
        protected IList<Faixa> Faixas { get; private set; }
        public abstract bool ExisteCalculoPeriodo(DateTime data);                
        public TableDefault()
        {
            Faixas = new List<Faixa>();
        }
        public decimal CalcularDesconto(decimal salario)
        {
            if (salario <= decimal.Zero) return decimal.Zero;
            foreach(var faixa in Faixas)
            {
                if (faixa.SalarioNaFaixa(salario)) return faixa.ValorDesconto(salario);
            }
            return Teto;
        }


    }
}
