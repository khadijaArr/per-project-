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


    public partial class Form5 : Form
    {
        // private CartItem _item; // use your CartItem class
        // new
        private CartItem productTemplate;
        public Form5()
        {
            InitializeComponent();
        }





        // recueve item to put info : 
        public Form5(CartItem item)
        {
            InitializeComponent();
            // new 
            productTemplate = item ?? new CartItem();
            //
            //_item = item; // save the item
            //LoadItem();    // fill form with data
            label1.Text = productTemplate.Name;   // product name
            label2.Text = productTemplate.UnitPrice.ToString("0.00"); // price
            label3.Text = productTemplate.details;

            if (productTemplate.Image == null)
            {
                productTemplate.Image = CartItem.LoadImageSafe(productTemplate.ImagePath);
            }
            if (productTemplate.Image != null)
                pictureBox1.Image = productTemplate.Image;

            // default quantity
            numericUpDown1.Value = productTemplate.Quantity > 0 ? productTemplate.Quantity : 1;


        }
        private string selectedSize = null;
        private void SetSelectedSize(string size)
        {
            selectedSize = size;

        }





        private void button1_Click(object sender, EventArgs e)
        {
            // ADD to card button : 
            // check log in 
            if (!Forms.F1.IsLoggedIn)
            {
                MessageBox.Show("You must log in first!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop here
            }


            if (selectedSize != null)
            {// if one of size is being clicked ;
                int qty = (int)numericUpDown1.Value;
                if (qty <= 0)
                {
                    MessageBox.Show("Please select a valid quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a new CartItem instance representing the cart entry ( fill the constructer) 
                CartItem cartEntry = new CartItem(
                    productTemplate.Id,
                    productTemplate.details,
                    productTemplate.Name,
                    productTemplate.UnitPrice,
                    qty,
                    productTemplate.ImagePath
                    );
                cartEntry.Size = selectedSize;

                // ensure Image is cached
                cartEntry.Image = productTemplate.Image ?? CartItem.LoadImageSafe(productTemplate.ImagePath);

                // Add to central cart
                CartManager.AddItem(cartEntry);

                // Optional: show small confirmation
                MessageBox.Show("Added to cart.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(" Choose a size please ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        // update the price epents on the size 
        private void UpdatePrice(string size)
        {
            decimal newPrice = productTemplate.UnitPrice; // start from base price

            // Adjust price depending on size
            switch (size)
            {
                case "30ml":
                    // maybe base price, no change
                    break;
                case "50ml":
                    newPrice += 50;  // add 5 LYD for 50ml
                    break;
                case "100ml":
                    newPrice += 100; // add 10 LYD for 100ml
                    break;
            }

            // Update the label
            label2.Text = newPrice.ToString("0.00");
        }









        private void button4_Click(object sender, EventArgs e)
        {
            SetSelectedSize("30ml");
            UpdatePrice("30ml");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSelectedSize("50ml");
            UpdatePrice("50ml");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetSelectedSize("100ml");
            UpdatePrice("100ml");
        }




        private void label19_Click(object sender, EventArgs e)
        {
            Forms.F4.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }




        private void LoadItem()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            Forms.F1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // main button 
            Forms.F2.Show();
            Forms.F2.ScrollToTop();
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
            // best seller 
            Forms.F2.Show();     // show Form1
            this.Hide();   // hide this form
        }

        private void label21_Click(object sender, EventArgs e)
        {
            // woman 
            Forms.F3.Show();     // show Form1
            this.Hide();   // hide this form
        }

    }
}



