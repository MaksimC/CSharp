using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (new Form2().ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Text", "ERROR!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Other text");
            }

        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }
    }
}
