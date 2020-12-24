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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            } catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewRoom anr = new AddNewRoom();
                anr.Show();
            }catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }

        }
    }
}
