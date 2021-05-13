using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------- Pagamento onlinne -------------");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            string cpf_cnpj = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            if(cpf_cnpj.ToUpper() == "cpf".ToUpper())
            {
                Fisica pf = Fisica();
                Console.WriteLine("Nome do cliente: {0}", pf.Nome);
                Console.WriteLine("Cpf do cliente: {0}", pf.Cpf);

            } else if(cpf_cnpj.ToUpper() == "cnpj".ToUpper())
            {
                Juridica pj = new Juridica();
                Console.WriteLine("Nome do cliente: {0}", pj.Nome);
                Console.WriteLine("Cnpj do cliente: {0}", pj.cnpj);

            }


        }
    }
}
