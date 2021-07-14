
using PadronElectoral.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadronElectoralV2.Logic
{
	class Operations
	{
		public Operations(ElectoralRoll theElectoralRoll)
		{
			TheElectoralRoll = theElectoralRoll;
		}

		public ElectoralRoll TheElectoralRoll { get; set; }


		public void PrintMenu ()
		{
			Console.WriteLine("Menu de operaciones: "
							 + "\n 1.Top 10 nombres mas largos"
							 + "\n 2. Nombre menos comun"
							 + "\n 3. Distrito electoral con menos electores"
							 + "\n 4. Distrito electoral con mas electores"
							 + "\n 5. Imprimir el padron"
							 + "\n 6. Salir");
		}

		public void CalculateTopLongerNames ()
		{
			Console.WriteLine("Los 10 nombres más largos");
		}

		public void CalculateLessCommonName ()
		{
			Console.WriteLine("Los nombres menos comunes");
		}
		public void CalculateDistrictWithLessElectors()
		{
			Console.WriteLine("El distrito con menos electores");
		}

		public void CalculateDistrictWithMoreElectors()
		{
			Console.WriteLine("El distrito con mas electores");
		}

		public void PrintTheElectoralRoll()
		{
			foreach (Person thePersonToPrint in TheElectoralRoll.TheElectoralRoll)
			{
				Console.WriteLine(thePersonToPrint);
			}
		}

	}




}
