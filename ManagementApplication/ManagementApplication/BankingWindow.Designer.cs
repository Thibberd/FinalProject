namespace ManagementApplication
{
    partial class BankingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reportsbtn = new System.Windows.Forms.Button();
            this.Bankingbtn = new System.Windows.Forms.Button();
            this.StockControlbtn = new System.Windows.Forms.Button();
            this.UserAdminbtn = new System.Windows.Forms.Button();
            this.BankingView = new System.Windows.Forms.DataGridView();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systembarDataSet2 = new ManagementApplication.systembarDataSet2();
            this.bankTableAdapter = new ManagementApplication.systembarDataSet2TableAdapters.BankTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.bankingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedEFTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualCashTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualEFTTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDifferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.LogOutbtn);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Reportsbtn);
            this.groupBox1.Controls.Add(this.Bankingbtn);
            this.groupBox1.Controls.Add(this.StockControlbtn);
            this.groupBox1.Controls.Add(this.UserAdminbtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 503);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(77, 465);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutbtn.TabIndex = 13;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(177, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(177, 272);
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
            this.pictureBox2.Location = new System.Drawing.Point(177, 173);
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
            this.pictureBox1.Location = new System.Drawing.Point(177, 88);
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
            this.label1.Location = new System.Drawing.Point(72, 16);
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
            this.Reportsbtn.Size = new System.Drawing.Size(218, 76);
            this.Reportsbtn.TabIndex = 4;
            this.Reportsbtn.Text = "Reports";
            this.Reportsbtn.UseVisualStyleBackColor = false;
            this.Reportsbtn.Click += new System.EventHandler(this.Reportsbtn_Click);
            // 
            // Bankingbtn
            // 
            this.Bankingbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bankingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bankingbtn.Location = new System.Drawing.Point(6, 250);
            this.Bankingbtn.Name = "Bankingbtn";
            this.Bankingbtn.Size = new System.Drawing.Size(218, 76);
            this.Bankingbtn.TabIndex = 3;
            this.Bankingbtn.Text = "Banking ";
            this.Bankingbtn.UseVisualStyleBackColor = false;
            // 
            // StockControlbtn
            // 
            this.StockControlbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockControlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockControlbtn.Location = new System.Drawing.Point(6, 156);
            this.StockControlbtn.Name = "StockControlbtn";
            this.StockControlbtn.Size = new System.Drawing.Size(218, 76);
            this.StockControlbtn.TabIndex = 2;
            this.StockControlbtn.Text = "Stock Control";
            this.StockControlbtn.UseVisualStyleBackColor = false;
            this.StockControlbtn.Click += new System.EventHandler(this.StockControlbtn_Click);
            // 
            // UserAdminbtn
            // 
            this.UserAdminbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserAdminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdminbtn.Location = new System.Drawing.Point(6, 65);
            this.UserAdminbtn.Name = "UserAdminbtn";
            this.UserAdminbtn.Size = new System.Drawing.Size(218, 76);
            this.UserAdminbtn.TabIndex = 1;
            this.UserAdminbtn.Text = "User Admin";
            this.UserAdminbtn.UseVisualStyleBackColor = false;
            this.UserAdminbtn.Click += new System.EventHandler(this.UserAdminbtn_Click);
            // 
            // BankingView
            // 
            this.BankingView.AllowUserToDeleteRows = false;
            this.BankingView.AutoGenerateColumns = false;
            this.BankingView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.BankingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankingIDDataGridViewTextBoxColumn,
            this.expectedCashDataGridViewTextBoxColumn,
            this.expectedEFTDataGridViewTextBoxColumn,
            this.actualCashTotalDataGridViewTextBoxColumn,
            this.actualEFTTotalDataGridViewTextBoxColumn,
            this.safeCountDataGridViewTextBoxColumn,
            this.totalDifferenceDataGridViewTextBoxColumn,
            this.bankingDateDataGridViewTextBoxColumn});
            this.BankingView.DataSource = this.bankBindingSource;
            this.BankingView.Location = new System.Drawing.Point(266, 83);
            this.BankingView.Name = "BankingView";
            this.BankingView.Size = new System.Drawing.Size(849, 333);
            this.BankingView.TabIndex = 3;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.systembarDataSet2;
            // 
            // systembarDataSet2
            // 
            this.systembarDataSet2.DataSetName = "systembarDataSet2";
            this.systembarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banking and Finance";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(551, 443);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(220, 54);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // bankingIDDataGridViewTextBoxColumn
            // 
            this.bankingIDDataGridViewTextBoxColumn.DataPropertyName = "BankingID";
            this.bankingIDDataGridViewTextBoxColumn.HeaderText = "BankingID";
            this.bankingIDDataGridViewTextBoxColumn.Name = "bankingIDDataGridViewTextBoxColumn";
            // 
            // expectedCashDataGridViewTextBoxColumn
            // 
            this.expectedCashDataGridViewTextBoxColumn.DataPropertyName = "ExpectedCash";
            this.expectedCashDataGridViewTextBoxColumn.HeaderText = "ExpectedCash";
            this.expectedCashDataGridViewTextBoxColumn.Name = "expectedCashDataGridViewTextBoxColumn";
            // 
            // expectedEFTDataGridViewTextBoxColumn
            // 
            this.expectedEFTDataGridViewTextBoxColumn.DataPropertyName = "ExpectedEFT";
            this.expectedEFTDataGridViewTextBoxColumn.HeaderText = "ExpectedEFT";
            this.expectedEFTDataGridViewTextBoxColumn.Name = "expectedEFTDataGridViewTextBoxColumn";
            // 
            // actualCashTotalDataGridViewTextBoxColumn
            // 
            this.actualCashTotalDataGridViewTextBoxColumn.DataPropertyName = "ActualCashTotal";
            this.actualCashTotalDataGridViewTextBoxColumn.HeaderText = "ActualCashTotal";
            this.actualCashTotalDataGridViewTextBoxColumn.Name = "actualCashTotalDataGridViewTextBoxColumn";
            // 
            // actualEFTTotalDataGridViewTextBoxColumn
            // 
            this.actualEFTTotalDataGridViewTextBoxColumn.DataPropertyName = "ActualEFTTotal";
            this.actualEFTTotalDataGridViewTextBoxColumn.HeaderText = "ActualEFTTotal";
            this.actualEFTTotalDataGridViewTextBoxColumn.Name = "actualEFTTotalDataGridViewTextBoxColumn";
            // 
            // safeCountDataGridViewTextBoxColumn
            // 
            this.safeCountDataGridViewTextBoxColumn.DataPropertyName = "SafeCount";
            this.safeCountDataGridViewTextBoxColumn.HeaderText = "SafeCount";
            this.safeCountDataGridViewTextBoxColumn.Name = "safeCountDataGridViewTextBoxColumn";
            // 
            // totalDifferenceDataGridViewTextBoxColumn
            // 
            this.totalDifferenceDataGridViewTextBoxColumn.DataPropertyName = "TotalDifference";
            this.totalDifferenceDataGridViewTextBoxColumn.HeaderText = "TotalDifference";
            this.totalDifferenceDataGridViewTextBoxColumn.Name = "totalDifferenceDataGridViewTextBoxColumn";
            // 
            // bankingDateDataGridViewTextBoxColumn
            // 
            this.bankingDateDataGridViewTextBoxColumn.DataPropertyName = "BankingDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.bankingDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.bankingDateDataGridViewTextBoxColumn.HeaderText = "Banking Date";
            this.bankingDateDataGridViewTextBoxColumn.Name = "bankingDateDataGridViewTextBoxColumn";
            // 
            // BankingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1138, 499);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankingView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankingWindow";
            this.Text = "Banking";
            this.Load += new System.EventHandler(this.BankingWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systembarDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reportsbtn;
        private System.Windows.Forms.Button Bankingbtn;
        private System.Windows.Forms.Button StockControlbtn;
        private System.Windows.Forms.Button UserAdminbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView BankingView;
        private systembarDataSet2 systembarDataSet2;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private systembarDataSet2TableAdapters.BankTableAdapter bankTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedCashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedEFTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualCashTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualEFTTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDifferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankingDateDataGridViewTextBoxColumn;
    }
}