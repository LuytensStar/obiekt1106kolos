using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1
{
	public class Wykladowca : Osoba
	{
		public List<Przedmiot> przedmioty;

		public Wykladowca(string nazwisko, int rokUrodzenia) : base(nazwisko, rokUrodzenia)
		{
			przedmioty = new List<Przedmiot>();
		}

		public void Nauczaj(Przedmiot przedmiot)
		{
			Console.WriteLine($"Jest godzina {przedmiot.czas}, dlatego {nazwisko} idzie do {przedmiot.miejsce} nauczać {przedmiot.nazwa}.");
		}


	}
}
