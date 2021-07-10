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
    public partial class Pending : Form
    {
        public Pending()
        {
            InitializeComponent();
        }
        private void Theme() {

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



        private void Pending_Load(object sender, EventArgs e)
        {
            if (KeepValue.ADD == true) {
                label2.Text = KeepValue.fName;
                label3.Text = KeepValue.surname;
                label4.Text = KeepValue.email;
                label5.Text = KeepValue.pNumber;
                label6.Text = KeepValue.salary;
                label7.Text = KeepValue.ADDRESS;
                label8.Text = KeepValue.jobRole;
                label10.Text = KeepValue.fName;
                pictureBox1.Image = KeepValue.Photos;
                richTextBox1.Text = KeepValue.richText;
            }
            Theme();
            FileStream fs2 = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);

            label2.Text = sr.ReadLine();
            label3.Text = sr.ReadLine();
            label4.Text = sr.ReadLine();
            label5.Text = sr.ReadLine();
            label6.Text = sr.ReadLine();
            label7.Text = sr.ReadLine();
            label8.Text = sr.ReadLine();


            sr.Close();
            fs2.Close();
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            KeepValue.ADD = false;

            foreach (Control c in groupBox1.Controls)
            {
                if (c is Label)
                {

                    c.Text = "";
                    pictureBox1.Image = null;
                    richTextBox1.Text = "";
                }
                
            }
            this.Hide();

            Form1 asa = new Form1();
            asa.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
                DialogResult b;
                b = MessageBox.Show("SUCCESFULLY HIRED", "Message", MessageBoxButtons.OK);
                if (b == DialogResult.OK)
                {


                    Form1 a = new Form1();
                    a.Show();
                }
                KeepValue.hire = button1.Enabled;
            



            KeepValue.ADD = false;

            foreach (Control c in groupBox1.Controls)
            {
                if (c is Label)
                {

                    c.Text = "";
                    pictureBox1.Image = null;
                    richTextBox1.Text = "";
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
