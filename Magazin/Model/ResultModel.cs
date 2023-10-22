using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Model
{
	public class ResultModel
	{
		public bool success { get; set; }
		public int code { get; set; }
		public string reason { get; set; }
		public List<DrugsModel> data { get; set; }
		public string errors { get; set; }
	}
}
