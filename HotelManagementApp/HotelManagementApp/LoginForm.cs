using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            catch(Exception hh)
            {
                MessageBox.Show("Silahkan masukkan username dan password dengan benar");
            }
        }
    }
}
