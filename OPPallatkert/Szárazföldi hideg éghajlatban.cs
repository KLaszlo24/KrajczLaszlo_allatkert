using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPallatkert
{
	internal class Szárazföldi_hideg_éghajlatban
	{
		int sebesseg;
		string nev;
		string nem;
		int eletkor;

		public Szárazföldi_hideg_éghajlatban(int sebesseg, string nev, string nem, int eletkor)
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
