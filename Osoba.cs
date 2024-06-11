using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1
{
	public class Osoba
	{
		public string nazwisko;
		int rokUrodzenia;

		public Osoba(string nazwisko, int rokUrodzenia) {
			this.nazwisko = nazwisko;
			this.rokUrodzenia = rokUrodzenia;
		}

		public int PopbierzAktualnyWiek()
		{
			int obecnyRok = 2024;
			return obecnyRok - rokUrodzenia;
		}
	}
}
