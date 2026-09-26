namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbStudentNo = new Label();
            txtProductName = new TextBox();
            panel1 = new Panel();
            lbHeader = new Label();
            btnAddProduct = new Button();
            lbCategory = new Label();
            dtPickerMfgDate = new DateTimePicker();
            lbMfgDate = new Label();
            cbCategory = new ComboBox();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            dtPickerExpDate = new DateTimePicker();
            lbExpirationDate = new Label();
            txtSellPrice = new TextBox();
            lbSellPrice = new Label();
            richTxtDescription = new RichTextBox();
            lbDescriptino = new Label();
            gridViewProductList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lbStudentNo
            // 
            lbStudentNo.AutoSize = true;
            lbStudentNo.Font = new Font("Segoe UI", 14.25F);
            lbStudentNo.ForeColor = Color.White;
            lbStudentNo.Location = new Point(34, 136);
            lbStudentNo.Name = "lbStudentNo";
            lbStudentNo.Size = new Size(78, 25);
            lbStudentNo.TabIndex = 0;
            lbStudentNo.Text = "Product";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(146, 139);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(268, 25);
            txtProductName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbHeader);
            panel1.Location = new Point(1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 92);
            panel1.TabIndex = 16;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.White;
            lbHeader.Location = new Point(30, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(180, 47);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "Inventory";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(644, 366);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(123, 36);
            btnAddProduct.TabIndex = 17;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 14.25F);
            lbCategory.ForeColor = Color.White;
            lbCategory.Location = new Point(34, 174);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(88, 25);
            lbCategory.TabIndex = 18;
            lbCategory.Text = "Category";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.CustomFormat = "MM/dd/yyyy";
            dtPickerMfgDate.Format = DateTimePickerFormat.Custom;
            dtPickerMfgDate.Location = new Point(146, 218);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(268, 25);
            dtPickerMfgDate.TabIndex = 20;
            dtPickerMfgDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbMfgDate
            // 
            lbMfgDate.AutoSize = true;
            lbMfgDate.Font = new Font("Segoe UI", 14.25F);
            lbMfgDate.ForeColor = Color.White;
            lbMfgDate.Location = new Point(34, 218);
            lbMfgDate.Name = "lbMfgDate";
            lbMfgDate.Size = new Size(90, 25);
            lbMfgDate.TabIndex = 21;
            lbMfgDate.Text = "Mfg Date";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(146, 177);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(268, 25);
            cbCategory.TabIndex = 19;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 14.25F);
            lbQuantity.ForeColor = Color.White;
            lbQuantity.Location = new Point(34, 291);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(41, 25);
            lbQuantity.TabIndex = 0;
            lbQuantity.Text = "Qty";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(146, 294);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(268, 25);
            txtQuantity.TabIndex = 1;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.CustomFormat = "MM/dd/yyyy";
            dtPickerExpDate.Format = DateTimePickerFormat.Custom;
            dtPickerExpDate.Location = new Point(146, 257);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(268, 25);
            dtPickerExpDate.TabIndex = 20;
            dtPickerExpDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.Font = new Font("Segoe UI", 14.25F);
            lbExpirationDate.ForeColor = Color.White;
            lbExpirationDate.Location = new Point(34, 257);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(86, 25);
            lbExpirationDate.TabIndex = 21;
            lbExpirationDate.Text = "Exp Date";
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellPrice.Location = new Point(146, 330);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(268, 25);
            txtSellPrice.TabIndex = 23;
            // 
            // lbSellPrice
            // 
            lbSellPrice.AutoSize = true;
            lbSellPrice.Font = new Font("Segoe UI", 14.25F);
            lbSellPrice.ForeColor = Color.White;
            lbSellPrice.Location = new Point(34, 327);
            lbSellPrice.Name = "lbSellPrice";
            lbSellPrice.Size = new Size(89, 25);
            lbSellPrice.TabIndex = 22;
            lbSellPrice.Text = "Sell Price";
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(455, 174);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(313, 181);
            richTxtDescription.TabIndex = 24;
            richTxtDescription.Text = "";
            // 
            // lbDescriptino
            // 
            lbDescriptino.AutoSize = true;
            lbDescriptino.Font = new Font("Segoe UI", 14.25F);
            lbDescriptino.ForeColor = Color.White;
            lbDescriptino.Location = new Point(455, 139);
            lbDescriptino.Name = "lbDescriptino";
            lbDescriptino.Size = new Size(108, 25);
            lbDescriptino.TabIndex = 25;
            lbDescriptino.Text = "Description";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(34, 408);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(734, 155);
            gridViewProductList.TabIndex = 26;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(806, 591);
            Controls.Add(gridViewProductList);
            Controls.Add(lbDescriptino);
            Controls.Add(richTxtDescription);
            Controls.Add(txtSellPrice);
            Controls.Add(lbSellPrice);
            Controls.Add(lbExpirationDate);
            Controls.Add(dtPickerExpDate);
            Controls.Add(lbMfgDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(lbCategory);
            Controls.Add(btnAddProduct);
            Controls.Add(panel1);
            Controls.Add(txtQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(txtProductName);
            Controls.Add(lbStudentNo);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStudentNo;
        private TextBox txtProductName;
        private Panel panel1;
        private Label lbHeader;
        private Button btnAddProduct;
        private DateTimePicker dtPickerMfgDate;
        private Label lbMfgDate;
        private ComboBox cbCategory;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private DateTimePicker dtPickerExpDate;
        private Label lbExpirationDate;
        private TextBox txtSellPrice;
        private Label lbSellPrice;
        private RichTextBox richTxtDescription;
        private Label lbDescriptino;
        private DataGridView gridViewProductList;
        private Label lbCategory;
    }
}
