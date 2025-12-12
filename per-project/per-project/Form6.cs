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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            //When the cart changes, call my function named CartManager_CartChanged
            CartManager.CartChanged += CartManager_CartChanged;
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            RefreshCartUI();
            // fixing not seei the panel issue 
            panel5.AutoScroll = true;
            panel5.SuspendLayout();
            RefreshCartUI(); // or in RefreshCartUI call Suspend/Resume
            panel5.ResumeLayout();

        }



        private void CartManager_CartChanged(object sender, EventArgs e)
        {
            // Ensure update runs on UI thread
            if (InvokeRequired)
            {
                this.Invoke(new Action(RefreshCartUI));
            }
            else
            {
                RefreshCartUI();
            }
        }


        private void RefreshCartUI()
        {
            // Clear existing dynamic controls in panel5 (big panel holder)
            panel5.Controls.Clear();

            int y = 0;
            int itemIndex = 0;
            foreach (var item in CartManager.Items.ToList()) // ToList to avoid collection modification while iterating
            {
                var p = CreateCartItemPanel(item, itemIndex);
                p.Location = new Point(10, y);
                panel5.Controls.Add(p);
                y += p.Height + 10;
                itemIndex++;
            }
            UpdateOrderSummary();
        }



        private Panel CreateCartItemPanel(CartItem item, int index)
        {
            // Panel size — adapt to your UI
            Panel panel = new Panel
            {
                //Width = panel5.ClientSize.Width - 10,
                Width = panel5.ClientSize.Width-20 ,
                Height = 105,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };






            //crrete the button then save it in panel 
            Button btnRemove = new Button
            {
                Text = "X",
                Name = "btnRemove_" + index,
                Size = new Size(25, 25),
                Location = new Point(panel.Width - 40, 5),
                // having same place at top right even if we chnged the form size :
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnRemove.Click += (s, e) =>
            {
                // Remove action
                CartManager.RemoveItem(item);
                // delet the pane from memory
                panel.Dispose();
            };
            // add it in panel
            panel.Controls.Add(btnRemove);




            // PictureBox1 inside the small rectangle
            PictureBox pic = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10, 10),
                Size = new Size(80, 80),
                Image = item.Image // may be null; that's ok
            };
            panel.Controls.Add(pic);


            //name
            Label lblName = new Label
            {
                Text = item.Name,
                Location = new Point(100, 10),
                AutoSize = false,
                Size = new Size(240, 20),
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            panel.Controls.Add(lblName);



            // Label8 - size
            Label lblSize = new Label
            {
                Text = "Size: " + (string.IsNullOrEmpty(item.Size) ? "-" : item.Size),
                Location = new Point(100, 34),
                AutoSize = true
            };
            panel.Controls.Add(lblSize);



            // Label10 - price
            Label lblPrice = new Label
            {
                Text = item.UnitPrice.ToString("0.00") + " LYD",
                //100-54
                Location = new Point(190, 34),
                AutoSize = true
            };
            panel.Controls.Add(lblPrice);



            // NumericUpDown for quantity 
            NumericUpDown nud = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 999,
                Value = item.Quantity > 0 ? item.Quantity : 1,
                //150
                Location = new Point(panel.Width - 220, 40),
                Size = new Size(60, 24),
                Name = "nudQty_" + index,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            nud.ValueChanged += (s, e) =>
            {
                int newQty = (int)nud.Value;
                CartManager.UpdateQuantity(item, newQty);



                // Update subtotal label inside this panel
                var lblSub = panel.Controls.Find("lblSub_" + index, false).FirstOrDefault() as Label;
                if (lblSub != null)
                    lblSub.Text = (item.UnitPrice * newQty).ToString("0.00") + " LYD";
            };
            panel.Controls.Add(nud);



            // Label11 - subtotal (name it lblSub_index)
            Label lblSubTotal = new Label
            {
                Name = "lblSub_" + index,
                Text = (item.UnitPrice * item.Quantity).ToString("0.00") + " LYD",
                Location = new Point(panel.Width - 100, 46),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            panel.Controls.Add(lblSubTotal);

            return panel;
        }



        






        private void UpdateOrderSummary()
        {
            // label55 = item count (how many rectangle panels inside panel5)
            label55.Text = CartManager.TotalItems().ToString();

            // label54 = subtotal label for summary
            decimal subtotal = CartManager.Subtotal();
            label54.Text = subtotal.ToString("0.00") + " LYD";

            
            decimal shipping = 5; // example fixed shipping
            decimal taxes = subtotal * 0.05m; // example 5% taxes
           
            try
            {
                
                label52.Text = taxes.ToString("0.00") + " LYD";
                
            }
            catch { }

            decimal finalTotal = subtotal + shipping + taxes  ;
            label50.Text = finalTotal.ToString("0.00") + " LYD";
        }
       


       
        // Dispose event to unsubscribe
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            CartManager.CartChanged -= CartManager_CartChanged;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

       

        private void label23_Click(object sender, EventArgs e)
        {
            // card picture 
            Forms.F1.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //process button 
            // if logged it them message shows ok !! 
            // if not then message shows u have to login first 
            // then go to login page 
            if (CartManager.TotalItems() == 0)
            {
                MessageBox.Show("Your cart is empty. Add items to the cart first.", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If user is logged in (you have a logic), proceed. For now just show success
            MessageBox.Show("Order processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear cart after processing
            CartManager.Clear();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            // main button 
            Forms.F2.Show();
            Forms.F2.ScrollToTop();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            // card picture 
            Forms.F4.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            // card picture 
            Forms.F3.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            // best seller 
            Forms.F2.Show();
            this.Hide();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            label55.Text = CartManager.TotalItems().ToString();

        }
    }
}
