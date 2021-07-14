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

			Operations theOperations = new Operations(theLoader.TheElectoralRoll);

			theOperations.PrintMenu();

			Boolean onOff = true;
			int selectedOption;
			
			while (onOff)
			{
				selectedOption = Console.Read();
				switch (selectedOption)
				{
					case 1:
						theOperations.CalculateTopLongerNames();
						break;
					case 2:
						theOperations.CalculateLessCommonName();
						break;
					case 3:
						theOperations.CalculateDistrictWithLessElectors();
						break;
					case 4:
						theOperations.CalculateDistrictWithMoreElectors();
						break;
					case 5:
						theOperations.PrintTheElectoralRoll();
						break;

					case 6: 
						onOff = false;
						break;
					default: break;
				}

			}
			

			



		}
	}
}
