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
    public partial class ManageCustomerInfo : Form
    {
        public ManageCustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SA45Team03BEntities2 context = new SA45Team03BEntities2())
            {
                Customer c = new Customer();
                c.CustomerName = textBox1.Text;
                c.CustomerCategory = comboBox1.Text;
                c.Age = Convert.ToInt32(textBox5.Text);
                c.Address = textBox6.Text;
                c.City = textBox7.Text;
                c.PostalCode = textBox8.Text;
                c.ContactTitle = comboBox6.Text;
                c.PhoneNumber = textBox2.Text;
                c.EmailAddress = textBox3.Text;
                c.Notes = textBox4.Text;
                
                context.Customers.Add(c);
                context.SaveChanges();

                MessageBox.Show("Customer Created Successfully!");
            }



        }
    }
}
