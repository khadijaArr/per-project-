
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace per_project
{
    internal class Class1
    {
        //
    }

    // forms connection 
    public static class Forms
    {
        public static Form1 F1;
        public static Form2 F2;
        public static Form3 F3;
        public static Form4 F4;
        public static Form5 F5;
        public static Form6 F6;
    }

    // CartItem class (used both as "product template" and as an item in the cart)
    public class CartItem
    {
        
        public CartItem() { }

        public CartItem(int id, string details, string name, decimal unitPrice, int quantity, string imagePath)
        {
            Id = id;
            details = details ?? "";
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
            ImagePath = imagePath;
            Size = ""; // will be set by the details form
            // Try to load Image right away for convenience:
            Image = LoadImageSafe(imagePath);
        }

        public int Id { get; set; }
        public string details { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Size { get; set; }
        public Image Image { get; set; }
        public decimal SubTotal => UnitPrice * Quantity;

        // Utility: load an image from file or from resources (best-effort)
        public static Image LoadImageSafe(string pathOrResource)
        {
            if (string.IsNullOrEmpty(pathOrResource)) return null;

            // 1) Try treat it as a real file path
            try
            {
                if (File.Exists(pathOrResource))
                {
                    // use FromFile in a try-catch (caller may dispose later)
                    return Image.FromFile(pathOrResource);
                }
            }
            catch
            {
                // ignore and try resources
            }

            // 2) Try to load from project resources by name
            // pathOrResource might look like "Resources\\4.png" or "...\\Resources\\4.png" or "4.png"
            try
            {
                // get just filename without extension
                string fileName = Path.GetFileNameWithoutExtension(pathOrResource);
                if (!string.IsNullOrEmpty(fileName))
                {
                    object res = Properties.Resources.ResourceManager.GetObject(fileName);
                    if (res is Image img) return img;
                }
            }
            catch
            {
                // ignore
            }

            // 3) Fallback null
            return null;
        }
    }

    



    public static class CartManager
    {
        public static List<CartItem> Items { get; private set; } = new List<CartItem>();

        // Event fired when cart changes (add/remove/update quantity)
        public static event EventHandler CartChanged;



        public static void AddItem(CartItem item)
        {
            if (item == null) return;

            // Option: if same product+size exists, increase quantity instead of new row.
            var existing = Items.Find(x => x.Id == item.Id && x.Size == item.Size);
            if (existing != null)
            {
                existing.Quantity += item.Quantity;
                existing.Image = existing.Image ?? item.Image;
            }
            else
            {
                Items.Add(item);
            }
            CartChanged?.Invoke(null, EventArgs.Empty);
        }





        public static void RemoveItem(CartItem item)
        {
            if (item == null) return;
            Items.Remove(item);
            CartChanged?.Invoke(null, EventArgs.Empty);
        }



        public static void UpdateQuantity(CartItem item, int newQty)
        {
            if (item == null) return;
            item.Quantity = newQty;
            //in case the card chnaged (null = we dont care who is the sender ) ( not even happen )
            // just telling the card form that something chnaged 
            CartChanged?.Invoke(null, EventArgs.Empty);
        }




        public static decimal Subtotal()
        {
            decimal s = 0;
            foreach (var it in Items) s += it.SubTotal;
            return s;
        }



        public static int TotalItems()
        {
          
            return Items.Sum(i => i.Quantity);
        }




        public static void Clear()
        {
            Items.Clear();
            CartChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
