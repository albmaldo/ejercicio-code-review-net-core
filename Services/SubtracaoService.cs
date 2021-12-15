using Calculadora.Models;
using Calculadora.Services.Interfaces;

namespace Calculadora.Services
{
	public sealed class subtractionService : ICalculatorService
	{
		public ECodigoOperacao CodigoOperacao => ECodigoOperacao.subtraction;

		public decimal Execute(IRequestViewModel request) => request.Numero1 - request.Numero2;
	}
}