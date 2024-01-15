namespace simple__forgot_password
{
    partial class Form3
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
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfimpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change your password !";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpassword.Location = new System.Drawing.Point(261, 195);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(376, 27);
            this.txtNewpassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConfimpassword
            // 
            this.txtConfimpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfimpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfimpassword.Location = new System.Drawing.Point(261, 250);
            this.txtConfimpassword.Name = "txtConfimpassword";
            this.txtConfimpassword.Size = new System.Drawing.Size(376, 27);
            this.txtConfimpassword.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password :";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Red;
            this.btnChange.Location = new System.Drawing.Point(545, 321);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(92, 36);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtConfimpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfimpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChange;
    }
}