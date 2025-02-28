using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPallatkert
{
	internal class mediterrán
	{
		int sebesseg;
		string nev;
		string nem;
		int eletkor;

		public mediterrán(int sebesseg, string nev, string nem, int eletkor)
		{
			this.sebesseg = sebesseg;
			this.nev = nev;
			this.nem = nem;
			this.eletkor = eletkor;
		}

		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Nem { get => nem; set => nem = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
	}
}
