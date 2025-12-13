using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static per_project.Class1;

namespace per_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            List<CartItem> products = new List<CartItem>();
            //products.Add(new CartItem(9, "XXX", "name dior ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm3.png"));
            //products.Add(new CartItem(10, "XXX", "name  chneel ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm2.png"));
            //products.Add(new CartItem(11, "XXX", "name dior lly  ", 88, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm1.png"));



            products.Add(new CartItem(7, "A warm, sweet, and masculine fragrance with vanilla and amber notes.Perfect for evening wear and confident men who love long - lasting scents.", "Prada Luna Rossa Black ", 430, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm3.png"));
            products.Add(new CartItem(8, "A warm, sweet, and masculine fragrance with vanilla and  amber notes.Perfect for evening wear and confident men who love long - lasting scents.", "Emporio Armani Stronger With You Intensely ", 380, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\The 3 Valentino Perfumes the Internet Is Obsessed Withi.png"));
            products.Add(new CartItem(9, "A timeless masculine fragrance with apple, cinnamon, and woody notes. Fresh and clean, suitable for everyday use and all ages.", "Hugo Boss Bottled", 220, 0, @" C: \Users\ا\Desktop\per - project -\per - project\per - project\image1\pm1.png"));
            products.Add(new CartItem(10, "A fresh and bold fragrance combining mint, lemon, and woody notes. Strong, youthful, and perfect for daily wear or special occasions.", "Versace Eros", 360, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm5.png"));
            products.Add(new CartItem(11, "A powerful and iconic scent featuring bergamot and amber.Fresh, masculine, and extremely long - lasting—ideal for both day and night.", "Dior Sauvage Eau de Parfumv", 520, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm4.png"));
            products.Add(new CartItem(12, "A refined and elegant fragrance with citrus, wood, and incense notes.Clean, sophisticated, and suitable for professional or formal settings.", "Bleu de Chanel Eau de Parfum", 580, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm6.png"));
            
               






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

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1) {
                Forms.F3.Show();
                this.Hide();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            //woman word 

            Forms.F3.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            //man word 

            Forms.F4.Show();
            this.Hide();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            // main button 
            Forms.F2.Show();
            Forms.F2.ScrollToTop();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
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
            // Best seller 
            Forms.F2.Show();     // show Form1
            this.Hide();   // hide this form
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
