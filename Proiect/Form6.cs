using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form6 : Form
    {
        int i = 1;
        public Form6()
        {
            InitializeComponent();
            
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if(i==1)
            {
                pictureBox1.ImageLocation = "Basarabia.png";
            label3.Text = "UNIREA BASARABIEI CU ROMANIA";
            label3.ForeColor = System.Drawing.Color.Blue;
            }
            if(i==2)
            {
                pictureBox1.ImageLocation = "Bucovina.png";
                label3.Text = "UNIREA BUCOVINEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Yellow;
            }
            if(i==3)
            {
                pictureBox1.ImageLocation = "Transilvania.png";
                label3.Text = "UNIREA TRANSILVANIEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Red;
            }
            if (i == 4)
            {
                i = 1;
                pictureBox1.ImageLocation = "Basarabia.png";
                label3.Text = "UNIREA BASARABIEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Blue;
            }  
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = "Basarabia.png";
            label3.Text = "UNIREA BASARABIEI CU ROMANIA";
            label3.ForeColor = System.Drawing.Color.Blue;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                pictureBox1.ImageLocation = "Basarabia.png";
                label3.Text = "UNIREA BASARABIEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Blue;
                
                
            }
            if (i == 2)
            {
                pictureBox1.ImageLocation = "Transilvania.png";
                label3.Text = "UNIREA TRANSILVANIEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Red;
                
            }
            if (i == 3)
            {
                pictureBox1.ImageLocation = "Bucovina.png";
                label3.Text = "UNIREA BUCOVINEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Yellow;
            }
            if (i == 4)
            {
                i = 1;
                pictureBox1.ImageLocation = "Basarabia.png";
                label3.Text = "UNIREA BASARABIEI CU ROMANIA";
                label3.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form7 = new Form7();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(label3.Text == "UNIREA BASARABIEI CU ROMANIA")
            {
                this.Hide();
                var form10 = new Form10();
                form10.Closed += (s, args) => this.Close();
                form10.Show();

            }
            if(label3.Text=="UNIREA BUCOVINEI CU ROMANIA")
            {
                this.Hide();
                var form11 = new Form11();
                form11.Closed += (s, args) => this.Close();
                form11.Show();
            }
            if (label3.Text == "UNIREA TRANSILVANIEI CU ROMANIA")
            {
                this.Hide();
                var form12 = new Form12();
                form12.Closed += (s, args) => this.Close();
                form12.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form8 = new Form8();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form14 = new Form14();

            form14.Show();
        }
    }
}
