namespace db_test
{
    partial class deleteMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_project_database_sqlDataSet = new db_test.db_project_database_sqlDataSet();
            this.tRAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter();
            this.tRAINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPTableAdapter = new db_test.db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter();
            this.tRIPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "delete a train";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter train id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter trip id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "delete a trip";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(861, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(926, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(323, 322);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 11;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRAINIDDataGridViewTextBoxColumn,
            this.tRAINNUMBERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.dEPARTURETIMEDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tRAINBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 156);
            this.dataGridView1.TabIndex = 12;
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
            // tRAINIDDataGridViewTextBoxColumn
            // 
            this.tRAINIDDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.HeaderText = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRAINIDDataGridViewTextBoxColumn.Name = "tRAINIDDataGridViewTextBoxColumn";
            this.tRAINIDDataGridViewTextBoxColumn.Width = 125;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRIPIDDataGridViewTextBoxColumn,
            this.tRAINIDDataGridViewTextBoxColumn1,
            this.aVAILABLESEATSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tRIPBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(679, 382);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(443, 151);
            this.dataGridView2.TabIndex = 13;
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
            // tRAINIDDataGridViewTextBoxColumn1
            // 
            this.tRAINIDDataGridViewTextBoxColumn1.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn1.HeaderText = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tRAINIDDataGridViewTextBoxColumn1.Name = "tRAINIDDataGridViewTextBoxColumn1";
            this.tRAINIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.aVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVAILABLESEATSDataGridViewTextBoxColumn.Name = "aVAILABLESEATSDataGridViewTextBoxColumn";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.Width = 125;
            // 
            // deleteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 576);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "deleteMenu";
            this.Text = "deleteMenu";
            this.Load += new System.EventHandler(this.deleteMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_project_database_sqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_project_database_sqlDataSet db_project_database_sqlDataSet;
        private System.Windows.Forms.BindingSource tRAINBindingSource;
        private db_project_database_sqlDataSetTableAdapters.TRAINTableAdapter tRAINTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private db_project_database_sqlDataSetTableAdapters.TRIPTableAdapter tRIPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRIPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLESEATSDataGridViewTextBoxColumn;
    }
}