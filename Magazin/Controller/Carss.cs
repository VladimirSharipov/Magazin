using Magazin.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Controller
{
	public class Carss : ICars
	{
		public int  GetSpeed(int distans)
		{
			
			return distans / 100;
		}
	}
}
