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
    public partial class AddNewRoom : Form
    {
        Function fn = new Function();
        string query;
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            lblRoom.Visible = false;
            lblRoomExist.Visible = false;

            query = "select * from Tb_Room ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query="select * from Tb_Room where roomNo = "+TbNewRoom.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                if (cbAoN1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                lblRoomExist.Visible = false;
                query = "insert into room(roomNo,roomStatus) values (" + TbNewRoom.Text + ",'" + status + "')";
                fn.setData(query, "Room Added. ");
                AddNewRoom_Load(this,null);
            }
            else
            {
                lblRoomExist.Text = "Room All ready Exist"; 
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            query = "select * from Tb_Room where roomNo=" + TbUpdateRoom + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblRoom.Text = "No room Exist!";
                lblRoom.Visible = true;
                cbAoN2.Checked = false;
            }
            else
            {
                lblRoom.Text = "Room Found.";
                lblRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    cbAoN2.Checked = true;
                }
                else
                {
                    cbAoN2.Checked = false;
                }
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string status;
            if (cbAoN2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update room set roomStatus = '" + status + "' where roomNo=" + cbAoN2.Text + "";
            fn.setData(query, "Details Updated. ");
            AddNewRoom_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lblRoom.Text=="Room Found.")
            {
                query = "delete from room where roomNo=" + TbUpdateRoom + "";
                fn.setData(query, "Room Details deleted.");
                AddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Data yang dihapus tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
