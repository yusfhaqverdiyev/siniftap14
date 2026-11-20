
using System.Drawing;
using System.Windows.Forms;
using System;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = +5;
        int dy = -5;
        int score = 0;
        bool Gameover = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && panel1.Left > 0)
            {
                panel1.Left -= 20;
            }
            if (e.KeyCode == Keys.Right && panel1.Right < ClientSize.Width)
            {
                panel1.Left += 20;
            }
            if ((e.KeyCode == Keys.Enter && Gameover))
            {
                Gameover = false;
                dx = 5;
                dy = 5;
                score = 0;
                pictureBox1.Location = new Point(100, 67);
                pictureBox1.Location = new Point(100, 67);
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += dx;
            pictureBox1.Top += dy;

            if (pictureBox1.Left < 0 && pictureBox1.Right > this.ClientSize.Width)
            {
                dx = -dx;

            }
            if (pictureBox1.Top < 0)
            {
                dy = -dy;
            }
            if (pictureBox1.Bounds.IntersectsWith(panel1.Bounds))
            {
                dy = -dy;
                dy--;
                score++;
            }
            if (pictureBox1.Bottom >= this.ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitdi\nXal:" + score + "\nYeni oyun Entere basin");
                Gameover = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}