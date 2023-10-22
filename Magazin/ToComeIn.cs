using Magazin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class ToComeIn : Form
    {
        public ToComeIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          

            string Login = txtBx1.Text;
            string Password = txtbx2.Text;
            long roles = 0;
            
            if(ControllerDB.Login(Login, Password, out roles ))
            {
				Helper.Info($"login={Login},Roles={roles}");
				Form1 a = new(roles);
				a.ShowDialog();
                
            }
            else
            {
				MessageBox.Show("неправильный логин или пароль ");
			}

        }
    }
}
