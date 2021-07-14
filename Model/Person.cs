using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadronElectoral.Model
{
	class Person
	{
		public Person(string id, string codelec, string firstName)
		{
			Id = id;
			Codelec = codelec;
			FirstName = firstName;
		}

		public string Id { get; set; }

		public string Codelec { get; set; }

		public string FirstName { get; set; }

		public override string ToString()
		{
			return "Cédula: " + Id + " Codigo Electoral: " + Codelec + " Nombre: " + FirstName;
		}
	}
}
