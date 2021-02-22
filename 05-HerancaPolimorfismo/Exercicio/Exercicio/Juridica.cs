using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    class Juridica : Pessoa
    {
		private readonly string nipc;

		public string NIPC { get; set; }
        public string AbrirEmpresa { get; set; }

		public Juridica(string nipc, string abrirEmpresa)
		{
			NIPC = nipc;
			AbrirEmpresa = abrirEmpresa;
		}

		public Juridica(string nipc, string abrirEmpresa, string Nome, string Endereco) : base(Nome, Endereco)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
			this.nipc = nipc;
			
		}
    }
}
