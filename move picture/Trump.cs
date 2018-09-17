using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Trump : Form
    {
        public Trump()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 15);
            }
        }
        // moves the image up
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 15 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 15);
            }
        }
        // moves the image dowm
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 15 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y);
            }
        }
        // moves the image left
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y);
            }
        }
        // moves the image right
        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 15);
            }
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y);
            }

            //pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y - 15);
        }
        // moves the image to the top left
        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 15);
            }
            if (pictureBox1.Location.X + 15 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y);
            }


            //pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y - 15);
        }
        // moves the image to the top right
        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 15 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 15);
            }
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y);
            }


            //pictureBox1.Location = new Point(pictureBox1.Location.X - 15, pictureBox1.Location.Y + 15);
        }
        // moves the image to the bottom left
        private void button8_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 15 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y);
            }
            if (pictureBox1.Location.Y + 15 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 15);
            }


            //pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y + 15);
        }
        // moves the image to the bottom right
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Trump_Load(object sender, EventArgs e)
        {
           
        }
    }
}
