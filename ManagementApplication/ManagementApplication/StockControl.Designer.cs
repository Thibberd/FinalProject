namespace ManagementApplication
{
    partial class StockControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            this.systembarDataSet = new ManagementApplication.systembarDataSet();
            this.stockControlViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlViewTableAdapter = new ManagementApplication.systembarDataSetTableAdapters.StockControlViewTableAdapter();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systembarDataSet1 = new ManagementApplication.systembarDataSet1();
            this.productTableAdapter = new ManagementApplication.systembarDataSet1TableAdapters.ProductTableAdapter();
            this.StockGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new ManagementApplication.StockDataSet();
            this.stockTableAdapter = new ManagementApplication.StockDataSetTableAdapters.StockTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reportsbtn = new System.Windows.Forms.Button();
            this.Bankingbtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.UserAdminbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // systembarDataSet
            // 
            this.systembarDataSet.DataSetName = "systembarDataSet";
            this.systembarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockControlViewBindingSource
            // 
            this.stockControlViewBindingSource.DataMember = "StockControlView";
            this.stockControlViewBindingSource.DataSource = this.systembarDataSet;
            // 
            // stockControlViewTableAdapter
            // 
            this.stockControlViewTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(515, 410);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(220, 54);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ProductView
            // 
            this.ProductView.AllowUserToDeleteRows = false;
            this.ProductView.AllowUserToOrderColumns = true;
            this.ProductView.AutoGenerateColumns = false;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn});
            this.ProductView.DataSource = this.productBindingSource;
            this.ProductView.Location = new System.Drawing.Point(260, 66);
            this.ProductView.Name = "ProductView";
            this.ProductView.Size = new System.Drawing.Size(323, 305);
            this.ProductView.TabIndex = 5;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.systembarDataSet1;
            // 
            // systembarDataSet1
            // 
            this.systembarDataSet1.DataSetName = "systembarDataSet1";
            this.systembarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // StockGridView
            // 
            this.StockGridView.AutoGenerateColumns = false;
            this.StockGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.StockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn1,
            this.stockCountDataGridViewTextBoxColumn,
            this.countedDateDataGridViewTextBoxColumn});
            this.StockGridView.DataSource = this.stockBindingSource;
            this.StockGridView.Location = new System.Drawing.Point(647, 66);
            this.StockGridView.Name = "StockGridView";
            this.StockGridView.Size = new System.Drawing.Size(352, 305);
            this.StockGridView.TabIndex = 6;
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            // 
            // stockCountDataGridViewTextBoxColumn
            // 
            this.stockCountDataGridViewTextBoxColumn.DataPropertyName = "StockCount";
            this.stockCountDataGridViewTextBoxColumn.HeaderText = "StockCount";
            this.stockCountDataGridViewTextBoxColumn.Name = "stockCountDataGridViewTextBoxColumn";
            // 
            // countedDateDataGridViewTextBoxColumn
            // 
            this.countedDateDataGridViewTextBoxColumn.DataPropertyName = "CountedDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.countedDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.countedDateDataGridViewTextBoxColumn.HeaderText = "Counted Date";
            this.countedDateDataGridViewTextBoxColumn.Name = "countedDateDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stock Management";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.LogOutbtn);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Reportsbtn);
            this.groupBox1.Controls.Add(this.Bankingbtn);
            this.groupBox1.Controls.Add(this.StockBtn);
            this.groupBox1.Controls.Add(this.UserAdminbtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 485);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(79, 456);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutbtn.TabIndex = 12;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(183, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azure";
            // 
            // Reportsbtn
            // 
            this.Reportsbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reportsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportsbtn.Location = new System.Drawing.Point(6, 346);
            this.Reportsbtn.Name = "Reportsbtn";
            this.Reportsbtn.Size = new System.Drawing.Size(230, 76);
            this.Reportsbtn.TabIndex = 4;
            this.Reportsbtn.Text = "Reports";
            this.Reportsbtn.UseVisualStyleBackColor = false;
            // 
            // Bankingbtn
            // 
            this.Bankingbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bankingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bankingbtn.Location = new System.Drawing.Point(6, 250);
            this.Bankingbtn.Name = "Bankingbtn";
            this.Bankingbtn.Size = new System.Drawing.Size(230, 76);
            this.Bankingbtn.TabIndex = 3;
            this.Bankingbtn.Text = "Banking ";
            this.Bankingbtn.UseVisualStyleBackColor = false;
            // 
            // StockBtn
            // 
            this.StockBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockBtn.Location = new System.Drawing.Point(6, 156);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(230, 76);
            this.StockBtn.TabIndex = 2;
            this.StockBtn.Text = "Stock Control";
            this.StockBtn.UseVisualStyleBackColor = false;
            // 
            // UserAdminbtn
            // 
            this.UserAdminbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserAdminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdminbtn.Location = new System.Drawing.Point(6, 65);
            this.UserAdminbtn.Name = "UserAdminbtn";
            this.UserAdminbtn.Size = new System.Drawing.Size(230, 76);
            this.UserAdminbtn.TabIndex = 1;
            this.UserAdminbtn.Text = "User Admin";
            this.UserAdminbtn.UseVisualStyleBackColor = false;
            
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1011, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StockGridView);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.UpdateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockControl";
            this.Text = "StockControl";
            this.Load += new System.EventHandler(this.StockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private systembarDataSet systembarDataSet;
        private System.Windows.Forms.BindingSource stockControlViewBindingSource;
        private systembarDataSetTableAdapters.StockControlViewTableAdapter stockControlViewTableAdapter;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView ProductView;
        private systembarDataSet1 systembarDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private systembarDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView StockGridView;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private StockDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reportsbtn;
        private System.Windows.Forms.Button Bankingbtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button UserAdminbtn;
    }
}