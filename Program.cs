using Kolos_1;
using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Wykladowca wykladowca = new Wykladowca("wykl_1", 1999);
		Student student1 = new Student("stud_1", 2005);
		Student student2 = new Student("stud_2", 2004);
		Student student3 = new Student("stud_3",2003);
		Student student4 = new Student("stud_4", 2002);
		Student student5 = new Student("stud_5", 2001);

		List<Student> studenci = new List<Student>()
		{ student1, student2,student3,student4,student5
		};

		Przedmiot programowanie = new Przedmiot("programowanie", "Obojektowe programowanie w c#", "Sala 106", "15:00", wykladowca, studenci);
		Przedmiot matDyskretna = new Przedmiot("Matematyka sykretna", "grafy, kombinatoryka, funkcje tworzace", "sala 5", "9:45");

		matDyskretna.wykladowca = wykladowca;
		wykladowca.Nauczaj(matDyskretna);
		student5.Uczeszczaj(programowanie);

	}
}
