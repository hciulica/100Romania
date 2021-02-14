using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Proiect
{
    
    public partial class Form12 : Form
    {
        int[] ok = new int[100];

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form12()
        {
            InitializeComponent();
            player.URL = "steag.mp3";
            this.button2.MouseHover += button2_MouseHover;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            player.controls.stop();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form8 = new Form8();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            player.controls.stop();

            this.button2.Image = new Bitmap("sol.png");
        }
        
        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Ascultati cantecul patriotic 'Pe-al nostru steag e scris unire', cantat de multime la Marea Adunare Nationala");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.play();
            for(int i=2;i<=100;i++)
            {
                if(i%2==0)
                    player.controls.stop();
                if (i % 2 != 0)
                {
                   
                    player.controls.play();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form14 = new Form14();

            form14.Show();
        }
    }
}
