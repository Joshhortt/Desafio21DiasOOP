using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO
{
    public class Receita  // classe Receita
    {
        public Receita(string nome = "")  // construtor com parametro
            {
            this.Nome = nome;
            }

        public Receita() { } // construtor vazio (sem parametros);

        // propriedades
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public float Peso { get; set; }
       // public double Peso { get; set; }
        public float Preco { get; set; }
       // public double Preco { get; set; }


        // metodo Salvar
        public void Salvar(Receita receita)
        {
			//Console.WriteLine("Está salvo!");
            List<Receita> lista = new List<Receita>();
            lista.Add(receita);
        }

        // metodo Mostrar
        public void Mostrar()
        {      
        }
    }
}
