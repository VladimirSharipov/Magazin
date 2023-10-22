
using Magazin.Controller;
using Magazin.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Form1 : Form
    {
        public Form1(long roles)
        {
			
            InitializeComponent();
			//if(roles == 30)
			//{
			//	btnAdd.Visible = false;
			//	btnReadUsers.Visible = false;
			//}
			//else if(roles== 15) 
			//{
			//	btnAdd.Enabled = false;	
			//}
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            AddUsers a = new();
            a.ShowDialog();

        }
		public async Task  SerchTimeUsers()
		{
			
			List<Model.User> gg = ControllerDB.GetUsers();
			DateTime start = new(dtp3.Value.Year, dtp3.Value.Month, dtp3.Value.Day, 0, 0, 0);
			DateTime end = new(dtp2.Value.Year, dtp2.Value.Month, dtp2.Value.Day, 23, 59, 59);
			List<Model.User> users2 = new();
			users2 = gg.Where(w => w.CreateDate <= start && end <= w.CreateDate).ToList();
			dataGridView1.DataSource = users2;
		}


		private async void btnReadUsers_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				SerchTimeUsers();
			});

			//         string path = "C:\\Users\\user\\ppppppppppppp.xml";
			//         List<User>? users = new();
			//List<User> users2 = new();
			//     users = ControllerDB.XmlDeSerializ(path, typeof(List<User>))as List<User>;
			//         DateTime start = new DateTime(dtp3.Value.Year, dtp3.Value.Month, dtp3.Value.Day,0,0,0);
			//DateTime end = new DateTime(dtp2.Value.Year, dtp2.Value.Month, dtp2.Value.Day, 23, 59, 59);
			//users2 = users.Where(w => w.CreateDate  >= start && end >= w.CreateDate).ToList();
			//dataGridView1.DataSource = users2;
			
		   
			//List<Model.User> gg = ControllerDB.GetUsers();
			//DateTime start = new(dtp3.Value.Year, dtp3.Value.Month, dtp3.Value.Day, 0, 0, 0);
			//DateTime end = new(dtp2.Value.Year, dtp2.Value.Month, dtp2.Value.Day, 23, 59, 59);
			//List<Model.User> users2 = new();
			//users2 = gg.Where(w => w.CreateDate >= start && end >= w.CreateDate).ToList();
			//dataGridView1.DataSource = users2;
			//List<DrugsModel> a = ControllerAPI.SerchDrugs(textBox1.Text);
			//dataGridView1.DataSource = a;
			//using есть или нет using sreamwriter where (path){where.write datetime.now

			//string path = "C:\\Users\\user\\ppppppppppppp.txt";
			//if (File.Exists(path))//есть такой файл
			//{
			//	File.Delete(path);//удалить файл 

			//}
			//using (FileStream m = File.OpenWrite(path))
			//{
			//	string error = $"{DateTime.Now.ToString()}  {ohubka}";
			//	using(StreamWriter sr = new StreamWriter(m))
			//	{
			//		sr.WriteLine(error);
			//	}

			//}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Goods a = new Goods();
			//a.ShowDialog();
			
			//List<SerchTimeTovarModel> a = ControllerAPI.GetSerchTime(dtp2.Value, dtp3.Value);
			//dataGridView1.DataSource = a;
		}
	}
}