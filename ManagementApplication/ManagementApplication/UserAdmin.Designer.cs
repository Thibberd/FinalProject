namespace ManagementApplication
{
    partial class UserAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdmin));
            this.UserDataTable = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userData = new ManagementApplication.UserData();
            this.usersTableAdapter = new ManagementApplication.UserDataTableAdapters.UsersTableAdapter();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.UserAdminbtn = new System.Windows.Forms.Button();
            this.Reportsbtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.Bankingbtn = new System.Windows.Forms.Button();
            this.products_Above_Average_PriceTableAdapter = new ManagementApplication.ProductsOverAveragePriceViewTableAdapters.Products_Above_Average_PriceTableAdapter();
            this.userSalesbyWeekTableAdapter = new ManagementApplication.userSalesbyWeekTableAdapters.userSalesbyWeekTableAdapter();
            this.typeOfSaleByAmountTableAdapter = new ManagementApplication.TypeOfsalebyAmountTableAdapters.TypeOfSaleByAmountTableAdapter();
            this.lastMonthlySalesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastMonthlySalesView = new ManagementApplication.LastMonthlySalesView();
            this.productsOverAveragePriceView = new ManagementApplication.ProductsOverAveragePriceView();
            this.productsAboveAveragePriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfsalebyAmount = new ManagementApplication.TypeOfsalebyAmount();
            this.typeOfSaleByAmountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSalesbyWeek = new ManagementApplication.userSalesbyWeek();
            this.userSalesbyWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSalesbyWeekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastMonthlySalesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastMonthlySalesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOverAveragePriceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAboveAveragePriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfsalebyAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfSaleByAmountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeekBindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataTable
            // 
            this.UserDataTable.AllowUserToOrderColumns = true;
            this.UserDataTable.AutoGenerateColumns = false;
            this.UserDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserDataTable.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.UserTypeID,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.pinDataGridViewTextBoxColumn});
            this.UserDataTable.DataSource = this.usersBindingSource;
            this.UserDataTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserDataTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserDataTable.Location = new System.Drawing.Point(257, 110);
            this.UserDataTable.Margin = new System.Windows.Forms.Padding(4);
            this.UserDataTable.Name = "UserDataTable";
            this.UserDataTable.Size = new System.Drawing.Size(862, 398);
            this.UserDataTable.TabIndex = 2;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserTypeID
            // 
            this.UserTypeID.DataPropertyName = "UserTypeID";
            this.UserTypeID.HeaderText = "User Type";
            this.UserTypeID.Name = "UserTypeID";
            this.UserTypeID.Width = 97;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 99;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second Name";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.Width = 131;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 123;
            // 
            // pinDataGridViewTextBoxColumn
            // 
            this.pinDataGridViewTextBoxColumn.DataPropertyName = "Pin";
            this.pinDataGridViewTextBoxColumn.HeaderText = "Pin";
            this.pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            this.pinDataGridViewTextBoxColumn.Width = 55;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userData;
            // 
            // userData
            // 
            this.userData.DataSetName = "UserData";
            this.userData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(598, 516);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(220, 54);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(345, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Admin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(157, 393);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 46);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(154, 312);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(157, 218);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(157, 132);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 100);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serenity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(208, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 100);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 82);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.LogOutbtn);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.UserAdminbtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Reportsbtn);
            this.panel1.Controls.Add(this.StockBtn);
            this.panel1.Controls.Add(this.Bankingbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 608);
            this.panel1.TabIndex = 11;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.LogOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutbtn.Location = new System.Drawing.Point(40, 471);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(130, 50);
            this.LogOutbtn.TabIndex = 12;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click_1);
            // 
            // UserAdminbtn
            // 
            this.UserAdminbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.UserAdminbtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.UserAdminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAdminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdminbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserAdminbtn.Location = new System.Drawing.Point(3, 121);
            this.UserAdminbtn.Name = "UserAdminbtn";
            this.UserAdminbtn.Size = new System.Drawing.Size(191, 64);
            this.UserAdminbtn.TabIndex = 11;
            this.UserAdminbtn.Text = "User Admin";
            this.UserAdminbtn.UseVisualStyleBackColor = false;
            // 
            // Reportsbtn
            // 
            this.Reportsbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Reportsbtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Reportsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportsbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Reportsbtn.Location = new System.Drawing.Point(0, 377);
            this.Reportsbtn.Name = "Reportsbtn";
            this.Reportsbtn.Size = new System.Drawing.Size(205, 76);
            this.Reportsbtn.TabIndex = 4;
            this.Reportsbtn.Text = "Reports";
            this.Reportsbtn.UseVisualStyleBackColor = false;
            this.Reportsbtn.Click += new System.EventHandler(this.Reportsbtn_Click_1);
            // 
            // StockBtn
            // 
            this.StockBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.StockBtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.StockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockBtn.Location = new System.Drawing.Point(0, 202);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(208, 76);
            this.StockBtn.TabIndex = 2;
            this.StockBtn.Text = "Stock Control";
            this.StockBtn.UseVisualStyleBackColor = false;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click_1);
            // 
            // Bankingbtn
            // 
            this.Bankingbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Bankingbtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Bankingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bankingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bankingbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bankingbtn.Location = new System.Drawing.Point(3, 295);
            this.Bankingbtn.Name = "Bankingbtn";
            this.Bankingbtn.Size = new System.Drawing.Size(205, 76);
            this.Bankingbtn.TabIndex = 3;
            this.Bankingbtn.Text = "Banking ";
            this.Bankingbtn.UseVisualStyleBackColor = false;
            this.Bankingbtn.Click += new System.EventHandler(this.Bankingbtn_Click_1);
            // 
            // products_Above_Average_PriceTableAdapter
            // 
            this.products_Above_Average_PriceTableAdapter.ClearBeforeFill = true;
            // 
            // userSalesbyWeekTableAdapter
            // 
            this.userSalesbyWeekTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfSaleByAmountTableAdapter
            // 
            this.typeOfSaleByAmountTableAdapter.ClearBeforeFill = true;
            // 
            // lastMonthlySalesViewBindingSource
            // 
            this.lastMonthlySalesViewBindingSource.DataSource = this.lastMonthlySalesView;
            this.lastMonthlySalesViewBindingSource.Position = 0;
            // 
            // lastMonthlySalesView
            // 
            this.lastMonthlySalesView.DataSetName = "LastMonthlySalesView";
            this.lastMonthlySalesView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsOverAveragePriceView
            // 
            this.productsOverAveragePriceView.DataSetName = "ProductsOverAveragePriceView";
            this.productsOverAveragePriceView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsAboveAveragePriceBindingSource
            // 
            this.productsAboveAveragePriceBindingSource.DataMember = "Products Above Average Price";
            this.productsAboveAveragePriceBindingSource.DataSource = this.productsOverAveragePriceView;
            // 
            // typeOfsalebyAmount
            // 
            this.typeOfsalebyAmount.DataSetName = "TypeOfsalebyAmount";
            this.typeOfsalebyAmount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeOfSaleByAmountBindingSource
            // 
            this.typeOfSaleByAmountBindingSource.DataMember = "TypeOfSaleByAmount";
            this.typeOfSaleByAmountBindingSource.DataSource = this.typeOfsalebyAmount;
            // 
            // userSalesbyWeek
            // 
            this.userSalesbyWeek.DataSetName = "userSalesbyWeek";
            this.userSalesbyWeek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSalesbyWeekBindingSource
            // 
            this.userSalesbyWeekBindingSource.DataSource = this.userSalesbyWeek;
            this.userSalesbyWeekBindingSource.Position = 0;
            // 
            // userSalesbyWeekBindingSource1
            // 
            this.userSalesbyWeekBindingSource1.DataMember = "userSalesbyWeek";
            this.userSalesbyWeekBindingSource1.DataSource = this.userSalesbyWeekBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manager = 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "FOH Staff = 2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(1126, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 72);
            this.panel5.TabIndex = 15;
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1280, 608);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.UserDataTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAdmin";
            this.Text = "User Admin";
            this.Load += new System.EventHandler(this.UserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastMonthlySalesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastMonthlySalesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOverAveragePriceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsAboveAveragePriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfsalebyAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfSaleByAmountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesbyWeekBindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UserDataTable;
        private UserData userData;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UserDataTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button UserAdminbtn;
        private System.Windows.Forms.Button Reportsbtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button Bankingbtn;
        private ProductsOverAveragePriceViewTableAdapters.Products_Above_Average_PriceTableAdapter products_Above_Average_PriceTableAdapter;
        private userSalesbyWeekTableAdapters.userSalesbyWeekTableAdapter userSalesbyWeekTableAdapter;
        private TypeOfsalebyAmountTableAdapters.TypeOfSaleByAmountTableAdapter typeOfSaleByAmountTableAdapter;
        private System.Windows.Forms.BindingSource lastMonthlySalesViewBindingSource;
        private LastMonthlySalesView lastMonthlySalesView;
        private ProductsOverAveragePriceView productsOverAveragePriceView;
        private System.Windows.Forms.BindingSource productsAboveAveragePriceBindingSource;
        private TypeOfsalebyAmount typeOfsalebyAmount;
        private System.Windows.Forms.BindingSource typeOfSaleByAmountBindingSource;
        private userSalesbyWeek userSalesbyWeek;
        private System.Windows.Forms.BindingSource userSalesbyWeekBindingSource;
        private System.Windows.Forms.BindingSource userSalesbyWeekBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
    }
}