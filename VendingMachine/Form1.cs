/*
Frank Hall
CIS 232
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VendingMachine // begin namespace
{
    public partial class Form1 : Form // begin class
    {
        SnickersReg snickers = new SnickersReg(); // create a new product object called snickers
        Doritos doritos = new Doritos();// create a new product object called doritos
        DrPeper drPeper = new DrPeper();// create a new product object called drPeper
        Skittles skittles = new Skittles();// create a new product object called skittles
        Pepsi pepsi = new Pepsi();// create a new product object called pepsi
        Hersey hersey = new Hersey();// create a new product object called hersey
        Funyuns funyuns = new Funyuns();// create a new product object called funyuns
        PeanutButter peanutButter = new PeanutButter();// create a new product object called peanutButter       

        double amountPaid = 0.00; // variable that will contain the value of the amnount the user entered into the machine.
        double changeBack = 0; // that variable that will contain the value of the change back.
        string optionChosen;  // this will tell the user what product he chose before his purchase as a form of confirmation   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e) // the event that will allow the user to enter in quarters
        {
            amountPaid += .25;
            amountPaidText.Text = amountPaid.ToString("C"); // outputs the amount of quarters into the text field
        }

        private void button16_Click(object sender, EventArgs e)  // the event that will allow the user to enter in dollars
        {
            amountPaid += 1.00;
            amountPaidText.Text = amountPaid.ToString("C"); // outputs the amount of dollars into the text field
        }

        private void button1_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "A1111";
            itemChosenText.Text = optionChosen + " " + snickers.ProductName + " " + snickers.ProductPrice.ToString("C");
        }

        private void button2_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "A1112";
            itemChosenText.Text = optionChosen + " " + doritos.ProductName + " " + doritos.ProductPrice.ToString("C");
        }

        private void button3_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "A1113";
            itemChosenText.Text = optionChosen + " " + hersey.ProductName + " " + hersey.ProductPrice.ToString("C");
        }

        private void button4_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "A1114";
            itemChosenText.Text = optionChosen + " " + funyuns.ProductName + " " + funyuns.ProductPrice.ToString("C");
        }

        private void button5_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "B1111";
            itemChosenText.Text = optionChosen + " " + peanutButter.ProductName + " " + peanutButter.ProductPrice.ToString("C");
        }

        private void button6_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "B1112";
            itemChosenText.Text = optionChosen + " " + pepsi.ProductName + " " + pepsi.ProductPrice.ToString("C");
        }

        private void button7_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "B1113";
            itemChosenText.Text = optionChosen + " " + drPeper.ProductName + " " + drPeper.ProductPrice.ToString("C");
        }

        private void button19_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            optionChosen = "B1114";
            itemChosenText.Text = optionChosen + " " + skittles.ProductName + " " + skittles.ProductPrice.ToString("C");
        }

        private void button12_Click(object sender, EventArgs e) // button event to represnt the users selection of this product.
        {
            amountPaidText.Text = "";

            if (optionChosen == "A1111" && snickers.ProductPrice <= amountPaid) // if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - snickers.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                snickers.ProductCount -= 1;
            }

            else if (optionChosen == "A1112" && doritos.ProductPrice <= amountPaid) // if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - doritos.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                doritos.ProductCount -= 1;
            }

            else if (optionChosen == "A1113" && hersey.ProductPrice <= amountPaid)// if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - hersey.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                hersey.ProductCount -= 1;
            }

            else if (optionChosen == "A1114" && funyuns.ProductPrice <= amountPaid)// if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - funyuns.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                funyuns.ProductCount -= 1;
            }

            else if (optionChosen == "B1111" && peanutButter.ProductPrice <= amountPaid)// if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - peanutButter.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                peanutButter.ProductCount -= 1;
            }

            else if (optionChosen == "B1112" && pepsi.ProductPrice <= amountPaid)// if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - pepsi.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                pepsi.ProductCount -= 1;
            }

            else if (optionChosen == "B1113" && drPeper.ProductPrice <= amountPaid)// if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - drPeper.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                drPeper.ProductCount -= 1;
            }

            else if (optionChosen == "B1114" && skittles.ProductPrice <= amountPaid) // if these conditions are true the calculations for change is done, the proper out put is done, and 1 unit is removed from the product.
            {
                changeBack = amountPaid - skittles.ProductPrice;
                changeBackText.Text = changeBack.ToString("C");
                skittles.ProductCount -= 1;
            }

            else
            {
                MessageBox.Show("Please add more money to complete the transaction."); // if false, this message will appear telling the user to enter in more money.
            }
        }

        private void button9_Click(object sender, EventArgs e)// button to allow user to take their money and/or exit program.
        {
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)// restes the fields so the user can continue another tansaction correctly.
        {
            if (amountPaid > 0)
            {
                amountPaid = changeBack;
                amountPaidText.Text = "";
               // changeBackText.Text = "";
                itemChosenText.Text = "";
                label33.Text = "";
            }

            else
            {
                amountPaidText.Text = "";
                changeBackText.Text = "";
                itemChosenText.Text = "";
                label33.Text = "";
                amountPaid = 0;
                changeBack = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e) // output to labeles the product name and qty from the csv
        {

            string items = "";
            StreamReader inputFile;
            inputFile = File.OpenText(@"H:\JunkFood.csv");
            int i;

            for (i = 0; i < 1; i++) // handles snickers
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label19.Text = tokens[0].ToString();
                    productLabel1.Text = tokens[2].ToString();
                }
            }

            for (i = 0; i < 1; i++) // handles doritos
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label22.Text = tokens[0].ToString();
                    label9.Text = tokens[2].ToString();
                }
            }

            for (i = 0; i < 1; i++) // handles dr peper
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label23.Text = tokens[0].ToString();
                    label11.Text = tokens[2].ToString();
                }
            }
            for (i = 0; i < 1; i++) // handles skittles
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label24.Text = tokens[0].ToString();
                    label13.Text = tokens[2].ToString();
                }
            }

            for (i = 0; i < 1; i++) // handles pepsi
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label25.Text = tokens[0].ToString();
                    label15.Text = tokens[2].ToString();
                }
            }

            for (i = 0; i < 1; i++) // handles hersey
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label26.Text = tokens[0].ToString();
                    label18.Text = tokens[2].ToString();
                }
            }


            for (i = 0; i < 1; i++) // handles funyuns
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label27.Text = tokens[0].ToString();
                    label28.Text = tokens[2].ToString();
                }
            }

            for (i = 0; i < 1; i++) // handles peanutbutter
            {
                items = inputFile.ReadLine();
                char[] delim = { ',' };
                string[] tokens = new string[8];
                tokens = items.Split(delim);

                foreach (string s in tokens)
                {
                    label30.Text = tokens[0].ToString();
                    label31.Text = tokens[2].ToString();
                }
            }
            inputFile.Close();
        }

        private void button13_Click(object sender, EventArgs e) // simulates the cancel of the transaction
        {
            changeBack = 0;
            amountPaid = 0;
            amountPaidText.Text = "";
            itemChosenText.Text = "";
            changeBackText.Text = "";
            label33.Text = "Your change has been returned to you.";
        }
    }
}
