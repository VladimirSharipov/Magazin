using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Model
{
    internal class MatcherPlat:BaseModel
    {

        public short Opp { get; set; }	
        public string Model { get; set; }
		public TypeMp Type { get; set; }


	}
	public enum TypeMp
	{
		classic = 0,
		Noytbook = 1
	}
}

