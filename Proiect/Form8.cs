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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "blue.jpg";
            
            

            button5.Hide();
            button7.Hide(); 
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            pictureBox2.ImageLocation = "g.png";
            pictureBox3.ImageLocation = "r.png";
            button3.Show();

            button4.Show();

            button6.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button6.Hide();
            pictureBox1.ImageLocation = "a.png";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form13 = new Form13();
            form13.Closed += (s, args) => this.Close();
            form13.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "yellow.jpg";

            

            button3.Hide();
            button4.Hide();
            button6.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            pictureBox1.ImageLocation = "a.png";
            pictureBox3.ImageLocation = "r.png";
            button5.Show();

            button7.Show();

            button8.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Hide();
            button7.Hide();
            button8.Hide();
            pictureBox2.ImageLocation = "g.png";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button10.Hide();
            button11.Hide();
            pictureBox3.ImageLocation = "r.png";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "red.jpg";

           
            button3.Hide();
            button4.Hide();
            button6.Hide();
            button5.Hide();
            button7.Hide();
            button8.Hide();
            pictureBox1.ImageLocation = "a.png";
            pictureBox2.ImageLocation = "g.png";
            button9.Show();

           

            button11.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new Form9();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form7 = new Form7();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form15 = new Form15();
            form15.Closed += (s, args) => this.Close();
            form15.Show();
        }
    }
}
