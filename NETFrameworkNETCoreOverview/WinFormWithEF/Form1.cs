using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWithEF
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns= true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MovieDbEntites dbContext = new MovieDbEntites())
            {
                bindingSource1.DataSource = dbContext.Movies.ToList();
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
