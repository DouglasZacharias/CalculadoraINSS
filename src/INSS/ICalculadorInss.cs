using System;

namespace INSS
{
    public interface ICalculadorInss
	{
		/// <summary>
		/// Deve retornar o deconto do INSS aplicado ao salário, na determinada data.
		/// </summary>
		/// <param name="salario">O salário que se deseja calcular o desconto.</param>
		/// <param name="data">A data que se deseja calcular o desconto.</param>
		decimal CalcularDesconto(DateTime data, decimal salario);
    }
}
