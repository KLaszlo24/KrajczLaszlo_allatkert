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
			tropusiallat.Add(new Trópusi(13, "majom", "hím", 18));
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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
				else
				{
          
					Console.BackgroundColor= ConsoleColor.Green;
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

            foreach (var allat in viziallat)
            {
                nev.Add(allat.Nev);
                sebesseg.Add(allat.Sebesseg);
            }
            foreach (var allat in hidegallat)
            {
                nev.Add(allat.Nev);
                sebesseg.Add(allat.Sebesseg);
            }
            foreach (var allat in mediterranallat)
            {
                nev.Add(allat.Nev);
                sebesseg.Add(allat.Sebesseg);
            }
            foreach (var allat in melegallat)
            {
                nev.Add(allat.Nev);
                sebesseg.Add(allat.Sebeseeg);
            }
            foreach (var allat in tropusiallat)
            {
                nev.Add(allat.Nev);
                sebesseg.Add(allat.Sebesseg);
            }

            int[] poziciok = new int[nev.Count];
            
			Console.WriteLine("Az állat verseny elindul!\n");
			Thread.Sleep(1500);

			bool versenyMegy = true;
			Random rnd=new Random();

			while(versenyMegy)
			{
				Console.Clear();

				for (int i = 0; i < nev.Count; i++)
				{
					poziciok[i] += rnd.Next(1, sebesseg[i]);

                    Console.SetCursorPosition(poziciok[i], i);
                    Console.WriteLine(nev[i]);
                }
				foreach(var vegpoz in poziciok)
				{
					if (vegpoz >= 50)
					{
						versenyMegy = false;
						int maxPoz = poziciok.Max();
                        int nyertesIndex = Array.IndexOf(poziciok, maxPoz);
						Console.WriteLine($"\nA nyertes: {nev[nyertesIndex]}");
						return;
                    }
				}
				Thread.Sleep(150);
			}

        }
    }
}

