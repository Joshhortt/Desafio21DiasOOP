// 09. Implementação simples de Interfaces de forma implicita ou explicita
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex1
{
	// Interface 1 + 2 metodos
	interface IInterface1
	{
		void Metodo1();
		void Metodo2();
	}

	// Interface 2 +  1 metodo
	interface IInterface2
	{
		void Metodo2();
	}

	// Classe 1 + 1 metodo
		class MinhaClass1
		{
		public void M1()
		{
			Console.WriteLine("M1 da MinhaClass 2");
		}
	}

	// Classe 2 + 3 metodos - herda de Classe 1 de Interface 1 e de Interface 2
	class MinhaClass2 : MinhaClass1, IInterface1, IInterface2
	{
		public void Metodo1()
		{
			Console.WriteLine("Metodo 1");
		}

	// Implementação
		void IInterface1.Metodo2()
		{
			Console.WriteLine("Metodo 2 do Interface 1");
		}
		void IInterface2.Metodo2()
		{
			Console.WriteLine("Metodo 2 do Interface 2");
		}
		void IInterface1.Metodo1()
		{
			Console.WriteLine("Metodo 1 do Interface 1");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
	// Instancias e chamar metodos

			MinhaClass2 m2 = new MinhaClass2(); 

			IInterface1 i1 = new MinhaClass2();
			i1.Metodo2();  

			IInterface2 i2 = new MinhaClass2();
			i2.Metodo2();

			IInterface1 i3 = new MinhaClass2();
			i3.Metodo1();
		}
	}
}
