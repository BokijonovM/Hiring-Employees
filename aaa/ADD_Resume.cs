using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;


namespace aaa
{
    public partial class ADD_Resume : Form
    {
        



        public ADD_Resume()
        {
            InitializeComponent();
        }

        private void ADD_Resume_Load(object sender, EventArgs e)
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
        private void ENTER() {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name!");

            }
            else if (textBox2.Text == "")
            {

                MessageBox.Show("Please enter your Surname!");

            }
            else if (textBox3.Text == "")
            {

                MessageBox.Show("Please enter your Email!");

            }
            else if (textBox4.Text == "")
            {

                MessageBox.Show("Please enter your Phone Number!");

            }
            else if (textBox5.Text == "")
            {

                MessageBox.Show("Please enter your Expecting Salary!");

            }
            else if (textBox7.Text == "")
            {

                MessageBox.Show("Please enter your Address!");

            }
            else if (comboBox2.Text == "")
            {

                MessageBox.Show("Please select your Job Role!");

            }
            else if (pictureBox1.Image == null)
            {

                MessageBox.Show("Please add your Picture!");

            }
            else if (richTextBox1.Text == "")
            {

                MessageBox.Show("Please attach your CV!");

            }
            else
            {

                this.Hide();






                DialogResult b;
                b = MessageBox.Show("SUCCESFULLY ADDED", "Message", MessageBoxButtons.OK);
                if (b == DialogResult.OK)
                {
                  

                    Form1 a = new Form1();
                    a.Show();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            
            




            ENTER();
            
            KeepValue.fName = textBox1.Text;
            KeepValue.surname = textBox2.Text;
            KeepValue.email = textBox3.Text;
            KeepValue.pNumber = textBox4.Text;
            KeepValue.salary = textBox5.Text;
            KeepValue.ADDRESS = textBox7.Text;
            KeepValue.jobRole = comboBox2.Text;
            KeepValue.richText = richTextBox1.Text;
            KeepValue.Photos = pictureBox1.Image;
            KeepValue.ADD = btnAdd.Enabled;

            FileStream fs = new FileStream("data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(KeepValue.fName);
            sw.WriteLine(KeepValue.surname);
            sw.WriteLine(KeepValue.email);
            sw.WriteLine(KeepValue.pNumber);
            sw.WriteLine(KeepValue.salary);
            sw.WriteLine(KeepValue.ADDRESS);
            sw.WriteLine(KeepValue.jobRole);
            sw.WriteLine(KeepValue.richText);

            sw.Close();
            fs.Close();
           

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);
            }
            
        }

        private void btnAddCV_Click(object sender, EventArgs e)
        {
            Stream mySttream;
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "CV (*.txt;)|*.txt;";
            if (open1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if ((mySttream = open1.OpenFile()) != null)
                {

                    string strfilename = open1.FileName;
                    string fileText = File.ReadAllText(strfilename);

                    richTextBox1.Text = fileText;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox7.Text = "";
            comboBox2.Text = null;
            pictureBox1.Image = null;
            richTextBox1.Text = "";

        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 a = new Form1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
