namespace ManagementApplication
{
    partial class ManagementLogInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementLogInWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PinEnterTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterPwordbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serenity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(483, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Managment Tool";
            // 
            // PinEnterTb
            // 
            this.PinEnterTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinEnterTb.Location = new System.Drawing.Point(442, 262);
            this.PinEnterTb.Name = "PinEnterTb";
            this.PinEnterTb.PasswordChar = '*';
            this.PinEnterTb.Size = new System.Drawing.Size(287, 40);
            this.PinEnterTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(264, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Enter your Personal Identification Number Below:";
            // 
            // EnterPwordbtn
            // 
            this.EnterPwordbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterPwordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPwordbtn.Location = new System.Drawing.Point(713, 338);
            this.EnterPwordbtn.Name = "EnterPwordbtn";
            this.EnterPwordbtn.Size = new System.Drawing.Size(131, 45);
            this.EnterPwordbtn.TabIndex = 4;
            this.EnterPwordbtn.Text = "Enter";
            this.EnterPwordbtn.UseVisualStyleBackColor = false;
            this.EnterPwordbtn.Click += new System.EventHandler(this.EnterPwordbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(321, 338);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(131, 45);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // ManagementLogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1169, 486);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.EnterPwordbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PinEnterTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementLogInWindow";
            this.Text = "ManagementLogInWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PinEnterTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EnterPwordbtn;
        private System.Windows.Forms.Button Cancelbtn;
    }
}