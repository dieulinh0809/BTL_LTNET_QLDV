using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_LTNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát khỏi hệ thống không ?",
                "Hỏi ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }
        //Tao Ket Noi 
        string str = @"Data Source=DESKTOP-2FTO78K;Initial Catalog=CGV05;Integrated Security=True;Trust Server Certificate=True";

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
