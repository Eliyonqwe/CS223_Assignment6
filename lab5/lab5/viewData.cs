using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabClass4
{
    public partial class viewData : Form
    {
        internal static List<item> items = new List<item>();

       
        public viewData()
        {
            InitializeComponent();
            dataGridView1.DataSource = item.items;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            welcomePage w = new welcomePage();
            this.Hide();
            w.Show();
        }

        private void bt_search_Click_1(object sender, EventArgs e)
        {
            String search = tb_search.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("No results found!");
            }

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
