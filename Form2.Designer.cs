namespace raspisanie
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesssonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspisanieDataSet = new raspisanie.raspisanieDataSet();
            this.lessonsTableTableAdapter = new raspisanie.raspisanieDataSetTableAdapters.lessonsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.lesssonDataGridViewTextBoxColumn,
            this.classOnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "teacher";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // lesssonDataGridViewTextBoxColumn
            // 
            this.lesssonDataGridViewTextBoxColumn.DataPropertyName = "lessson";
            this.lesssonDataGridViewTextBoxColumn.HeaderText = "lessson";
            this.lesssonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lesssonDataGridViewTextBoxColumn.Name = "lesssonDataGridViewTextBoxColumn";
            this.lesssonDataGridViewTextBoxColumn.Width = 125;
            // 
            // classOnDataGridViewTextBoxColumn
            // 
            this.classOnDataGridViewTextBoxColumn.DataPropertyName = "classOn";
            this.classOnDataGridViewTextBoxColumn.HeaderText = "classOn";
            this.classOnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classOnDataGridViewTextBoxColumn.Name = "classOnDataGridViewTextBoxColumn";
            this.classOnDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonsTableBindingSource
            // 
            this.lessonsTableBindingSource.DataMember = "lessonsTable";
            this.lessonsTableBindingSource.DataSource = this.raspisanieDataSet;
            // 
            // raspisanieDataSet
            // 
            this.raspisanieDataSet.DataSetName = "raspisanieDataSet";
            this.raspisanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonsTableTableAdapter
            // 
            this.lessonsTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::raspisanie.Properties.Resources.школа_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspisanieDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private raspisanieDataSet raspisanieDataSet;
        private System.Windows.Forms.BindingSource lessonsTableBindingSource;
        private raspisanieDataSetTableAdapters.lessonsTableTableAdapter lessonsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesssonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classOnDataGridViewTextBoxColumn;
    }
}