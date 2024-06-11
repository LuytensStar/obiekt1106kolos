using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1
{
	public class Student :Osoba
	{
		public List<Przedmiot> przedmioty;

		public Student(string nazwisko, int rokUrodzenia) : base(nazwisko, rokUrodzenia)
		{
			przedmioty = new List<Przedmiot>();
		}

		public void Uczeszczaj(Przedmiot przedmiot)
		{
			Console.WriteLine($"Jest godzina {przedmiot.czas}, dlatego {nazwisko} idzie do {przedmiot.miejsce} uczyć się {przedmiot.nazwa}.");
		}

	}
}
