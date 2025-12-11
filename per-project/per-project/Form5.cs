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

            // set size buttons initial state (if you use toggle visual, handle)
            // assuming button4=30ml, button5=50ml, button6=100ml
            // We'll set a default size:
            SetSelectedSize("30ml");
            //new end
        }
        private string selectedSize = "30ml";
        private void SetSelectedSize(string size)
        {
            selectedSize = size;
            // Optionally update button styles to show which is selected
            // e.g. button4.BackColor = (size == "30ml") ? Color.LightBlue : SystemColors.Control;
            // implement if you want visual feedback
        }

        private void LoadItem()
        {

            //its muted in new 

            //label1.Text = _item.Name;
            //label2.Text = _item.UnitPrice.ToString("0.00") + " LYD";
            //label3.Text = _item.details;
            //pictureBox1.ImageLocation = _item.ImagePath;
            //pictureBox1.Image = Image.FromFile(_item.ImagePath);



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

        private void button4_Click(object sender, EventArgs e)
        {
            SetSelectedSize("30ml");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSelectedSize("50ml");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetSelectedSize("100ml");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //new 
            int qty = (int)numericUpDown1.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Please select a valid quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new CartItem instance representing the cart entry
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

            // Close or hide detail form and return to previous form if desired:
            // you used ShowDialog when opening from Form2; closing is fine for that flow
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Forms.F4.Show();
            this.Hide();
        }
    }
    }




