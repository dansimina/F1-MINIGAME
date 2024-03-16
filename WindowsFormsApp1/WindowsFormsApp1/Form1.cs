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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Hide();
            button6.Hide();

            axWindowsMediaPlayer1.URL = @"poze/muzica.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.volume = 20;
            axWindowsMediaPlayer1.settings.setMode("Loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = 0;
            r = int.Parse(File.ReadAllText(@"files/save.txt"));
            MessageBox.Show(r.ToString() + " POINTS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Show();
            button6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"files/save.txt", 0.ToString());

            button4.Show();
            button5.Hide();
            button6.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Show();
            button5.Hide();
            button6.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Controls:\n" +
                "   Accelerate: W\n" +
                "   Brake: S\n" +
                "   Steer left: A\n" +
                "   Steer right: D\n");
        }
    }
}
