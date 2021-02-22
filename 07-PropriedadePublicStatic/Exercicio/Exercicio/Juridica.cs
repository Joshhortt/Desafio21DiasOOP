using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Juridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public static List<Juridica> Base = new List<Juridica>();
        public void Salvar()
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
    }
}