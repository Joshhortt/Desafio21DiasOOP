using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao_Ex1
{

	//class Pessoa  // Classe Base generalizada 
	abstract class Pessoa
	{ 
		public string Nome { get; set; }  // propriedade
	    public int Idade { get; set; }   // propriedade

		//public virtual void Trabalho()  // metodo 
		public abstract void Trabalho();  // metodo
		//{
		//	Console.WriteLine("Está trabalhando...");
		//}
	}
	 // classe estudante que herda da classe base Pessoa
	class Estudante : Pessoa
	{
		public override void Trabalho()
		{
			Console.WriteLine("Está estudando...");  // Output
		}
	}

	// class Funcionario que herda da classe base Pessoa
	class Funcionario : Pessoa  
	{
		public double Salario { get; set; }  // propriedade
		public string Atividade { get; set; }   // propriedade
		public override void Trabalho()  // metodo
		{
			Console.WriteLine("Ganha...");  // Output
		}
	}

	// classe Gestor que herda da classe Funcionario
	class Gestor : Funcionario
	{
		public sealed override void Trabalho()
		{
			Console.WriteLine("Gere a equipa...");  // Output
		}
	}

	// classe GestorProjecto que herda da classe Gestor
	class GestorProjeto : Gestor
	{
		
	}

	class Program
	{
		static void Main(string[] args)
		{

			// Instancias e chamar metodos

			Pessoa p1 = new Estudante();
			p1.Trabalho();

			p1 = new Funcionario();
			p1.Trabalho();

			p1 = new GestorProjeto();
			p1.Trabalho();
		}
	}
}
