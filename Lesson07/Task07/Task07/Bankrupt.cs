using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
	sealed class Bankrupt:ApplicationException
	{
		public Bankrupt(string message) : base(message)
		{

		}
	}
}
