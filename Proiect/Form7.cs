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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label2.Location);
            pos = pictureBox1.PointToClient(pos);
            label2.Parent = pictureBox1;
            label2.Location = pos;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            var pos1 = this.PointToScreen(label3.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label3.Parent = pictureBox1;
            label3.Location = pos1;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Transparent;
            var pos2 = this.PointToScreen(label4.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label4.Parent = pictureBox1;
            label4.Location = pos2;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Transparent;
            var pos3 = this.PointToScreen(label5.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            label5.Parent = pictureBox1;
            label5.Location = pos3;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Transparent;
            var pos4 = this.PointToScreen(label6.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            label6.Parent = pictureBox1;
            label6.Location = pos4;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Transparent;
            var pos5 = this.PointToScreen(label7.Location);
            pos5 = pictureBox1.PointToClient(pos5);
            label7.Parent = pictureBox1;
            label7.Location = pos5;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Transparent;
            var pos6 = this.PointToScreen(label8.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            label8.Parent = pictureBox1;
            label8.Location = pos6;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.Transparent;
            var pos7 = this.PointToScreen(label9.Location);
            pos7 = pictureBox1.PointToClient(pos7);
            label9.Parent = pictureBox1;
            label9.Location = pos7;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.Transparent;
            var pos8 = this.PointToScreen(label10.Location);
            pos8 = pictureBox1.PointToClient(pos8);
            label10.Parent = pictureBox1;
            label10.Location = pos8;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.Transparent;
            var pos9 = this.PointToScreen(label11.Location);
            pos9 = pictureBox1.PointToClient(pos9);
            label11.Parent = pictureBox1;
            label11.Location = pos9;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.Transparent;
            var pos10 = this.PointToScreen(label12.Location);
            pos10 = pictureBox1.PointToClient(pos10);
            label12.Parent = pictureBox1;
            label12.Location = pos10;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.Transparent;
            var pos11 = this.PointToScreen(label13.Location);
            pos11 = pictureBox1.PointToClient(pos11);
            label13.Parent = pictureBox1;
            label13.Location = pos11;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = Color.Transparent;
            var pos12 = this.PointToScreen(label14.Location);
            pos12 = pictureBox1.PointToClient(pos12);
            label14.Parent = pictureBox1;
            label14.Location = pos12;
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.Transparent;
            var pos13 = this.PointToScreen(label15.Location);
            pos13 = pictureBox1.PointToClient(pos13);
            label15.Parent = pictureBox1;
            label15.Location = pos13;
            label15.BackColor = Color.Transparent;
            label15.ForeColor = Color.Transparent;
            var pos14 = this.PointToScreen(label16.Location);
            pos14 = pictureBox1.PointToClient(pos14);
            label16.Parent = pictureBox1;
            label16.Location = pos14;
            label16.BackColor = Color.Transparent;
            label16.ForeColor = Color.Transparent;
            var pos15 = this.PointToScreen(label17.Location);
            pos15 = pictureBox1.PointToClient(pos15);
            label17.Parent = pictureBox1;
            label17.Location = pos15;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Transparent;

            var pos16 = this.PointToScreen(label18.Location);
            pos16 = pictureBox1.PointToClient(pos16);
            label18.Parent = pictureBox1;
            label18.Location = pos16;
            label18.BackColor = Color.Transparent;
            label18.ForeColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Closed += (s, args) => this.Close();
            form17.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form18 = new Form18();
            form18.Closed += (s, args) => this.Close();
            form18.Show();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form18 = new Form18();
            form18.Closed += (s, args) => this.Close();
            form18.Show();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Closed += (s, args) => this.Close();
            form17.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form18 = new Form18();
            form18.Closed += (s, args) => this.Close();
            form18.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form21 = new Form21();
            form21.Closed += (s, args) => this.Close();
            form21.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form21 = new Form21();
            form21.Closed += (s, args) => this.Close();
            form21.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form21 = new Form21();
            form21.Closed += (s, args) => this.Close();
            form21.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form20 = new Form20();
            form20.Closed += (s, args) => this.Close();
            form20.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form20 = new Form20();
            form20.Closed += (s, args) => this.Close();
            form20.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form19 = new Form19();
            form19.Closed += (s, args) => this.Close();
            form19.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form19 = new Form19();
            form19.Closed += (s, args) => this.Close();
            form19.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Closed += (s, args) => this.Close();
            form17.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Closed += (s, args) => this.Close();
            form17.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form17 = new Form17();
            form17.Closed += (s, args) => this.Close();
            form17.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form14 = new Form14();

            form14.Show();
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

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form18 = new Form18();
            form18.Closed += (s, args) => this.Close();
            form18.Show();

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form18 = new Form18();
            form18.Closed += (s, args) => this.Close();
            form18.Show();

        }
    }
}
