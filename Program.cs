using PadronElectoral.Model;

using System;
using System.Collections.Generic;


using PadronElectoralV2.Data;
using PadronElectoralV2.Logic;

namespace PadronElectoralV2
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Loader theLoader = new Loader();
			theLoader.LoadFile();
                        // Implementar interface en Loader, por el tipo de accion
			Operations theOperations = new Operations(theLoader.TheElectoralRoll);
			
			

		}
	}
}
