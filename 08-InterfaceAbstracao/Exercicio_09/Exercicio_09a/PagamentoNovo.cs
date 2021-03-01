using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09a
{
	public abstract class PagamentoNovo  // criar classe abstrata

	{
		public DateTime Vencimento { get; set; }  // implementação da propriedade
		
		public decimal Valor { get; set; }   // implementação da propriedade

		public virtual void Pagar(decimal valor)  // Metodo
		{
			Console.WriteLine("Pagamento base");
		}
	
}
