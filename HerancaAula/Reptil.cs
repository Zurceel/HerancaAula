using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
	public class Reptil : Animal
	{
		public bool PossuiVeneno { get; set; }

		public Reptil(string nome, string especie)
		{
			Nome = nome;
			Especie = especie;
		}

		public void BotarOvo()
		{
			if (PossuiVeneno)
			{
				Console.WriteLine($"Aninal {Nome} da espécie {Especie} está botando ovo e é venenoso!");
			}
			else
			{
				Console.WriteLine($"Aninal {Nome} da espécie {Especie} está botando ovo e não é venenoso!");
			}
		}
	}
}
