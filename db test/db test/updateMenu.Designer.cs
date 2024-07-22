namespace db_test
{
    partial class updateMenu
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
            this.db_project_database_sqlDataSet = new db_test.db_project_database_sqlDataSet();
            this.tRAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter();
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tRIPTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.tripInsert = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trainInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tRIPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tRAINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // db_project_database_sqlDataSet
            // 
            this.db_project_database_sqlDataSet.DataSetName = "db_project_database_sqlDataSet";
            this.db_project_database_sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tRIPBindingSource
            // 
            this.tRIPBindingSource.DataMember = "TRIP";
            this.tRIPBindingSource.DataSource = this.db_project_database_sqlDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "show data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tRIPTableAdapter
            // 
            this.tRIPTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1013, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "show data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tripInsert
            // 
            this.tripInsert.Location = new System.Drawing.Point(851, 353);
            this.tripInsert.Name = "tripInsert";
            this.tripInsert.Size = new System.Drawing.Size(75, 23);
            this.tripInsert.TabIndex = 41;
            this.tripInsert.Text = "update";
            this.tripInsert.UseVisualStyleBackColor = true;
            this.tripInsert.Click += new System.EventHandler(this.tripInsert_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(976, 192);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 22);
            this.textBox8.TabIndex = 40;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(996, 288);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 22);
            this.textBox6.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(848, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "insert trip id";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(814, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "update available seats";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(263, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 22);
            this.textBox5.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(263, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(263, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 32;
            // 
            // trainInsert
            // 
            this.trainInsert.Location = new System.Drawing.Point(249, 353);
            this.trainInsert.Name = "trainInsert";
            this.trainInsert.Size = new System.Drawing.Size(75, 23);
            this.trainInsert.TabIndex = 31;
            this.trainInsert.Text = "insert";
            this.trainInsert.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "insert train id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "insert train number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "insert train name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "insert dep time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "insert arrival time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "update a trip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "insert new train";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRIPIDDataGridViewTextBoxColumn,
            this.tRAINIDDataGridViewTextBoxColumn,
            this.aVAILABLESEATSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRIPBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(797, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 207);
            this.dataGridView1.TabIndex = 46;
            // 
            // tRIPBindingSource1
            // 
            this.tRIPBindingSource1.DataMember = "TRIP";
            this.tRIPBindingSource1.DataSource = this.db_project_database_sqlDataSet;
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
            this.dataGridView2.DataSource = this.tRAINBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(136, 403);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(472, 244);
            this.dataGridView2.TabIndex = 47;
            // 
            // tRAINBindingSource1
            // 
            this.tRAINBindingSource1.DataMember = "TRAIN";
            this.tRAINBindingSource1.DataSource = this.db_project_database_sqlDataSet;
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
            // updateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 751);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tripInsert);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trainInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updateMenu";
            this.Text = "updateMenu";
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_project_database_sqlDataSet db_project_database_sqlDataSet;
        private System.Windows.Forms.BindingSource tRAINBindingSource;
        private db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter tRAINTableAdapter;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private System.Windows.Forms.Button button1;
        private db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter tRIPTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tripInsert;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button trainInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLESEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tRIPBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tRAINBindingSource1;
    }
}