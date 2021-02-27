using System;

namespace Exercicio_08
{
    public class Servico
    {
        public Servico()
        {
        }

        public static void Salvar(IPessoa iPessoa)
        {
            iPessoa.Salvar();
        }
    }
}
