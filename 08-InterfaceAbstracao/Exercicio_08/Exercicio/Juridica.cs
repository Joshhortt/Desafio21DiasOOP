using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_08
{
    public class Juridica : Pessoa  
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }


        public static List<Juridica> Base = new List<Juridica>();
        public override void Salvar()   
        {
            Juridica.Base.Add(this);
        }

        public static List<Juridica> BuscaPorNome(string nome)
        {
            var novaLista = new List<Juridica>();
            foreach (var instancia in Juridica.Base)
            {
                if (instancia.Nome.ToLower().Contains(nome.ToLower()))
                {
                    novaLista.Add(instancia);
                }
            }
            return novaLista;
        }

		public override void Excluir()
		{
			throw new NotImplementedException();  
        }

		public override void Buscar(string nome)
		{
			throw new NotImplementedException();
		}
	}
}
