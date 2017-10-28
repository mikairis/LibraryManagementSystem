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
    public partial class ManageExtendeApplication : Form
    {
        public ManageExtendeApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SA45Team03BEntities2 context = new SA45Team03BEntities2())
            {
                ExtendApplication EA = new ExtendApplication();
                EA = context.ExtendApplications.Where(x => x.TransactionID.ToString() == comboBox1.Text.ToString()).First();
                EA.ExtendDays = Convert.ToInt32(textBox5.Text);
                EA.IsApproved = "Approved";
                EA.Remarks = textBox8.Text;
                context.SaveChanges();

                //var q = from x 
                //        in context.ExtendApplications.Where(x => x.TransactionID.ToString() == comboBox1.Text.ToString())
                //        select x;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SA45Team03BEntities2 context = new SA45Team03BEntities2())
            {
                int transID = Convert.ToInt32(comboBox1.Text);
                //Int16 transID = Int16.Parse(comboBox1.Text.ToString());
                IssueTran IT = context.IssueTrans.Where(x => x.TransactionID == transID).ToList().First();

                var q = from x in context.ExtendApplications where x.TransactionID == transID select x;
                ExtendApplication EA = q.First();
                textBox3.Text = IT.ToString();
            }
        }

        private void ManageExtendeApplication_Load(object sender, EventArgs e)
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
