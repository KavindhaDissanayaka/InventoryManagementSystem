namespace InventoryManagementSystem.Forms
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtReorderLevel = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label2 = new Label();
            txtSupplier = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            gvList = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtReorderLevel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(22, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 67);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 11;
            label4.Text = "Reorder Level";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(595, 64);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(130, 27);
            txtReorderLevel.TabIndex = 10;
            txtReorderLevel.KeyPress += txtReorderLevel_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 28);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(595, 26);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(130, 27);
            txtPrice.TabIndex = 8;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 71);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(332, 68);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 32);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Supplier";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(332, 29);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(125, 27);
            txtSupplier.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(18, 71);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(92, 68);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 2;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(22, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(754, 72);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(640, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(540, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gvList);
            groupBox3.Location = new Point(22, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(754, 382);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // gvList
            // 
            gvList.AllowUserToAddRows = false;
            gvList.AllowUserToDeleteRows = false;
            gvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvList.Dock = DockStyle.Fill;
            gvList.Location = new Point(3, 23);
            gvList.Name = "gvList";
            gvList.ReadOnly = true;
            gvList.RowHeadersWidth = 51;
            gvList.Size = new Size(748, 356);
            gvList.TabIndex = 0;
            gvList.CellDoubleClick += gvList_CellDoubleClick;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Entry From";
            Load += ItemForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtSupplier;
        private Label label3;
        private TextBox txtCategory;
        private Label label4;
        private TextBox txtReorderLevel;
        private Label label5;
        private TextBox txtPrice;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClose;
        private GroupBox groupBox3;
        private DataGridView gvList;
    }
}