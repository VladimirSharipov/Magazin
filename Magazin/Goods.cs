using Magazin.Controller;
using Magazin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
	public partial class Goods : Form
	{
		public Goods()
		{

			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			
			List<HHdModel> hhd = new();
			List<MatcherPlat> Mp = new List<MatcherPlat>();
			hhd = await ControllerDB.GetHHD();
			Mp = await ControllerDB.GetMatherPlat();
			
			dataGridViewTovar.DataSource= hhd;	
			dataGridView1.DataSource= Mp;
			dataGridViewTovar.Columns["description"].Visible = false;
			dataGridView1.Columns["description"].Visible = false;
			dataGridView1.Columns["Name"].Visible = false;
			dataGridViewTovar.Columns["Name"].Visible = false;
			dataGridViewTovar.Columns["ID"].DisplayIndex = 0;
			dataGridViewTovar.Columns[nameof(HHdModel.Model)].DisplayIndex = 1;
			dataGridView1.Columns["ID"].DisplayIndex = 0;
			dataGridView1.Columns[nameof(MatcherPlat.Model)].DisplayIndex = 1;
			//Dictionary<int,string> map = new Dictionary<int,string>();
			//map.Add(1, "sfdasda");
			//map.Add(1, "dasdasdsad");//error  1 значене ключ 
		}

		private void dataGridViewTovar_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
