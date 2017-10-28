using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class StaffHome : Form
    {
        SA45Team03BEntities2 context = new SA45Team03BEntities2();
        Book b;
        ExtendApplication exApp;

        public StaffHome()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("3 个参数。。。 "," 亮仔提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int bookId = Int32.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
                Book b = context.Books.Where(x => x.BookCode == bookId).First();
                context.Books.Remove(b);
                context.SaveChanges();
                loadGrid();
                MessageBox.Show("Book successfully deleted!");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to update book records? Otherwise click 'No' to extend book application or 'Cancel' to exit.", "Exit", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                ManageBookInfo MBI = new ManageBookInfo(b);
                MBI.Show();
                this.loadGrid();
            }
            else if (result == DialogResult.No)
            {
                DialogResult result1 = MessageBox.Show("Would you like to manage book extension application? Or click 'Cancel' to exit.", "Exit", MessageBoxButtons.OKCancel);

                if (result1 == DialogResult.OK)
                {
                    ManageExtendeApplication MEA = new ManageExtendeApplication();
                    MEA.Show();
                    this.loadGridBookExtend();
                }
            }
        }

        private void ViewBookListBtn_Click(object sender, EventArgs e)
        {
            var q = from x in context.Books select x;
            List<Book> cLst = q.ToList<Book>();
            dataGridView.DataSource = cLst;
        }

        public void loadGrid()
        {
            var q = from x in context.Books select x;
            List<Book> cLst = q.ToList<Book>();
            dataGridView.DataSource = cLst;
        }

        public void loadGridBookExtend()
        {
            var q = from x in context.ExtendApplications select x;
            List<ExtendApplication> cLst = q.ToList<ExtendApplication>();
            dataGridView.DataSource = cLst;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ManageBookInfo MBI = new ManageBookInfo(b);
            MBI.Show();
            this.loadGrid();
            MessageBox.Show("Book Successfully Updated!");
        }

        private void ViewExtentionAppBtn_Click(object sender, EventArgs e)
        {
            var q = from x in context.ExtendApplications
                    select x;
            List<ExtendApplication> appList = q.ToList<ExtendApplication>();
            dataGridView.DataSource = appList;
        }
    }
}
