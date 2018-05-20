namespace FrontOfHouseSystem
{
    partial class PaymentSucessfulwindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeAmountlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountLbl = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.Completebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Successful";
            // 
            // ChangeAmountlbl
            // 
            this.ChangeAmountlbl.AutoSize = true;
            this.ChangeAmountlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAmountlbl.Location = new System.Drawing.Point(418, 232);
            this.ChangeAmountlbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ChangeAmountlbl.Name = "ChangeAmountlbl";
            this.ChangeAmountlbl.Size = new System.Drawing.Size(119, 43);
            this.ChangeAmountlbl.TabIndex = 1;
            this.ChangeAmountlbl.Text = "£2.50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // TotalAmountLbl
            // 
            this.TotalAmountLbl.AutoSize = true;
            this.TotalAmountLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLbl.Location = new System.Drawing.Point(418, 165);
            this.TotalAmountLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TotalAmountLbl.Name = "TotalAmountLbl";
            this.TotalAmountLbl.Size = new System.Drawing.Size(119, 43);
            this.TotalAmountLbl.TabIndex = 4;
            this.TotalAmountLbl.Text = "£7.50";
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 28;
            this.OrderList.Location = new System.Drawing.Point(661, 336);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(120, 88);
            this.OrderList.TabIndex = 5;
            this.OrderList.Visible = false;
            // 
            // Completebtn
            // 
            this.Completebtn.BackColor = System.Drawing.Color.White;
            this.Completebtn.ForeColor = System.Drawing.Color.Black;
            this.Completebtn.Location = new System.Drawing.Point(279, 293);
            this.Completebtn.Name = "Completebtn";
            this.Completebtn.Size = new System.Drawing.Size(205, 51);
            this.Completebtn.TabIndex = 7;
            this.Completebtn.Text = "Finish";
            this.Completebtn.UseVisualStyleBackColor = false;
            this.Completebtn.Click += new System.EventHandler(this.Completebtn_Click_1);
            // 
            // PaymentSucessfulwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(779, 399);
            this.Controls.Add(this.Completebtn);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.TotalAmountLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeAmountlbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PaymentSucessfulwindow";
            this.Text = "PaymentSucessfulwindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChangeAmountlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalAmountLbl;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button Completebtn;
    }
}