using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace aaa
{
    public partial class Setting : Form
    {
        public static string SAVE;

        public Setting()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SAVE = comboBox3.Text;


            if (comboBox3.SelectedItem == "Default")
            {
               aaa.Properties.Settings.Default.Theme = "Default";
            }
            if (comboBox3.SelectedItem == "Dark")
            {
                aaa.Properties.Settings.Default.Theme = "Dark";
            }
            if (comboBox3.SelectedItem == "White")
            {
                aaa.Properties.Settings.Default.Theme = "White";
            }
            if (comboBox3.SelectedItem == "Blue")
            {
                aaa.Properties.Settings.Default.Theme = "Blue";
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aaa.Properties.Settings.Default.Theme == "Default")
            {
                this.BackColor = SystemColors.Control;
            }
            if (aaa.Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = SystemColors.ControlDark;
            }
            if (aaa.Properties.Settings.Default.Theme == "White")
            {
                this.BackColor = SystemColors.ControlLightLight;
            }
            if (aaa.Properties.Settings.Default.Theme == "Blue")
            {
                this.BackColor = SystemColors.MenuHighlight;
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 s = new Form1();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 s = new Form1();
            s.Show();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
