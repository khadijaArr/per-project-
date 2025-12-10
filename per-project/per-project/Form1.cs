using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace per_project
{
    public partial class Form1 : Form
    {
        //// height increase animation 
        private Timer timer;
        private int targetHeight;

        // extra animation 
        private Timer animationTimer;
        private int fadeStep = 20; // opacity decrement step







        public Form1()
        {
            InitializeComponent();
            //for height increasing animation 
            panel2.Height = 0;        // Start hidden (collapsed)
            panel2.Visible = true;    // Keep it visible to animate height

            targetHeight = 367;       // Set desired height for the panel popup

            timer = new Timer();
            timer.Interval = 10;      // Animation speed
            timer.Tick += Timer_Tick;
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // for height increasing animation 
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (panel2.Height < targetHeight)
            {
                panel2.Height += 5;  // Increase height gradually
            }
            else
            {
                timer.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




            //for height animation 
            timer.Start();

            // Initially set panelLogin.Visible = false;  and hide the behind items 
            label1.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            panel2.Visible = true;

            //for extra animation 
            animationTimer = new Timer();
            animationTimer.Interval = 15; // milliseconds
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }


        // extra animation function 
        //private void AnimationTimer_Tick(object sender, EventArgs e)
        //{
        //    // Fade out panel3 by reducing its BackColor alpha
        //    Color currentColor = panel3.BackColor;
        //    int alpha = currentColor.A - fadeStep;
        //    if (alpha < 0) alpha = 0;
        //    panel3.BackColor = Color.FromArgb(alpha, currentColor.R, currentColor.G, currentColor.B);

        //    if (alpha == 0)
        //    {
        //        panel3.Visible = false;
        //    }

        //    // Move pictureBox1 towards target location
        //    Point current = pictureBox1.Location;
        //    int newX = current.X;
        //    int newY = current.Y;

        //    if (current.X > targetLocation.X) newX = Math.Max(current.X - moveStep, targetLocation.X);
        //    else if (current.X < targetLocation.X) newX = Math.Min(current.X + moveStep, targetLocation.X);

        //    if (current.Y > targetLocation.Y) newY = Math.Max(current.Y - moveStep, targetLocation.Y);
        //    else if (current.Y < targetLocation.Y) newY = Math.Min(current.Y + moveStep, targetLocation.Y);

        //    pictureBox1.Location = new Point(newX, newY);

        //    // Stop the timer if fade complete and pictureBox1 reached target
        //    if (alpha == 0 && pictureBox1.Location == targetLocation)
        //    {
        //        animationTimer.Stop();
        //        animationTimer.Dispose();
        //    }
        //}

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Fade out panel3 by reducing its BackColor alpha
            FadeOutPanel(panel3);

            // Fade in panel2 by increasing its BackColor alpha
            FadeInPanel(panel2);



            // Check if panel3 fully faded out, panel2 fully faded in, and pictureBox1 reached target
            bool panel3Invisible = !panel3.Visible;
            bool panel2Visible = panel2.Visible && panel2.BackColor.A == 255;

            if (panel3Invisible && panel2Visible)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
            }
        }

        private void FadeOutPanel(Panel panel)
        {
            if (!panel.Visible) return;

            Color currentColor = panel.BackColor;
            int alpha = currentColor.A - fadeStep;
            if (alpha < 0) alpha = 0;

            panel.BackColor = Color.FromArgb(alpha, currentColor.R, currentColor.G, currentColor.B);

            if (alpha == 0)
            {
                panel.Visible = false;
            }
        }

        private void FadeInPanel(Panel panel)
        {
            Color currentColor = panel.BackColor;
            if (!panel.Visible)
            {
                panel.Visible = true;
                // Start from fully transparent
                panel.BackColor = Color.FromArgb(0, currentColor.R, currentColor.G, currentColor.B);
                return;
            }

            int alpha = currentColor.A + fadeStep;
            if (alpha > 255) alpha = 255;

            panel.BackColor = Color.FromArgb(alpha, currentColor.R, currentColor.G, currentColor.B);
        }


       

        private void label7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "xxx" && textBox2.Text == "123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text != "")
            {
                MessageBox.Show("Enter User name and The Password ", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox1.Text != "xxx" || textBox2.Text != "123")
            {
                MessageBox.Show("The User name or Password is incorrect ", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
