using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPallatkert
{
	internal class Melegeghajlat
	{
		int sebeseeg;
		string nev;
		string nem;
		int eletkor;

		public Melegeghajlat(int sebeseeg, string nev, string nem, int eletkor)
		{
			this.sebeseeg = sebeseeg;
			this.nev = nev;
			this.nem = nem;
			this.eletkor = eletkor;
		}

		public int Sebeseeg { get => sebeseeg; set => sebeseeg = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Nem { get => nem; set => nem = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
	}
}
