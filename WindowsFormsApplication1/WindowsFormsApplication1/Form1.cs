using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.timer.Interval = 1000 / 24;
            this.timer.Tick += timer_Tick;
            this.button2.Click += button2_Click;
            this.timer.Start();
            this.KeyDown += Form1_KeyDown;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int x = this.button1.Location.X;
            int y = this.button1.Location.Y;
            this.button2.Location = new Point(x, y + 10);
            if (y > 1000)
            {
                Random random = new Random();
                x = random.Next(this.Width);
                this.button2.Location = new Point(x, 0);
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int delta = 10;
            int x = this.button2.Location.X;
            int y = this.button2.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.W:
                    this.button2.Location = new Point(x, y - delta);
                    break;
                case Keys.S:
                    this.button2.Location = new Point(x, y + delta);
                    break;
                case Keys.A:
                    this.button2.Location = new Point(x - delta, y);
                    break;
                case Keys.D:
                    this.button2.Location = new Point(x + delta, y);
                    break;

            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
        }

    
    }
}
