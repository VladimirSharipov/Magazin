using Magazin.Controller;
using Magazin.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Magazin
{
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            //int i=0;

            User b =new();
            b.Name = txtBxName.Text;
            b.Login = txtBxLogin.Text;
            b.Password = txtBxPass.Text;
            b.CreateDate = dateTimePicker1.Value;
			
			List<User> list = new List<User>();

            //string path = "C:\\Users\\user\\ppppppppppppp.xml";

            //list = ControllerDB.XmlDeSerializ(path, typeof(List<User>)) as List<User>;

            //         if (list == null)
            //         {
            //            list = new List<User>();
            //             b.Id = 1;
            //             list.Add(b);
            //         }
            //         else
            //         {
            //	i = list.Max(w => w.Id);
            //	b.Id = i+1;
            //	list.Add(b);
            //}


            //if(ControllerDB.XmlSerializ(typeof(List<User>), path, list))
            //         {
            //             MessageBox.Show("polzoavatel dobavlen");

            //         }
            ControllerDB.InsUSers(b);
        }
    }
}
