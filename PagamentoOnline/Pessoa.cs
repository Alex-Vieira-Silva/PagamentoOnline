using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoOnline
{
    abstract class Pessoa
    {
        protected String nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        abstract protected Boolean validar(String documento);

    }
}
