using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using PadronElectoral.Model;
namespace PadronElectoralV2.Data
{
	class Loader
	{
		public Loader()
		{
			FilePath = @"C:\demo\text.txt";
			TheElectoralRoll = new ElectoralRoll();
		}

		public string FilePath { get; set; }

		public ElectoralRoll TheElectoralRoll { get; set; }


		public void LoadFile()
		{
			List<string> lines = File.ReadAllLines(FilePath).ToList();

			foreach (string line in lines)
			{
				string[] items = line.Split(',');
				Person thePersonToAdd = new Person(items[0], items[1], items[2]);
				TheElectoralRoll.SavePersonOnElectoralRoll(thePersonToAdd);
			}
			Console.WriteLine("Datos Cargados");

		}
	}
}
