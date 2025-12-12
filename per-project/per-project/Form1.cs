using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static per_project.Class1;

namespace per_project
{
    public partial class Form1 : Form
    {

        

        //// height increase animation 
        private Timer timer;
        private int targetHeight;

        // back timer  hight increas Animation  for panel 3
        private Timer timer2;
        


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

            timer2 = new Timer() ;
            timer2.Interval = 10;
            timer2.Tick += Backtimer_Tick;

           

        }
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



        private void Backtimer_Tick(object sender, EventArgs e)
        {
           panel3.Visible = true;
            if (panel3.Height < targetHeight)  
            {
                panel3.Height += 5;
            }
            else
            {
                timer2.Stop();

            }
            
            panel2.Visible = false;
            panel2.Height = 0;
        }


        //check if loged in 
        public bool IsLoggedIn
        {
            get
            {
                // check if the login info is correct
                return textBox1.Text == "username" && textBox2.Text == "password";
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            // check the password logic 
            if (textBox1.Text == "username" && textBox2.Text == "password")
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

       
        private void button1_Click(object sender, EventArgs e)
        {
            //back button 
            //for height animation 
            timer.Start();

            // Initially set panelLogin.Visible = false;  and hide the behind items 
            panel3.Height = 0;
            panel3 .Visible = false;
            panel2.Visible = true;
            
        }


        

        private void label7_Click(object sender, EventArgs e)
        {
          
            Forms.F2.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label7_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }





        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            MessageBox.Show("click1", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label7_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
       

    }
}
