namespace db_test
{
    partial class updateMenu2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_project_database_sqlDataSet = new db_test.db_project_database_sqlDataSet();
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter();
            this.tRIPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tRAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter();
            this.tRAINIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "update trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter updated seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Trip id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(961, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(961, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRIPIDDataGridViewTextBoxColumn,
            this.tRAINIDDataGridViewTextBoxColumn,
            this.aVAILABLESEATSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRIPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(680, 480);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 219);
            this.dataGridView1.TabIndex = 7;
            // 
            // db_project_database_sqlDataSet
            // 
            this.db_project_database_sqlDataSet.DataSetName = "db_project_database_sqlDataSet";
            this.db_project_database_sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRIPBindingSource
            // 
            this.tRIPBindingSource.DataMember = "TRIP";
            this.tRIPBindingSource.DataSource = this.db_project_database_sqlDataSet;
            // 
            // tRIPTableAdapter
            // 
            this.tRIPTableAdapter.ClearBeforeFill = true;
            // 
            // tRIPIDDataGridViewTextBoxColumn
            // 
            this.tRIPIDDataGridViewTextBoxColumn.DataPropertyName = "TRIP_ID";
            this.tRIPIDDataGridViewTextBoxColumn.HeaderText = "TRIP_ID";
            this.tRIPIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRIPIDDataGridViewTextBoxColumn.Name = "tRIPIDDataGridViewTextBoxColumn";
            this.tRIPIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tRAINIDDataGridViewTextBoxColumn
            // 
            this.tRAINIDDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.HeaderText = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRAINIDDataGridViewTextBoxColumn.Name = "tRAINIDDataGridViewTextBoxColumn";
            this.tRAINIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.aVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVAILABLESEATSDataGridViewTextBoxColumn.Name = "aVAILABLESEATSDataGridViewTextBoxColumn";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "update train";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "update train number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Enter train id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "update train arr time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "update train dep time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "update train name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(231, 376);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(231, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(231, 245);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 22);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(231, 168);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 22);
            this.textBox7.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRAINIDDataGridViewTextBoxColumn1,
            this.tRAINNUMBERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.dEPARTURETIMEDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tRAINBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 518);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(557, 181);
            this.dataGridView2.TabIndex = 19;
            // 
            // tRAINBindingSource
            // 
            this.tRAINBindingSource.DataMember = "TRAIN";
            this.tRAINBindingSource.DataSource = this.db_project_database_sqlDataSet;
            // 
            // tRAINTableAdapter
            // 
            this.tRAINTableAdapter.ClearBeforeFill = true;
            // 
            // tRAINIDDataGridViewTextBoxColumn1
            // 
            this.tRAINIDDataGridViewTextBoxColumn1.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn1.HeaderText = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tRAINIDDataGridViewTextBoxColumn1.Name = "tRAINIDDataGridViewTextBoxColumn1";
            this.tRAINIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tRAINNUMBERDataGridViewTextBoxColumn
            // 
            this.tRAINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "TRAINNUMBER";
            this.tRAINNUMBERDataGridViewTextBoxColumn.HeaderText = "TRAINNUMBER";
            this.tRAINNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRAINNUMBERDataGridViewTextBoxColumn.Name = "tRAINNUMBERDataGridViewTextBoxColumn";
            this.tRAINNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPARTURETIMEDataGridViewTextBoxColumn
            // 
            this.dEPARTURETIMEDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_TIME";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_TIME";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPARTURETIMEDataGridViewTextBoxColumn.Name = "dEPARTURETIMEDataGridViewTextBoxColumn";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 26);
            this.button4.TabIndex = 21;
            this.button4.Text = "update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // updateMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 737);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updateMenu2";
            this.Text = "updateMenu2";
            this.Load += new System.EventHandler(this.updateMenu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_project_database_sqlDataSet db_project_database_sqlDataSet;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter tRIPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLESEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tRAINBindingSource;
        private db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter tRAINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}