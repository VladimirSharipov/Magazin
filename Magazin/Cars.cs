using AngleSharp.Dom;
using Magazin.Controller;
using Magazin.InterFaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
	public partial class Cars : Form
	{
		public Cars()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//var cars = new List<ICars>();
			//cars.Add(new Carss());
			//cars.Add(new Terminator());
			//foreach (var car in cars)
			//{
			//	label1.Text = label1.Text +"\r\n"+ car.GetSpeed(200).ToString();
			//}
			Zaproc("https://www.youtube.com/watch?v=3kt74Nl0dIs", "Youtube");
			MessageBox.Show("a");
		}
		public async Task Zaproc(string url, string Name)
		{
			WebClient client = new();

			client.DownloadFileAsync(new Url(url), $"C:\\Users\\user\\{Name}.avi");
			System.Diagnostics.Process.Start(string.Format("https://www.youtube.com/watch?v=3kt74Nl0dIs"));
		}
	}
}
