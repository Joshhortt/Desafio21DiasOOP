using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09a
{
	public class PagamentoViaCardNovo : PagamentoNovo
	{
		public override void Pagar(decimal valor)    // Metodo override
		{
			base.Pagar(250);
		}
	}
}
