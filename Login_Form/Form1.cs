using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = TextUsername.Text;
            pass = TextPass.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Successful login");

            }
            else
            {
                MessageBox.Show("error in login");
            }
        }
    }
}
