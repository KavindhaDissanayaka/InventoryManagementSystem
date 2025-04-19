using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace InventoryManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm myFrm = new ItemForm();
            myFrm.MdiParent = this;
            myFrm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DbModifications dbModifications = new DbModifications();
            dbModifications.CreateTable();
        }
    }
}
