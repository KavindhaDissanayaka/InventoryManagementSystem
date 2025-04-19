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
using BusinessLayer.Models;

namespace InventoryManagementSystem.Forms
{
    public partial class ItemForm : Form
    {
        ItemCRUD myItemCrud = new ItemCRUD();
        Item myItem = new Item();

        public ItemForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            txtSupplier.Clear();
            txtReorderLevel.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            gvList.DataSource = myItemCrud.GetAllItems().Tables[0];
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Invalid Name");
                txtName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Invalid Quantity");
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Invalid Supplier");
                txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Invalid Category");
                txtCategory.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Invalid price");
                txtPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtReorderLevel.Text))
            {
                MessageBox.Show("Invalid ReOrderLevel");
                txtReorderLevel.Focus();
            }
            else
            {
                myItem.Name = txtName.Text;
                myItem.Supplier = txtSupplier.Text;
                myItem.Category = txtCategory.Text;
                myItem.Price = Convert.ToDecimal(txtPrice.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtReorderLevel.Text);
                myItem.Quantity = Convert.ToInt32(txtQuantity.Text);

                myItemCrud.CreateItem(myItem);
                MessageBox.Show("New Item Added");
                btnClear.PerformClick();
            }
        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myItem.ItemId = Convert.ToInt32(gvList.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = gvList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantity.Text = gvList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSupplier.Text = gvList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCategory.Text = gvList.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrice.Text = gvList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtReorderLevel.Text = gvList.Rows[e.RowIndex].Cells[6].Value.ToString();

            gvList.Rows.RemoveAt(e.RowIndex);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Invalid Name");
                txtName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Invalid Quantity");
                txtQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Invalid Supplier");
                txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Invalid Category");
                txtCategory.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Invalid price");
                txtPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtReorderLevel.Text))
            {
                MessageBox.Show("Invalid ReOrderLevel");
                txtReorderLevel.Focus();
            }
            else
            {
                myItem.Name = txtName.Text;
                myItem.Supplier = txtSupplier.Text;
                myItem.Category = txtCategory.Text;
                myItem.Price = Convert.ToDecimal(txtPrice.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtReorderLevel.Text);
                myItem.Quantity = Convert.ToInt32(txtQuantity.Text);

                myItemCrud.UpdateItem(myItem);
                MessageBox.Show("Item Updated");
                btnClear.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm For Delete The selected Item", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                myItemCrud.DeleteItem(myItem);
                MessageBox.Show("Item Deleted");
                btnClear.PerformClick();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalInputHandler.HandleIntigerInput(sender, e, false);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalInputHandler.HandleDecimalInput(sender, e, false);
        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            DecimalInputHandler.HandleIntigerInput(sender, e, false);
        }
    }
}
