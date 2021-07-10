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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ww = new Form1();
            ww.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ww = new Form1();
            ww.Show();
        }
        private void Colour() {
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

        private void Employee_Load(object sender, EventArgs e)
        {
            if (KeepValue.hire == true) {
                l1.Text = KeepValue.fName;
                l2.Text = KeepValue.surname;
                l3.Text = KeepValue.email;
                l4.Text = KeepValue.pNumber;
                l5.Text = KeepValue.salary;
                l6.Text = KeepValue.ADDRESS;
                l7.Text = KeepValue.jobRole;
                pictureBox1.Image = KeepValue.Photos;
            }

            Colour();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeepValue.hire = false;

            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            l7.Text = "";
            pictureBox1.Image = null;

            




        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
