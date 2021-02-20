using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_04
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private string Descricao { get; set; }
        protected string Autor { get; set; }
        public string Versao { get; set; }
        internal string Codigo { get; set; }

        public void Acao()
        {
            new Livro()
            {
                Versao = "1.0"
            };
        }
    }
}
