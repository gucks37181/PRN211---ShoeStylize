using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStylize
{
    public partial class ProviderManage : Form
    {
        public ProviderManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageBrand manageBrand = new ManageBrand();
            manageBrand.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageShoe manageShoe = new ManageShoe();
            manageShoe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageSize manageSize = new ManageSize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
