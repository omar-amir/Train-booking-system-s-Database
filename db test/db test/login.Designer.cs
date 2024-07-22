namespace db_test
{
    partial class login
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
            this.userloginbutton = new System.Windows.Forms.Button();
            this.adminloginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterusernamelogintextBox1 = new System.Windows.Forms.TextBox();
            this.enterpasswordlogintextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userloginbutton
            // 
            this.userloginbutton.Location = new System.Drawing.Point(178, 292);
            this.userloginbutton.Name = "userloginbutton";
            this.userloginbutton.Size = new System.Drawing.Size(135, 34);
            this.userloginbutton.TabIndex = 0;
            this.userloginbutton.Text = "user log in";
            this.userloginbutton.UseVisualStyleBackColor = true;
            this.userloginbutton.Click += new System.EventHandler(this.userloginbutton_Click);
            // 
            // adminloginbutton
            // 
            this.adminloginbutton.Location = new System.Drawing.Point(436, 292);
            this.adminloginbutton.Name = "adminloginbutton";
            this.adminloginbutton.Size = new System.Drawing.Size(135, 34);
            this.adminloginbutton.TabIndex = 1;
            this.adminloginbutton.Text = "admin log in";
            this.adminloginbutton.UseVisualStyleBackColor = true;
            this.adminloginbutton.Click += new System.EventHandler(this.adminloginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter password";
            // 
            // enterusernamelogintextBox1
            // 
            this.enterusernamelogintextBox1.Location = new System.Drawing.Point(450, 92);
            this.enterusernamelogintextBox1.Name = "enterusernamelogintextBox1";
            this.enterusernamelogintextBox1.Size = new System.Drawing.Size(147, 22);
            this.enterusernamelogintextBox1.TabIndex = 4;
            // 
            // enterpasswordlogintextbox
            // 
            this.enterpasswordlogintextbox.Location = new System.Drawing.Point(436, 172);
            this.enterpasswordlogintextbox.Name = "enterpasswordlogintextbox";
            this.enterpasswordlogintextbox.Size = new System.Drawing.Size(147, 22);
            this.enterpasswordlogintextbox.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterpasswordlogintextbox);
            this.Controls.Add(this.enterusernamelogintextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminloginbutton);
            this.Controls.Add(this.userloginbutton);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userloginbutton;
        private System.Windows.Forms.Button adminloginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterusernamelogintextBox1;
        private System.Windows.Forms.TextBox enterpasswordlogintextbox;
    }
}