using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using per_project.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static per_project.Class1;

namespace per_project
{
    public partial class Form2 : Form
    {


        // list of the product  ( list all ur product info here )
        private List<CartItem> products;

        public Form2()
        {
            InitializeComponent();
            this.AutoScrollPosition = new Point(0, label5.Top);

            
             products = new List<CartItem>();
            products.Add(new CartItem(1, "A fresh and elegant feminine perfume with light citrus notes and a warm, classy finish.Suitable for daily use and special occasions.", "ChanelCoco Mademoiselle ",520, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\4.png"));
            products.Add(new CartItem(10, "A refined and elegant fragrance with citrus, wood, and incense notes.Clean, sophisticated, and suitable for professional or formal settings.", "Bleu de Chanel Eau de Parfum", 650, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\5.png"));
            products.Add(new CartItem(7, "A warm, sweet, and masculine fragrance with vanilla and  amber notes.Perfect for evening wear and confident men who love long - lasting scents.",  "Emporio Armani Stronger With You Intensely ", 430, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm2.png"));
            products.Add(new CartItem(4,"lasting and ideal for a stylish, confident look.", "Valentino Donna Born in Roma", 470, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\2.png"));
            //////////



            //products.Add(new CartItem(1, "XXX", "name dior ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\4.png"));
            //products.Add(new CartItem(2, "XXX", "name  chneel ", 25, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\5.png"));
            //products.Add(new CartItem(3, "XXX", "name dior lly  ", 88, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\image1\pm2.png"));
            //products.Add(new CartItem(4, "XXX", "name dior lly  ", 77, 0, @"C:\Users\ا\Desktop\per-project-\per-project\per-project\Resources\2.png"));


            //each panel taks a project 
            pictureBox2.Tag = products[0]; // first product
            pictureBox4.Tag = products[1]; // second product
            pictureBox13.Tag = products[2];
            pictureBox5.Tag= products[3];

            // add click event for each panel
            pictureBox2.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox13.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;

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


      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //woman word 
            this.Hide();
            Forms.F3.Show();
            



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void Form2_Load_1(object sender, EventArgs e)
        {

            this.BeginInvoke((MethodInvoker)(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);

            }));
        }

     

        public void ScrollToTop()
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
               
            }));
        }








        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            // men word 
            Forms.F4.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(0, label10.Top);
        }
        
        private void label6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.F3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.F4.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
