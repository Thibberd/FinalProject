namespace FrontOfHouseSystem
{
    partial class EFTpaymentWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.Completebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processing card Payment... ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enusre user has entered card / is present";
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.Location = new System.Drawing.Point(610, 317);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(120, 95);
            this.OrderList.TabIndex = 2;
            this.OrderList.Visible = false;
            // 
            // Completebtn
            // 
            this.Completebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Completebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completebtn.Location = new System.Drawing.Point(240, 275);
            this.Completebtn.Name = "Completebtn";
            this.Completebtn.Size = new System.Drawing.Size(214, 75);
            this.Completebtn.TabIndex = 3;
            this.Completebtn.Text = "Complete Transaction";
            this.Completebtn.UseVisualStyleBackColor = false;
            this.Completebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EFTpaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(697, 376);
            this.Controls.Add(this.Completebtn);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EFTpaymentWindow";
            this.Text = "EFTpaymentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button Completebtn;
    }
}