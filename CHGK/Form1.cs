using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CHGK
{
    public partial class Form1 : Form
    {
        Timer minute = new Timer();
        Timer blitz = new Timer();
        MediaPlayer mpl = new MediaPlayer();
        Uri intro = new Uri(@"..\Intro.mp3", UriKind.Relative);
        Uri first = new Uri(@"..\50sec.wav");
        Uri second = new Uri(@"..\60sec.wav");
        Uri gong = new Uri(@"..\gong.mp3");
        Uri tea = new Uri(@"..\Tea Ceremony.mp3");
        bool istick = true;
        static int a = 0, b = 0;

        public Form1()
        {
            InitializeComponent();
            minute.Tick += new EventHandler(seconds50);
            mpl.Open(intro);
            mpl.Play();
            blitz.Interval = 20000;
        }

        void seconds50(object sourse, EventArgs e)
        {
            var player = new MediaPlayer();
            player.Play();
            if (istick)
            {
                istick = false;
                player.Open(first);
                minute.Interval = 10000;
            }
            else
            {
                istick = true;
                player.Open(second);
                sec20.Enabled = true;
                sec60.Text = "60 sec";
                minute.Stop();
            }
        }
        void seconds20(object sourse, EventArgs e)
        {
            var player = new MediaPlayer();
            player.Play();
            player.Open(second);
            sec60.Enabled = true;
            sec20.Text = "20 sec";
            blitz.Stop();
        }

        private void sec60_Click(object sender, EventArgs e)
        {
            if (!minute.Enabled)
            {
                mpl.Open(second);
                mpl.Play();
                minute.Interval = 50000;
                sec20.Enabled = false;
                sec60.Text = "Stop";
                minute.Start();
            }
            else
            {
                sec20.Enabled = true;
                sec60.Text = "60 sec";
                minute.Stop();
            }
        }
        private void sec20_Click(object sender, EventArgs e)
        {
            if (!blitz.Enabled)
            {
                mpl.Open(second);
                mpl.Play();
                sec60.Enabled = false;
                sec20.Text = "Stop";
                blitz.Start();
            }
            else
            {
                sec60.Enabled = true;
                sec20.Text = "20 sec";
                blitz.Stop();
            }
        }

        private void zn_Click(object sender, EventArgs e)
        {
            a = ++a % 7;
            label1.Text = a.ToString();
        }
        private void tl_Click(object sender, EventArgs e)
        {
            b = ++b % 7;
            label2.Text = b.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            a = --a % 7;
            label1.Text = a.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            b = --b % 7;
            label2.Text = b.ToString();
        }

        private void gong_Click(object sender, EventArgs e)
        {
            mpl.Open(gong);
            mpl.Play();
        }
        private void tea_Click(object sender, EventArgs e)
        {
            mpl.Open(tea);
            mpl.Play();
        }
    }
}