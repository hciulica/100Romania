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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value==0)
            {
                pictureBox1.ImageLocation = "te.png";
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            }
            if(trackBar1.Value==1)
            {
                pictureBox1.ImageLocation = "24ian.png";
                label5.Font = new Font("Calibri", 18, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            
            }
            if(trackBar1.Value==2)
            {
             
                pictureBox1.ImageLocation = "10aug.png";
                label1.Font = new Font("Calibri", 18, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            
            }
            if (trackBar1.Value == 3)
            {
                pictureBox1.ImageLocation = "27mar.png";
                label2.Font = new Font("Calibri", 18, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            
            }
            if (trackBar1.Value == 4)
            {
                pictureBox1.ImageLocation = "28noi.png";
                label3.Font = new Font("Calibri", 18, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            
            }
            if (trackBar1.Value == 5)
            {
                pictureBox1.ImageLocation = "1dec.png";
                label4.Font = new Font("Calibri", 18, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
                label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            }
            if(trackBar1.Value==6)
            {
                pictureBox1.ImageLocation = "23aug.png";
                label6.Font = new Font("Calibri", 18, FontStyle.Bold);
                label4.Font = new Font("Calibri", 12, FontStyle.Bold);
                label1.Font = new Font("Calibri", 12, FontStyle.Bold);
                label2.Font = new Font("Calibri", 12, FontStyle.Bold);
                label3.Font = new Font("Calibri", 12, FontStyle.Bold);
                label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
