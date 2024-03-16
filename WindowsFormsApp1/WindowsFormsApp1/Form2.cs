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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        const int w = 600, h = 780;
        double d = 1.6;
        int pcnt = 1;
        int s = 10;
        int ok = 0;
        int ds = 5;
        int p;
        int bp;
        Random r = new Random();

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Hide();
            car.Hide();
            e1.Hide();
            e2.Hide();
            e3.Hide();
            label1.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();

            pictureBox13.BackgroundImage = Image.FromFile(@"poze\imag" + pcnt.ToString() + ".png");
            pictureBox14.BackgroundImage = Image.FromFile(@"poze\flag.png");
            pictureBox15.BackgroundImage = Image.FromFile(@"poze\trophy.png");
            e1.BackgroundImage = Image.FromFile(@"poze\ze1.png");
            e2.BackgroundImage = Image.FromFile(@"poze\ze2.png");
            e3.BackgroundImage = Image.FromFile(@"poze\ze3.png");

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

            label7.Hide();
            label8.Hide();

            label8.TextAlign = ContentAlignment.MiddleLeft;

            bp = int.Parse(File.ReadAllText(@"files/save.txt"));
        }


        void save()
        {

            File.WriteAllText(@"files/save.txt", bp.ToString());

        }

        void speed(int v)
        {
            label3.Text = (v * 10).ToString();
        }

        void movee(int v)
        {

            int x;

            if (e1.Top < h) e1.Top += v;
            else
            {
                x = r.Next(10, (int)(w / 3 - 10) - e1.Width);

                e1.Location = new Point(x, 0);
            }

            if (e2.Top < h) e2.Top += (int)(v * 1.2);
            else
            {
                x = r.Next((int)(w / 3), (int)(2 * (w / 3) - 5) - e2.Width);

                e2.Location = new Point(x, 0);
            }

            if (e3.Top < h) e3.Top += (int)(v * 1.5);
            else
            {
                x = r.Next((int)(2 * (w / 3) + 5), w - e3.Width - 10);

                e3.Location = new Point(x, 0);
            }
        }

        void move(int v)
        {
            const int c = 120;
            int e = (int)(v);

            if (pictureBox1.Top + e < h) pictureBox1.Top += v;
            else pictureBox1.Top = -c;

            if (pictureBox2.Top + e < h) pictureBox2.Top += v;
            else pictureBox2.Top = -c;

            if (pictureBox3.Top + e < h) pictureBox3.Top += v;
            else pictureBox3.Top = -c;

            if (pictureBox4.Top + e < h) pictureBox4.Top += v;
            else pictureBox4.Top = -c;

            if (pictureBox5.Top + e < h) pictureBox5.Top += v;
            else pictureBox5.Top = -c;

            if (pictureBox6.Top + e < h) pictureBox6.Top += v;
            else pictureBox6.Top = -c;

            if (pictureBox7.Top + e < h) pictureBox7.Top += v;
            else pictureBox7.Top = -c;

            if (pictureBox8.Top + e < h) pictureBox8.Top += v;
            else pictureBox8.Top = -c;

            if (pictureBox9.Top + e < h) pictureBox9.Top += v;
            else pictureBox9.Top = -c;

            if (pictureBox10.Top + e < h) pictureBox10.Top += v;
            else pictureBox10.Top = -c;

            if (pictureBox11.Top + e < h) pictureBox11.Top += v;
            else pictureBox11.Top = -c;

            if (pictureBox12.Top + e < h) pictureBox12.Top += v;
            else pictureBox12.Top = -c;

        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(e1.Bounds))
            {
                timer1.Stop();
                label1.Show();
                pictureBox14.Show();
                button3.Show();
                button2.Hide();
                ok = 1;

                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();

                if (p > bp)
                {
                    bp = p;
                    label7.Show();
                    label8.Text = bp.ToString();
                    label8.Show();
                    pictureBox15.Show();
                }


            }

            if (car.Bounds.IntersectsWith(e2.Bounds))
            {
                timer1.Stop();
                label1.Show();
                pictureBox14.Show();
                button3.Show();
                button2.Hide();
                ok = 1;

                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();

                if (p > bp)
                {
                    bp = p;
                    label7.Show();
                    label8.Text = bp.ToString();
                    label8.Show();
                    pictureBox15.Show();
                }
            }

            if (car.Bounds.IntersectsWith(e3.Bounds))
            {
                timer1.Stop();
                label1.Show();
                pictureBox14.Show();
                button3.Show();
                button2.Hide();
                ok = 1;

                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();

                if (p > bp)
                {
                    bp = p;
                    label7.Show();
                    label8.Text = bp.ToString();
                    label8.Show();
                    pictureBox15.Show();
                }
            }
        }

        void penalty()
        {

            const int c = 1;

            if (car.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                if (s > 3) s -= c;
            }

            if (car.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                if (s > 3) s -= c;
            }
        }

        void points(int v)
        {
            p += v / 10;
            if (v >= 35) p++;
            label6.Text = p.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move(s);
            movee(s);
            gameover();
            penalty();
            speed(s);
            points(s);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ok = 0;
            timer1.Start();

            button1.Hide();
            button3.Hide();
            button2.Show();
            pictureBox13.Hide();
            button4.Hide();
            button5.Hide();

            lowd.Hide();
            mediumd.Hide();
            highd.Hide();

            e1.Show();
            e2.Show();
            e3.Show();

            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();

            label7.Hide();
            label8.Hide();

            pictureBox14.Hide();
            pictureBox15.Hide();

            car.BackgroundImage = Image.FromFile(@"poze\" + pcnt.ToString() + ".png");

            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Show();
            button2.Hide();
            button3.Show();

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

            if (p > bp)
            {
                bp = p;
                label7.Show();
                label8.Text = bp.ToString();
                label8.Show();
                pictureBox15.Show();
            }

            ok = 1;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            save();
            Form2.ActiveForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pcnt < 7)
            {
                pcnt++;
                pictureBox13.BackgroundImage = Image.FromFile(@"poze\imag" + pcnt.ToString() + ".png");
            }
            else
            {
                pcnt = 1;
                pictureBox13.BackgroundImage = Image.FromFile(@"poze\imag" + pcnt.ToString() + ".png");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (pcnt > 1)
            {
                pcnt--;
                pictureBox13.BackgroundImage = Image.FromFile(@"poze\imag" + pcnt.ToString() + ".png");
            }
            else
            {
                pcnt = 7;
                pictureBox13.BackgroundImage = Image.FromFile(@"poze\imag" + pcnt.ToString() + ".png");
            }
        }



        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && car.Left - s > 0 && ok == 0)
            {
                car.Left -= (int)(s * d);
            }
            else if (e.KeyCode == Keys.A && car.Left - s <= 0 && ok == 0)
            {
                car.Left = 2;
            }

            if (e.KeyCode == Keys.D && car.Left + car.Width + s < w && ok == 0)
            {
                car.Left += (int)(s * d);
            }
            else if (e.KeyCode == Keys.D && car.Left + car.Width + s >= w && ok == 0)
            {
                car.Left = w - car.Width - 2;
            }

            if (e.KeyCode == Keys.W && s < 35 - ds && ok == 0) s += 5;

            if (e.KeyCode == Keys.S && s > 5 && ok == 0) s -= 5;
        }



        private void lowd_Click(object sender, EventArgs e)
        {
            d = 1.1;
            ds = 0;
        }

        private void mediumd_Click(object sender, EventArgs e)
        {
            d = 1.6;
            ds = 5;
        }

        private void highd_Click(object sender, EventArgs e)
        {
            d = 2.1;
            ds = 10;
        }
        
    }
}
