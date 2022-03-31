using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structurewindowform
{
    public partial class Form1 : Form
    {
        struct BookShop
        {
            public string title;
            public string author;
            public string edition;
            public int book_id;
        };
        BookShop B1;
        BookShop B2;
        BookShop B3;
        BookShop B4;
        BookShop B5;
        BookShop B6;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            B1.title = "The Best Public speaking Book";
            B1.author = "Alex";
            B1.edition = "Second";
            B1.book_id = 32467523;

            MessageBox.Show("Tile of book : " + " " + B1.title + " \n " + "Author : "
                + " " + B1.author + " \n " + "Edition : " + " " + B1.edition + "\n "
                + "book_id : " + " " + B1.book_id,"Book Information Screen");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            B2.title = "the big deal";
            B2.author = "Candy";
            B2.edition = "Forth";
            B2.book_id = 97458838;

            MessageBox.Show("Tile of book : " + " " + B2.title + " \n " + "Author : "
                + " " + B2.author + " \n " + "Edition : " + " " + B2.edition + "\n "
                + "book_id : " + " " + B2.book_id, "Book Information Screen");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            B3.title = "Introduction to Computer";
            B3.author = "Arooshy";
            B3.edition = "Second";
            B3.book_id = 56453423;

            MessageBox.Show("Tile of book : " + " " + B3.title + " \n " + "Author : "
                + " " + B3.author + " \n " + "Edition : " + " " + B3.edition + "\n "
                + "book_id : " + " " + B3.book_id, "Book Information Screen");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            B4.title = "HARRY POTTER";
            B4.author = "J.K. ROWLING";
            B4.edition = "Chapter 4";
            B4.book_id = 87453290;

            MessageBox.Show("Tile of book : " + " " + B4.title + " \n " + "Author : "
                + " " + B4.author + " \n " + "Edition : " + " " + B4.edition + "\n "
                + "book_id : " + " " + B4.book_id, "Book Information Screen");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            B5.title = "Inspired English 2";
            B5.author = "Zahra";
            B5.edition = "First";
            B5.book_id = 98457624;

            MessageBox.Show("Tile of book : " + " " + B5.title + " \n " + "Author : "
                + " " + B5.author + " \n " + "Edition : " + " " + B5.edition + "\n "
                + "book_id : " + " " + B5.book_id, "Book Information Screen");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            B6.title = "THE HISTORY OF PHILOSOPHY";
            B6.author = "Nigar";
            B6.edition = "Fifth Edition";
            B6.book_id = 97639483;

            MessageBox.Show("Tile of book : " + " " + B6.title + " \n " + "Author : "
                + " " + B6.author + " \n " + "Edition : " + " " + B6.edition + "\n "
                + "book_id : " + " " + B6.book_id, "Book Information Screen");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kindly place your Order :)", "Order Screen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You exit the screen \n Thank You for visiting our site", "Exit Screen");
            Application.Exit();
        }
    }
}
