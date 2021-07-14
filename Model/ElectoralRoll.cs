using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadronElectoral.Model
{
	class ElectoralRoll
	{
		public ElectoralRoll()
		{
			TheElectoralRoll = new List<Person>();
		}
		public List<Person> TheElectoralRoll { get; set; }

		public void SavePersonOnElectoralRoll (Person thePerson)
		{
			TheElectoralRoll.Add(thePerson);
		}


		public void PrintTheElectoralRoll ()
		{
			foreach (Person thePersonToPrint in TheElectoralRoll)
			{
				Console.WriteLine(thePersonToPrint);
			}
		}
	}
}
