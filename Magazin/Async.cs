using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
	public partial class Async : Form
	{
		public Async()
		{
			InitializeComponent();
		}
		public async Task podchet()
		{
			int i = 1;

			await Task.Run(() =>
			{
				while (i <= 100)
				{
					//lb.Text = i.ToString();
					
					Task.Delay(100).Wait();
					i++;

				}
				//lb.Text = i.ToString();
			});
			
		}
		private async void btn1_Click(object sender, EventArgs e)
		{

			 podchet();
			
			label1.Text = "konec";
		}
	}
}
