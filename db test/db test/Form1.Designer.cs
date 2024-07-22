namespace db_test
{
    partial class Form1
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
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_project_database_sqlDataSet = new db_test.db_project_database_sqlDataSet();
            this.uSERTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.USERTableAdapter();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.alreadyloginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.mailtextbox = new System.Windows.Forms.TextBox();
            this.roletextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.db_project_database_sqlDataSet;
            // 
            // db_project_database_sqlDataSet
            // 
            this.db_project_database_sqlDataSet.DataSetName = "db_project_database_sqlDataSet";
            this.db_project_database_sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(554, 390);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(152, 48);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // alreadyloginbutton
            // 
            this.alreadyloginbutton.Location = new System.Drawing.Point(148, 431);
            this.alreadyloginbutton.Name = "alreadyloginbutton";
            this.alreadyloginbutton.Size = new System.Drawing.Size(152, 48);
            this.alreadyloginbutton.TabIndex = 1;
            this.alreadyloginbutton.Text = "log in";
            this.alreadyloginbutton.UseVisualStyleBackColor = true;
            this.alreadyloginbutton.Click += new System.EventHandler(this.alreadyloginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter role";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(456, 102);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(150, 22);
            this.usernametextBox.TabIndex = 6;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(466, 182);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(139, 22);
            this.passwordtextBox.TabIndex = 7;
            // 
            // mailtextbox
            // 
            this.mailtextbox.Location = new System.Drawing.Point(466, 242);
            this.mailtextbox.Name = "mailtextbox";
            this.mailtextbox.Size = new System.Drawing.Size(140, 22);
            this.mailtextbox.TabIndex = 8;
            // 
            // roletextbox
            // 
            this.roletextbox.Location = new System.Drawing.Point(466, 299);
            this.roletextbox.Name = "roletextbox";
            this.roletextbox.Size = new System.Drawing.Size(139, 22);
            this.roletextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "log in if you have an account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 536);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roletextbox);
            this.Controls.Add(this.mailtextbox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alreadyloginbutton);
            this.Controls.Add(this.RegisterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_project_database_sqlDataSet db_project_database_sqlDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private db_project_database_sqlDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button alreadyloginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox mailtextbox;
        private System.Windows.Forms.TextBox roletextbox;
        private System.Windows.Forms.Label label5;
    }
}

