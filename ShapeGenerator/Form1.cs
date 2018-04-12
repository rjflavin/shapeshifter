using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShapeGenerator
{
    public partial class Form1 : Form
    {
        int time = 1;
        int shapeWidth = Screen.PrimaryScreen.WorkingArea.Width;
        int shapeHeight = Screen.PrimaryScreen.WorkingArea.Height;
        int xShift = 0;
        int yShift = 0;
        int xStart = 0;
        int yStart = 0;
        Timer timer = new Timer();
        //int penColor = 0;
        public static Color penColor { get; set; }



        public Form1()
        {
            InitializeComponent();

            int random = Math.Abs((int)(DateTime.Now.Ticks) % 255);
            penColor = Color.FromArgb(random, (random * random) % 255, (int)(random * random * random) % 255);

            pictureBox1.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - changeColorButton.Width, Screen.PrimaryScreen.WorkingArea.Height);
            pictureBox1.Image = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width-changeColorButton.Width, Screen.PrimaryScreen.WorkingArea.Height);

            xStart = pictureBox1.Width / 2;
            yStart = pictureBox1.Width / 2;

            startTimer();
        }

        public void startTimer()
        {
          

            
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //grab previous bitmap
            pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone();

            //Toggle Color if checked
            if(toggleColorCheckBox.CheckState==CheckState.Checked)
            {
                changeColorButton_Click(null, null);
            }

            Graphics g = Graphics.FromImage(pictureBox1.Image);

            Pen pen = new Pen(penColor,1);
            int circleWidth = time % shapeWidth + 1;
            int circleHeight = time % shapeWidth + 1;
            g.DrawArc(pen, new Rectangle(xShift+xStart-circleWidth/2,yStart+yShift-circleHeight/2, circleWidth, circleHeight), 0, 360);
            
            time += 3;
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            yShift += 10;
        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {

            int random = Math.Abs((int)(DateTime.Now.Ticks) % 255);


            penColor = Color.FromArgb(random, (random*random)%255, (int)(random*random*random)%255);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            Console.WriteLine(key.ToString());

            if (key==32)
            {
                startStopButton.PerformClick();
            }
            if (key == 67)
            {
                changeColorButton.PerformClick();
            }
            if(key==84)
            {
                // everytime you click the button checkbox states will change.
                if (toggleColorCheckBox.Checked)
                {
                    toggleColorCheckBox.Checked = false;
                }
                else
                {
                    toggleColorCheckBox.Checked = true;
                }
            }
            if(key==82)
            {
                resetButton.PerformClick();
            }
            if(key==37)
            {
                xShift -= 10;
            }
            if(key==39)
            {
                xShift += 10;
            }
            if(key==38)
            {
                yShift -= 10;
            }
            if(key==40)
            {
                yShift += 10;
            }
            if(key==81)
            {
                time = 1;
                time = 1;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            yShift -= 10;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("X: "+e.X+",Y:"+e.Y);

            xStart = e.X;
            yStart = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width - changeColorButton.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(timer.Enabled)
            {
                timer.Enabled = false;
                startStopButton.Text = "Start (Space)";
            }
            else if(!timer.Enabled)
            {
                timer.Enabled = true;
                startStopButton.Text = "Stop (Space) ";
            }
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                                                                                                                         
            }

        }
    }
}
