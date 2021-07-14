
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


	}




}
