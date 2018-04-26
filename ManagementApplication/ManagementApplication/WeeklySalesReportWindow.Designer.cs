namespace ManagementApplication
{
    partial class WeeklySalesReportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklySalesReportWindow));
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weeklySalesView = new ManagementApplication.WeeklySalesView();
            this.typeOfSaleByAmountLastWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfSaleByAmountLastWeekTableAdapter = new ManagementApplication.WeeklySalesViewTableAdapters.TypeOfSaleByAmountLastWeekTableAdapter();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySalesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfSaleByAmountLastWeekBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 485);
            this.groupBox1.TabIndex = 13;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Weekly Sales Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionTypeDataGridViewTextBoxColumn,
            this.salesAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeOfSaleByAmountLastWeekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(438, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(329, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // weeklySalesView
            // 
            this.weeklySalesView.DataSetName = "WeeklySalesView";
            this.weeklySalesView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeOfSaleByAmountLastWeekBindingSource
            // 
            this.typeOfSaleByAmountLastWeekBindingSource.DataMember = "TypeOfSaleByAmountLastWeek";
            this.typeOfSaleByAmountLastWeekBindingSource.DataSource = this.weeklySalesView;
            // 
            // typeOfSaleByAmountLastWeekTableAdapter
            // 
            this.typeOfSaleByAmountLastWeekTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesAmountDataGridViewTextBoxColumn
            // 
            this.salesAmountDataGridViewTextBoxColumn.DataPropertyName = "Sales Amount";
            this.salesAmountDataGridViewTextBoxColumn.HeaderText = "SalesAmount";
            this.salesAmountDataGridViewTextBoxColumn.Name = "salesAmountDataGridViewTextBoxColumn";
            this.salesAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WeeklySalesReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(953, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WeeklySalesReportWindow";
            this.Text = "WeeklySalesReportWindow";
            this.Load += new System.EventHandler(this.WeeklySalesReportWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySalesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfSaleByAmountLastWeekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WeeklySalesView weeklySalesView;
        private System.Windows.Forms.BindingSource typeOfSaleByAmountLastWeekBindingSource;
        private WeeklySalesViewTableAdapters.TypeOfSaleByAmountLastWeekTableAdapter typeOfSaleByAmountLastWeekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesAmountDataGridViewTextBoxColumn;
    }
}