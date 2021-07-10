using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaa
{
    public partial class page1 : Form
    {
        public page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddResume_Click(object sender, EventArgs e)
            
           
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void page1_Load(object sender, EventArgs e)
        {
            if (Setting.SAVE == "Default")
            {
                this.BackColor = SystemColors.Control;

            }
            if (Setting.SAVE == "Dark")
            {
                this.BackColor = SystemColors.ControlDark;

            }
            if (Setting.SAVE == "White")
            {
                this.BackColor = SystemColors.ControlLightLight;

            }
            if (Setting.SAVE == "Blue")
            {
                this.BackColor = SystemColors.MenuHighlight;

            }
        }
    }
}
