using Calculadora.Models;
using Calculadora.Services.Interfaces;

namespace Calculadora.Services
{
	public sealed class DivisaoService : ICalculatorService
	{
		public ECodigoOperacao CodigoOperacao => ECodigoOperacao.Divisao;

		//manejar excepcion division para 0
		public decimal Execute(IRequestViewModel request) => request.Numero1 / request.Numero2;
	}
}
