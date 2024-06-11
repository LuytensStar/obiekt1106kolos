using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1
{
	public class Przedmiot
	{
		public string nazwa;
		public string opis;
		public string miejsce;
		public string czas;
		public Wykladowca wykladowca;
		public List<Student> studenci;


		public Przedmiot(string nazwa, string opis, string miejsce, string czas)
		{
			this.nazwa = nazwa;
			this.opis = opis;
			this.miejsce = miejsce;
			this.czas = czas;
		}

		public Przedmiot(string nazwa, string opis, string miejsce, string czas, Wykladowca wykladowca, List<Student> studenci)
		{
			this.nazwa = nazwa;
			this.opis = opis;
			this.miejsce = miejsce;
			this.czas = czas;
			this.wykladowca = wykladowca;
			this.studenci = studenci;
		}


	}
}
