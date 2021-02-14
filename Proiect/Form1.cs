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
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL="cut.mp3";
            axWindowsMediaPlayer1.URL = "rom.mp4";
            button2.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i++;
            label1.Text=i.ToString();
            if (i == 1)
            {
                label5.Text = "Loading resources";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 2)
            {
                label5.Text = "Loading map";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 3)
            {
                label5.Text = "Loading info";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 4)
            {
                label5.Text = "Loading Banat";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 5)
            {
                label5.Text = "Loading Basarabia";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 6)
            {
                label5.Text = "Loading Bucovina";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 7)
            {
                label5.Text = "Loading Crisana";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 8)
            {
                label5.Text = "Loading Dobrogea";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 9)
            {
                label5.Text = "Loading Maramures";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 10)
            {
                label5.Text = "Loading Moldova";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 11)
            {
                label5.Text = "Loading Muntenia";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 12)
            {
                label5.Text = "Loading Banat";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 13)
            {
                label5.Text = "Loading Oltenia";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 14)
            {
                label5.Text = "Loading Transilvania";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 15)
            {
                label5.Text = "Initializing map";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 16)
            {
                label5.Text = "Initializing info";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 17)
            {

                label5.Text = "Initializing text";
                progressBar1.Value = progressBar1.Value + 5;
            }
            if (i == 18)
            {
                label5.Text = "Initializing program";
                progressBar1.Value = progressBar1.Value + 5;
            }
                if (i == 20)
                {
                    player.controls.stop();
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
