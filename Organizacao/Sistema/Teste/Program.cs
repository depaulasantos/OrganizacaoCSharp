using Organizacao.Sistema.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacao.Sistemas.Teste
{
	class Program
	{
		static void Main(string[] args)
		{
			Contas c = new Contas();
			c.Deposita(1000);
			Console.WriteLine(c.Saldo);
		}
	}
}
