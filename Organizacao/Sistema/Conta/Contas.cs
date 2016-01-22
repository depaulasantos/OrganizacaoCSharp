using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacao.Sistema.Conta
{
	public class Contas
	{
		public double Saldo { get; set; }

		public void Deposita(double valor)
		{
			this.Saldo = valor;
		}
	}
}
