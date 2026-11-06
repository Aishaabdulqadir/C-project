using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacky_cafee_order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Customer Name");
                return;
            }

            int qty;

            if (!int.TryParse(txtQty.Text, out qty) || qty < 1)
            {
                MessageBox.Show("Invalid Quantity");
                return;
            }

            string drink = "";
            double price = 0;

            if (rdoTea.Checked)
            {
                drink = "Tea";
                price = 1;
            }
            else if (rdoCoffee.Checked)
            {
                drink = "Coffee";
                price = 2;
            }
            else if (rdoJuice.Checked)
            {
                drink = "Juice";
                price = 3;
            }
            else
            {
                MessageBox.Show("Select Drink");
                return;
            }

            listBox1.Items.Clear();

            Random rnd = new Random();

            for (int i = 1; i <= qty; i++)
            {
                int lucky = rnd.Next(1, 51);

                listBox1.Items.Add(i + ") "
                    + txtName.Text + " - "+ drink + " - Lucky: "+ lucky + " - $"+ price);
            }

            double beforeDiscount = price * qty;
            double total = beforeDiscount;

            listBox1.Items.Add("");

            if (chkStudent.Checked)
            {
                total = total - (beforeDiscount * 0.10);
                listBox1.Items.Add("Member Discount: 10%");
            }
            else
            {
                listBox1.Items.Add("Member Discount: 0%");
            }

            listBox1.Items.Add("");
            listBox1.Items.Add("Total Before Discount: $" + beforeDiscount);
            listBox1.Items.Add("");
            listBox1.Items.Add("Total After Discount: $" + total);
            listBox1.Items.Add("");

            int luckyMsg = rnd.Next(1, 8);

            if (luckyMsg == 7)
            {
                lblLucky.Text = "Lucky Message: You got a Free Cookie!";
                listBox1.Items.Add("Lucky Message: You got a Free Cookie!");
            }
            else
            {
                lblLucky.Text = "Lucky Message: No prize this time.";
                listBox1.Items.Add("Lucky Message: No prize this time.");
            }

            lblTotalPrice.Text = "Total Price: $" + total;
        }
        
       


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter sw = File.AppendText("orders.txt");

            foreach (var item in listBox1.Items)
            {
                sw.WriteLine(item.ToString());
            }

            sw.WriteLine(lblTotalPrice.Text);
            sw.WriteLine(lblLucky.Text);
            sw.WriteLine("------------------");

            sw.Close();

            MessageBox.Show("Order saved.");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter sw = File.AppendText("orders.txt");

            foreach (var item in listBox1.Items)
            {
                sw.WriteLine(item.ToString());
            }

            sw.WriteLine("-------------------");

            sw.Close();

            MessageBox.Show("Order saved.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            listBox1.Items.Clear();

            StreamReader sr = File.OpenText("orders.txt");

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }

            sr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQty.Clear();

            rdoTea.Checked = false;
            rdoCoffee.Checked = false;
            rdoJuice.Checked = false;

            chkStudent.Checked = false;

            listBox1.Items.Clear();

            lblTotalPrice.Text = "Total Price:";
            lblLucky.Text = "Lucky Message:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

    
    

