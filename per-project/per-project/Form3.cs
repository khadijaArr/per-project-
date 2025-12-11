using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static per_project.Class1;

namespace per_project
{









    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            List<CartItem> products = new List<CartItem>();
            products.Add(new CartItem(5, "XXX", "name dior ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p2.jpg"));
            products.Add(new CartItem(6, "XXX", "name  chneel ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\2.png"));
            products.Add(new CartItem(7, "XXX", "name dior lly  ", 88, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p1.jpg"));
            products.Add(new CartItem(8, "XXX", "Kai ly  ", 77, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p5.png"));


            //each panel taks a project 
            pictureBox2.Tag = products[0]; // first product
            pictureBox1.Tag = products[1]; // second product
            pictureBox4.Tag = products[2];
            pictureBox5.Tag = products[3];

            // add click event for each panel
            pictureBox2.Click += PictureBox_Click;
            pictureBox1.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;

        }



        // private CartItem currentItem;



        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedImage = sender as PictureBox;
            this.Hide();
            if (clickedImage?.Tag is CartItem item)
            {
                Form5 f = new Form5(item);
                f.ShowDialog();
               


            }
        }

        

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1) {
                Forms.F4.Show();
                this.Hide();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            // men word 
            Forms.F4.Show();
            this.Hide();

        }

        private void label30_Click(object sender, EventArgs e)
        {
            // main button 
            Forms.F2.Show();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            //login pic 
            Forms.F1.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // card picture 
            Forms.F6.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Forms.F2.Show();     // show Form1
            this.Hide();   // hide this form

    }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //public void OpenWithItem(CartItem item)
        //{
        //    currentItem = item;
        //    // Any initialization logic here
        //    this.Show();
        //}
    }
}
