using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPallatkert
{
	internal class Allatkert
	{
		List<Vízben> viziallat= new List<Vízben> ();
		List<Szárazföldi_hideg_éghajlatban> hidegallat =  new List<Szárazföldi_hideg_éghajlatban>();
		List<Mediterrán> mediterranallat = new List<Mediterrán>();
		List<Melegeghajlat> melegallat = new List<Melegeghajlat>();
		List<Trópusi> tropusiallat = new List<Trópusi>();
		private int nagysag;
		private int allatkertnagysag;

		public Allatkert()
		{ 
			Random rnd = new Random ();
			allatkertnagysag = rnd.Next(5,16);
		}

		public void Beolvasas()
		{
			viziallat.Add(new Vízben(3, "jegesmedve", "hím", 5));
			hidegallat.Add(new Szárazföldi_hideg_éghajlatban(2, "delfin", "hím", 4));
			mediterranallat.Add(new Mediterrán(4, "bölény", "nőstény", 5));
			melegallat.Add(new Melegeghajlat(14, "gepárd", "nőstény", 7));
			tropusiallat.Add(new Trópusi(8, "majom", "hím", 18));
		}
		
		public void Szamok()
		{
			for (int i = 0; i < viziallat.Count; i++)
			{
				nagysag += 1;
			}
			for (int i = 0; i< hidegallat.Count; i++)
			{
				nagysag += 1;
			}
			for (int i = 0; i < mediterranallat.Count; i++)
			{
				nagysag += 1;
			}
			for (int i = 0; i < melegallat.Count; i++)
			{
				nagysag += 1;
			}
			for (int i = 0; i < tropusiallat.Count; i++)
			{
				nagysag += 1;
			}

			for (int i = 0;i < allatkertnagysag; i++)
			{
				if (i < nagysag)
				{
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
				else
				{
          
					Console.BackgroundColor= ConsoleColor.Red;
                    Console.Write(" ");
                }
				Console.ResetColor();
			}
			Console.WriteLine();

			Console.WriteLine($"Kapacitás: {allatkertnagysag} / telítettség: {nagysag}");
        }

		public void Verseny()
		{
			List<string> nev = new List<string>();
			List<int> sebesseg = new List<int>();

			for (int i = 0; i < viziallat.Count; i++)
			{
				nev.Add(viziallat[1].Nev);
			}
			for (int i = 0; i < hidegallat.Count; i++)
			{
				nev.Add(hidegallat[1].Nev);
			}
			for (int i = 0; i < mediterranallat.Count; i++)
			{
				nev.Add(mediterranallat[1].Nev);
			}
			for (int i = 0; i < melegallat.Count; i++)
			{
				nev.Add(melegallat[1].Nev);
			}
			for (int i = 0; i < tropusiallat.Count; i++)
			{
				nev.Add(tropusiallat[1].Nev);
			}

			for (int i = 0; i < viziallat.Count; i++)
			{
				sebesseg.Add(viziallat[1].Sebesseg);
			}
			for (int i = 0; i < hidegallat.Count; i++)
			{
				sebesseg.Add(hidegallat[1].Sebesseg);
			}
			for (int i = 0; i < mediterranallat.Count; i++)
			{
				sebesseg.Add(mediterranallat[1].Sebesseg);
			}
			for (int i = 0; i < melegallat.Count; i++)
			{
				sebesseg.Add(melegallat[1].Sebeseeg);
			}
			for (int i = 0; i < tropusiallat.Count; i++)
			{
				sebesseg.Add(tropusiallat[1].Sebesseg);
			}

		}
	}
}
