// 07.EXERCICIO TPC sobre Propriedade Publica e Estática                                                 

using System;

namespace Exercicio
{
    class Program
    {
          static void Main(string[] args)
        {
              bool simNao = false;

            Console.WriteLine("Seja bem vindo ao Registo de Pessoas!");
            Console.WriteLine("====================================================");
            Console.WriteLine("");
      
            Console.Write("Você gostaria de registar-se agora?\n ");
            Console.Write("Se sim digite 1\n ");
            Console.Write("Se não digite 2\n ");

            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
                simNao = true;
            }
           
            if (simNao)
            {
                while (simNao)
                {
                    Console.Write("Digite os seus dados pessoais:\n");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Cpf: ");
                    string cpf = Console.ReadLine();
                    new Fisica() { Nome = nome, CPF = cpf }.Salvar();
                    Console.WriteLine();

                    Console.Write("Deseja adicionar outro registo?\n ");
                    Console.Write("Se sim digite 1\n ");
                    Console.Write("Se não digite 2\n ");
                    resposta = int.Parse(Console.ReadLine());

                    if (resposta == 2)
                    {
                        simNao = false;
                        Fisica.MostrarLista();
                    } 
                }
            }
            else
            {
                Console.WriteLine("Opção invalida, digite 1 para sim ou 2 para não!");
            }
        }
    }
}
