namespace db_test
{
    partial class userMenu
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
            this.updatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oldpasswordbutton = new System.Windows.Forms.TextBox();
            this.newmailbutton = new System.Windows.Forms.TextBox();
            this.newpasswordbutton = new System.Windows.Forms.TextBox();
            this.newusernamebutton = new System.Windows.Forms.TextBox();
            this.oldusernamebutton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(300, 311);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(188, 49);
            this.updatebutton.TabIndex = 0;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Old username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter old password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter new username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter new mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter new password";
            // 
            // oldpasswordbutton
            // 
            this.oldpasswordbutton.Location = new System.Drawing.Point(317, 99);
            this.oldpasswordbutton.Name = "oldpasswordbutton";
            this.oldpasswordbutton.Size = new System.Drawing.Size(189, 22);
            this.oldpasswordbutton.TabIndex = 6;
            this.oldpasswordbutton.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newmailbutton
            // 
            this.newmailbutton.Location = new System.Drawing.Point(317, 265);
            this.newmailbutton.Name = "newmailbutton";
            this.newmailbutton.Size = new System.Drawing.Size(189, 22);
            this.newmailbutton.TabIndex = 7;
            this.newmailbutton.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newpasswordbutton
            // 
            this.newpasswordbutton.Location = new System.Drawing.Point(317, 205);
            this.newpasswordbutton.Name = "newpasswordbutton";
            this.newpasswordbutton.Size = new System.Drawing.Size(189, 22);
            this.newpasswordbutton.TabIndex = 8;
            // 
            // newusernamebutton
            // 
            this.newusernamebutton.Location = new System.Drawing.Point(317, 149);
            this.newusernamebutton.Name = "newusernamebutton";
            this.newusernamebutton.Size = new System.Drawing.Size(189, 22);
            this.newusernamebutton.TabIndex = 9;
            // 
            // oldusernamebutton
            // 
            this.oldusernamebutton.Location = new System.Drawing.Point(317, 54);
            this.oldusernamebutton.Name = "oldusernamebutton";
            this.oldusernamebutton.Size = new System.Drawing.Size(189, 22);
            this.oldusernamebutton.TabIndex = 10;
            // 
            // userMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oldusernamebutton);
            this.Controls.Add(this.newusernamebutton);
            this.Controls.Add(this.newpasswordbutton);
            this.Controls.Add(this.newmailbutton);
            this.Controls.Add(this.oldpasswordbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebutton);
            this.Name = "userMenu";
            this.Text = "userMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldpasswordbutton;
        private System.Windows.Forms.TextBox newmailbutton;
        private System.Windows.Forms.TextBox newpasswordbutton;
        private System.Windows.Forms.TextBox newusernamebutton;
        private System.Windows.Forms.TextBox oldusernamebutton;
    }
}