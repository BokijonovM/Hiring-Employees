using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace aaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddResume_Click(object sender, EventArgs e)
        {
            this.Hide();

            ADD_Resume a = new ADD_Resume();
            a.Show();

            
        }

        private void btnPendingResume_Click(object sender, EventArgs e)
        {
           

            if (KeepValue.ADD == true)
            {


                this.Hide();
                Pending b = new Pending();
                b.Show();
            }
            else {
                MessageBox.Show("There is not any Pending resume");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting ew = new Setting();
            ew.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (KeepValue.hire == true)
            {
                this.Hide();
                Employee ee = new Employee();
                ee.Show();
            }
            else {
                MessageBox.Show("There is not any Employee");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Are you sure? ", "Message", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            page1 aa = new page1();
            aa.Show();
        }
    }
}
