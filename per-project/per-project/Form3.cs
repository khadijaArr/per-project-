using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using per_project.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static per_project.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.Remoting.Channels;

namespace per_project
{









    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            List<CartItem> products = new List<CartItem>();
            //products.Add(new CartItem(5, "XXX", "name dior ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p2.jpg"));
            //products.Add(new CartItem(6, "XXX", "name  chneel ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\2.png"));
            //products.Add(new CartItem(7, "XXX", "name dior lly  ", 88, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p1.jpg"));
            //products.Add(new CartItem(8, "XXX", "Kai ly  ", 77, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p5.png"));


            products.Add(new CartItem(1, "A fresh and soft floral perfume with a clean powdery touch.Simple, feminine, and suitable for daily use.", "Miss Laverne ", 120, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p2.jpg"));
            products.Add(new CartItem(2, "A modern, warm, and sweet scent with jasmine and vanilla. Long-lasting and ideal for a stylish, confident look", "Valentino Donna Born in Roma ", 420, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p4.png"));
            products.Add(new CartItem(3, "A sweet and floral fragrance with gardenia and pear blossom. Light, youthful, and perfect for everyday wear ", "Gucci Flora Gorgeous Gardenia", 380, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p1.jpg"));
            products.Add(new CartItem(4, "A delicious vanilla fragrance with a sugary, cozy finish. Perfect for lovers of sweet and comforting scents", " Kayali Vanilla Candy RockSugar", 350, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p5.png"));
            products.Add(new CartItem(5, "A soft floral scent with a luxurious touch. Features jasmine and ylang-ylang for a smooth, feminine aroma that lasts all day", "DiorJ’adore ", 520, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p6.png"));
            products.Add(new CartItem(6, "A fresh and elegant feminine perfume with light citrus notes and a warm, classy finish.Suitable for daily use and special occasions.", "ChanelCoco Mademoiselle", 480, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\p7.png"));
            //////////
            //each panel taks a project 
            pictureBox2.Tag = products[0]; // first product
            pictureBox1.Tag = products[1]; // second product
            pictureBox4.Tag = products[2];
            pictureBox5.Tag = products[3];
            pictureBox6.Tag = products[4];
            pictureBox7.Tag = products[5];

            // add click event for each panel
            pictureBox2.Click += PictureBox_Click;
            pictureBox1.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;
            pictureBox6.Click += PictureBox_Click;
            pictureBox7.Click += PictureBox_Click;

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
            Forms.F2.ScrollToTop();
            this.Hide();

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

        private void label21_Click(object sender, EventArgs e)
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
