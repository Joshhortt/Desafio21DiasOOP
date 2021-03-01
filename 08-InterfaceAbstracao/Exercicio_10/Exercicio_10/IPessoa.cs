using System;
using System.Collections.Generic;

namespace Exercicio_10
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }

        void Salvar();
        void Excluir();
        string getDocumento();
    }
}
