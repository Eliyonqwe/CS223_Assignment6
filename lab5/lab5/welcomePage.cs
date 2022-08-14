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
    public partial class welcomePage  : Form
    {
        String user = "";
        DataGridView d = new DataGridView();
        internal welcomePage(String user)
        {
            InitializeComponent();
            this.user = user;
        }
        internal welcomePage()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPage m = new mainPage(user);
            this.Hide();
            m.Show();
        }
        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewData v = new viewData();
            this.Hide();
            v.Show();
        }
    }
}
