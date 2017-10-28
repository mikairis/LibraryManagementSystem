using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ManageBookInfo : Form
    {
        Book book;
        Book b = new Book();

        public ManageBookInfo()
        {
            InitializeComponent();
        }
        public ManageBookInfo(Book b)
        {
            InitializeComponent();
            this.book = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SA45Team03BEntities2 context = new SA45Team03BEntities2())
            {
                if (book == null)
                {
                    b.BookTitle = textBox1.Text;
                    b.BookCategory = comboBox1.Text;
                    b.Rating = comboBox2.Text;
                    b.AuthorID = Convert.ToInt32(comboBox3.Text);
                    b.PublisherID = Convert.ToInt32(comboBox4.Text);
                    b.Location = comboBox5.Text;
                    b.CountryCode = Convert.ToInt32(comboBox6.Text);
                    b.TotalStock = Convert.ToInt32(textBox2.Text);
                    b.NumberAvaliable = Convert.ToInt32(textBox3.Text);

                    int i = Convert.ToInt32(b.TotalStock) - Convert.ToInt32(b.NumberAvaliable);
                    b.NumberRented = i;
                    textBox4.Text = i.ToString();

                    context.Books.Add(b);
                    MessageBox.Show("Book Added Successfully!");
                }
                else if (book != null)
                {
                    b.BookTitle = textBox1.Text;
                    b.BookCategory = comboBox1.Text;
                    b.Rating = comboBox2.Text;
                    b.AuthorID = Convert.ToInt32(comboBox3.Text);
                    b.PublisherID = Convert.ToInt32(comboBox4.Text);
                    b.Location = comboBox5.Text;
                    b.CountryCode = Convert.ToInt32(comboBox6.Text);
                    b.TotalStock = Convert.ToInt32(textBox2.Text);
                    b.NumberAvaliable = Convert.ToInt32(textBox3.Text);

                    int i = Convert.ToInt32(b.TotalStock) - Convert.ToInt32(b.NumberAvaliable);
                    b.NumberRented = i;
                    textBox4.Text = i.ToString();
                    MessageBox.Show("Book Updated Successfully!");
                }
                context.SaveChanges();
                
                this.Close();
            }
        }

        private void ManageBookInfo_Load(object sender, EventArgs e)
        {
            using (SA45Team03BEntities2 context = new SA45Team03BEntities2())
            {
                var q = from x in context.ExtendApplications select x.TransactionID;
                foreach (var i in q)
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

    }
}