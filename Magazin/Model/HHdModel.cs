using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Model
{
    public class HHdModel: BaseModel
	{
        public int Gb { get; set; }
        public string Model { get; set; }
        public TypeHHD Type { get; set; }


    }
    public enum TypeHHD
    {
        classic  = 0,
        Noytbook  = 1
    }
}
