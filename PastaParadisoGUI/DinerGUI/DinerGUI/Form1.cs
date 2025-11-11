using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> itemValues = new Dictionary<string, decimal>
        {
            { "Spaghetti Bolognese", 10.00m },
            { "Pesto Penne", 20.00m },
            { "Shrimp Alfredo3", 15.00m },
            { "Vegetable Primavera", 17.50m },
            { "Linguine Aglio e Olio", 12.50m },
            { "Mushroom and Spinach Ravioli", 15.50m },
            { "Creamy Truffle Pasta", 25.00m },
            { "Butternut Squash Ravioli", 10.50m },
            { "Classic Caesar Salad", 5.00m },
            { "Mediterranean Quinoa Salad", 10.00m },
            { "Caprese Salad", 7.50m },
            { "Chicken Avocado Salad", 8.50m },
            { "Chocolate Lava Cake", 7.50m },
            { "Tiramisu", 8.50m },
            { "Fruit Tart", 4.50m },
            { "Cheesecake with Berry Compote", 12.50m },
        };

        private List<string> selectedItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnAddMain_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBox1.SelectedItems)
            {
                selectedItems.Add(selectedItem.ToString().Trim());
            }

            MessageBox.Show("Selected item added to the list.", "Item added");

            listBox1.ClearSelected();
        }

        private void btnAddSides_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in listBox2.SelectedItems)
            {
                selectedItems.Add(selectedItem.ToString().Trim());
            }

            MessageBox.Show("Selected item added to the list.", "Item added");

            listBox2.ClearSelected();
        }
        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = "";
            decimal totalValue = 0;

            foreach (var selectedItem in selectedItems)
            {
                if (itemValues.TryGetValue(selectedItem, out decimal value))
                {
                    message += $"{selectedItem}: ${value:F2}\n";
                    totalValue += value;
                }
            }
            message += $"\nTotal Value: ${totalValue:F2}";

            MessageBox.Show(message, "Current Order");

        }

        private void clearOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedItems.Clear();
            MessageBox.Show("Order cleared.", "Order Cleared");

            listBox1.ClearSelected();
            listBox2.ClearSelected();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            checkBox1.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItemMM = listBox1.SelectedItem.ToString();

                SetPictureBoxImageMainMenu(selectedItemMM);
            }

        }

        private void SetPictureBoxImageMainMenu(string selectedItemMM)
        {
            System.Drawing.Image imageToShowMM = null;

            switch (selectedItemMM)
            {
                case "Spaghetti Bolognese":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Spaghetti Bolognese (Custom).jpeg");
                    break;
                case "Pesto Penne":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Pesto Penne (Custom).jpeg");
                    break;
                case "Shrimp Alfredo":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Shrimp Alfredo (Custom).jpg");
                    break;
                case "Vegetable Primavera":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Vegetable Primavera (Custom).jpg");
                    break;
                case "Linguine Aglio e Olio":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Linguine Aglio e Olio (Custom).jpg");
                    break;
                case "Mushroom and Spinach Ravioli":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Mushroom and Spinach Ravioli (Custom).jpeg");
                    break;
                case "Creamy Truffle Pasta":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Creamy Truffle Pasta (Custom).jpg");
                    break;
                case "Butternut Squash Ravioli":
                    imageToShowMM = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Butternut Squash Ravioli (Custom).jpeg");
                    break;

                default:
                    imageToShowMM = null;
                    break;
            }
            pictureBox1.Image = imageToShowMM;

            pictureBox1.Refresh();


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItemSnD = listBox2.SelectedItem.ToString();

                SetPictureBoxImageSaladandDessert(selectedItemSnD);
            }
        }

        private void SetPictureBoxImageSaladandDessert(string selectedItemSnD)
        {
            System.Drawing.Image imageToShowSnD = null;

            switch (selectedItemSnD)
            {
                case "Classic Caesar Salad":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Classic Caesar Salad (Custom).jpeg");
                    break;
                case "Mediterranean Quinoa Salad":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Mediterranean Quinoa Salad (Custom).jpeg");
                    break;
                case "Caprese Salad":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Caprese Salad (Custom).jpg");
                    break;
                case "Chicken Avocado Salad":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Chicken Avocado Salad (Custom).jpg");
                    break;
                case "Chocolate Lava Cake":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Chocolate Lava Cake (Custom).jpg");
                    break;
                case "Tiramisu":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Tiramisu (Custom).jpg");
                    break;
                case "Fruit Tart":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Fruit Tart (Custom).jpg");
                    break;
                case "Cheesecake with Berry Compote":
                    imageToShowSnD = new Bitmap("C:\\Users\\Rianne\\Desktop\\PastaParadisoGUI\\Menu, Salad and Pastas\\Cheesecake with Berry Compote (Custom).jpeg");
                    break;

                default:
                    imageToShowSnD = null;
                    break;
            }
            pictureBox1.Image = imageToShowSnD;

            pictureBox1.Refresh();

        }
    }
}