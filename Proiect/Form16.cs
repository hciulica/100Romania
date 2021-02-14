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
    public partial class Form16 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        WindowsMediaPlayer player3 = new WindowsMediaPlayer();
        public Form16()
        {
            InitializeComponent();
            player.SoundLocation = "applause.wav";
            player1.SoundLocation = "buzz.wav";
            player2.SoundLocation = "error.wav";
            player3.URL = "dest.mp3";
        }
        int i, contor;
        bool[] v = new bool[11];
        int min = 10;
        int sec = 0;
        bool ok = false;
        private void Form16_Load(object sender, EventArgs e)
        {
            i = 1;
            listBox1.Items.Add(" Cati ani sarbatorim de la Marea Unire ?                                      ");
            radioButton1.Text = "a) 100 ani";
            radioButton2.Text = "b) 99 ani";
            radioButton3.Text = "c) 95 ani";
            radioButton4.Text = "d) 75 ani";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button2.Hide();
            player3.controls.stop();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player2.Play();
            if(ok==false)
            MessageBox.Show("Nu puteti sa va duceti pe pagina principala pana cand testul nu este completat in totalitate !", "Eroare !");
            else
            {
                this.Hide();
                var form8 = new Form8();
                form8.Closed += (s, args) => this.Close();
                form8.Show();
                player3.controls.stop();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i == 1)
            {
                if (radioButton1.Checked == true)
                {
                    v[i] = true;
                    textBox1.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox1.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 2)
            {
                if (radioButton2.Checked == true)
                {
                    v[i] = true;
                    textBox2.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox2.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 3)
            {
                if (radioButton1.Checked == true)
                {
                    v[i] = true;
                    textBox3.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox3.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 4)
            {
                if (radioButton3.Checked == true)
                {
                    v[i] = true;
                    textBox4.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox4.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 5)
            {
                if (radioButton1.Checked == true)
                {
                    v[i] = true;
                    textBox5.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox5.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 6)
            {
                if (radioButton4.Checked == true)
                {
                    v[i] = true;
                    textBox6.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox6.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 7)
            {
                if (radioButton1.Checked == true)
                {
                    v[i] = true;
                    textBox7.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox7.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 8)
            {
                if (radioButton2.Checked == true)
                {
                    v[i] = true;
                    textBox8.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox8.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 9)
            {
                if (radioButton1.Checked == true)
                {
                    v[i] = true;
                    textBox9.BackColor = System.Drawing.Color.Green;
                    player.Play();
                }
                else
                {
                    v[i] = false;
                    textBox9.BackColor = System.Drawing.Color.Red;
                    player1.Play();
                }
            }
            if (i == 10)
            {
                if (radioButton3.Checked == true)
                {
                    v[i] = true;
                    textBox10.BackColor = System.Drawing.Color.Green;
                    player3.controls.play();
                }
                else
                {
                    v[i] = false;
                    textBox10.BackColor = System.Drawing.Color.Red;
                    player3.controls.play();
                }
                contor = 0;
                for (int j = 1; j <= 10; j++)
                    if (v[j] == true)
                        contor++;
                listBox1.Items.Clear();
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("----------------------------Ati acumulat " + contor + " puncte.-------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                ok = true;
                
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                player2.Play();
                MessageBox.Show("Trebuie sa selectati un raspuns !", "Eroare !");

            }
            else
            {
                i++;
                if (i == 2)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Cum s-a realizat Romania Intregita ?                                     ");
                    radioButton1.Text = "a) prin unirea Basarabiei cu Romania";
                    radioButton2.Text = "b) prin unirea Basarabiei, a Bucovinei si a Transilvaniei cu Romania";
                    radioButton3.Text = "c) prin unirea Bucovinei cu Romania";
                    radioButton4.Text = "d) prin unirea Basarabiei si Transilvaniei cu Romania";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 3)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("La ce data s-a votat unirea Basarabiei cu Romania ?                                    ");
                    
                    radioButton1.Text = "a) 27 martie 1918";
                    radioButton2.Text = "b) 28 noiembrie 1918";
                    radioButton3.Text = "c) 24 ianuarie 1859";
                    radioButton4.Text = "d) 1 decembrie 1918";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 4)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("La ce data s-a votat unirea Bucovinei cu Romania ?                                    ");
                    radioButton1.Text = "a) 1 decembrie 1918";
                    radioButton2.Text = "b) 27 martie 1918";
                    radioButton3.Text = "c) 28 noiembrie 1918";
                    radioButton4.Text = "d) 10 august 1913";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 5)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Unde a avut loc Marea Adunare Nationala de la 1 Decembrie 1918 ?                                     ");
                    radioButton1.Text = "a) Alba Iulia";
                    radioButton2.Text = "b) Bucuresti";
                    radioButton3.Text = "c) Iasi";
                    radioButton4.Text = "d) Timisoara";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 6)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Cati participanti au fost la Marea Adunare Nationala de la Alba");
                    listBox1.Items.Add("Iulia ?");
                    radioButton1.Text = "a) 250 000 participanti";
                    radioButton2.Text = "b) 500 000 de participanti";
                    radioButton3.Text = "c) 1 000 000 participanti";
                    radioButton4.Text = "d) peste 100 000 de participanti";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 7)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("La ce data s-a unit Transilvania, Banat, Crisana si Maramuresul ");
                    listBox1.Items.Add("cu Romania ? ");
                    radioButton1.Text = "a) 1 decembrie 1918";
                    radioButton2.Text = "b) 27 martie 1918";
                    radioButton3.Text = "c) 28 noiembrie 1918";
                    radioButton4.Text = "d) 23 august 1913";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 8)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Cand s-a inceput procesul de faurire a Statului National Unitar Roman ? ");    
                    radioButton1.Text = "a) 1918";
                    radioButton2.Text = "b) 1859";
                    radioButton3.Text = "c) 1913";
                    radioButton4.Text = "d) 1900";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 9)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Care a fost suprafata Romaniei Mari ?");
                    radioButton1.Text = "a) 295 049 km patrati";
                    radioButton2.Text = "b) 300 000 km patrati";
                    radioButton3.Text = "c) 197 123 km patrati";
                    radioButton4.Text = "d) 395 298 km patrati";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
                if (i == 10)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Care a fost populatia Romaniei Mari ?                                     ");
                    radioButton1.Text = "a) 12 000 000 de locuitori";
                    radioButton2.Text = "b) 17 500 000 de locuitori";
                    radioButton3.Text = "c) 16 500 000 de locuitori";
                    radioButton4.Text = "d) 22 800 000 de locuitori";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    button1.Text = "Finalizare test";

                }
                if (i == 11)
                {
                    button1.Hide();
                    button2.Show();
                    groupBox1.Hide();
                    timer1.Stop();
                    i--;


                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (min == 0 && sec == 0)
            {
                timer1.Stop();
                MessageBox.Show("Timpul a expirat !");
                button1.Hide();
                button2.Show();
                groupBox1.Hide();
                contor = 0;
                for (int j = 1; j <= 10; j++)
                    if (v[j] == true)
                        contor++;
                listBox1.Items.Clear();
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("------------------------------Ati acumulat " + contor + " puncte.-------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                
            }
            else
                if (sec == 0)
                {
                    min--;
                    sec = 59;
                }
                else
                    sec--;
            if (sec >= 10)
                textBox11.Text = "0" + min.ToString() + ":" + sec.ToString();
            else
                textBox11.Text = "0" + min.ToString() + ":" + "0" + sec.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form8 = new Form8();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
            player3.controls.stop();
        }
    }
}
