namespace ProjectAlpha1
{
    partial class ADD_Product
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuItemPrice = new System.Windows.Forms.TextBox();
            this.ItemID = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.BTNClear = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.Itemtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSearchID = new System.Windows.Forms.Button();
            this.TextIDsearch = new System.Windows.Forms.TextBox();
            this.BTNSearchName = new System.Windows.Forms.Button();
            this.TextNameSearch = new System.Windows.Forms.TextBox();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.ErrorItemID = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorItemName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorItemType = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorSearchId = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorSearchName = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSearchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSearchName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 96);
            this.panel1.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Snap ITC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(474, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 32);
            this.label10.TabIndex = 94;
            this.label10.Text = "PRODUCTS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Snap ITC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(267, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(627, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "RESTAURANT MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuItemPrice);
            this.panel2.Controls.Add(this.ItemID);
            this.panel2.Controls.Add(this.label123);
            this.panel2.Controls.Add(this.BTNClear);
            this.panel2.Controls.Add(this.BTNExit);
            this.panel2.Controls.Add(this.BTNDelete);
            this.panel2.Controls.Add(this.BTNUpdate);
            this.panel2.Controls.Add(this.BTNSave);
            this.panel2.Controls.Add(this.Itemtype);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.ItemName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 493);
            this.panel2.TabIndex = 99;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MenuItemPrice
            // 
            this.MenuItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuItemPrice.Location = new System.Drawing.Point(137, 115);
            this.MenuItemPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuItemPrice.Name = "MenuItemPrice";
            this.MenuItemPrice.Size = new System.Drawing.Size(217, 27);
            this.MenuItemPrice.TabIndex = 101;
            this.MenuItemPrice.Leave += new System.EventHandler(this.MenuItemPrice_Leave);
            // 
            // ItemID
            // 
            this.ItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemID.Location = new System.Drawing.Point(137, 34);
            this.ItemID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(217, 27);
            this.ItemID.TabIndex = 100;
            this.ItemID.TextChanged += new System.EventHandler(this.ItemID_TextChanged);
            this.ItemID.Leave += new System.EventHandler(this.ItemID_Leave);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(71, 41);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(60, 20);
            this.label123.TabIndex = 99;
            this.label123.Text = "Item_ID";
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(243, 297);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(94, 29);
            this.BTNClear.TabIndex = 98;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(79, 297);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(94, 29);
            this.BTNExit.TabIndex = 97;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(79, 227);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(94, 29);
            this.BTNDelete.TabIndex = 96;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(157, 262);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(94, 29);
            this.BTNUpdate.TabIndex = 95;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(243, 227);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(94, 29);
            this.BTNSave.TabIndex = 94;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // Itemtype
            // 
            this.Itemtype.FormattingEnabled = true;
            this.Itemtype.Location = new System.Drawing.Point(137, 166);
            this.Itemtype.Name = "Itemtype";
            this.Itemtype.Size = new System.Drawing.Size(217, 28);
            this.Itemtype.TabIndex = 84;
            this.Itemtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Itemtype.Leave += new System.EventHandler(this.Itemtype_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Item_Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 78;
            this.label12.Text = "Item_Price";
            // 
            // ItemName
            // 
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName.Location = new System.Drawing.Point(137, 72);
            this.ItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(217, 27);
            this.ItemName.TabIndex = 77;
            this.ItemName.Leave += new System.EventHandler(this.ItemName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Item_Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTNSearchID
            // 
            this.BTNSearchID.Location = new System.Drawing.Point(828, 136);
            this.BTNSearchID.Name = "BTNSearchID";
            this.BTNSearchID.Size = new System.Drawing.Size(133, 29);
            this.BTNSearchID.TabIndex = 102;
            this.BTNSearchID.Text = "Search By ID";
            this.BTNSearchID.UseVisualStyleBackColor = true;
            this.BTNSearchID.Click += new System.EventHandler(this.BTNSearchID_Click);
            // 
            // TextIDsearch
            // 
            this.TextIDsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextIDsearch.Location = new System.Drawing.Point(590, 136);
            this.TextIDsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextIDsearch.Name = "TextIDsearch";
            this.TextIDsearch.Size = new System.Drawing.Size(217, 27);
            this.TextIDsearch.TabIndex = 103;
            this.TextIDsearch.Leave += new System.EventHandler(this.TextIDsearch_Leave);
            // 
            // BTNSearchName
            // 
            this.BTNSearchName.Location = new System.Drawing.Point(828, 190);
            this.BTNSearchName.Name = "BTNSearchName";
            this.BTNSearchName.Size = new System.Drawing.Size(133, 29);
            this.BTNSearchName.TabIndex = 104;
            this.BTNSearchName.Text = "Search by Name";
            this.BTNSearchName.UseVisualStyleBackColor = true;
            this.BTNSearchName.Click += new System.EventHandler(this.BTNSearchName_Click);
            // 
            // TextNameSearch
            // 
            this.TextNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextNameSearch.Location = new System.Drawing.Point(590, 190);
            this.TextNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextNameSearch.Name = "TextNameSearch";
            this.TextNameSearch.Size = new System.Drawing.Size(217, 27);
            this.TextNameSearch.TabIndex = 105;
            this.TextNameSearch.Leave += new System.EventHandler(this.TextNameSearch_Leave);
            // 
            // ProductDGV
            // 
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(506, 246);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 29;
            this.ProductDGV.Size = new System.Drawing.Size(604, 259);
            this.ProductDGV.TabIndex = 106;
            // 
            // ErrorItemID
            // 
            this.ErrorItemID.ContainerControl = this;
            // 
            // ErrorItemName
            // 
            this.ErrorItemName.ContainerControl = this;
            // 
            // ErrorItemType
            // 
            this.ErrorItemType.ContainerControl = this;
            // 
            // ErrorSearchId
            // 
            this.ErrorSearchId.ContainerControl = this;
            // 
            // ErrorSearchName
            // 
            this.ErrorSearchName.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(977, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 107;
            this.button1.Text = "View Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADD_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.BTNSearchName);
            this.Controls.Add(this.TextNameSearch);
            this.Controls.Add(this.BTNSearchID);
            this.Controls.Add(this.TextIDsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ADD_Product";
            this.Text = "ADD_Product";
            this.Load += new System.EventHandler(this.ADD_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSearchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSearchName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Label label3;
        private Label label12;
        private TextBox ItemName;
        private Label label2;
        private ComboBox Itemtype;
        private Button BTNClear;
        private Button BTNExit;
        private Button BTNDelete;
        private Button BTNUpdate;
        private Button BTNSave;
        private Button BTNSearchID;
        private TextBox TextIDsearch;
        private Button BTNSearchName;
        private TextBox TextNameSearch;
        private DataGridView ProductDGV;
        private TextBox ItemID;
        private Label label123;
        private ErrorProvider ErrorItemID;
        private ErrorProvider ErrorItemName;
        private ErrorProvider ErrorItemType;
        private ErrorProvider ErrorSearchId;
        private ErrorProvider ErrorSearchName;
        private Button button1;
        private TextBox MenuItemPrice;
    }
}