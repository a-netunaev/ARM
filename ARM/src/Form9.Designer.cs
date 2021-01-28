namespace АРМ_менеджера_отдела_кадров
{
    partial class Form9
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД_отдела_кадровDataSet = new АРМ_менеджера_отдела_кадров.BD();
            this.штатноеРасписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.штатное_расписаниеTableAdapter = new АРМ_менеджера_отдела_кадров.БД_отдела_кадровDataSetTableAdapters.Штатное_расписаниеTableAdapter();
            this.отделDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.штатныхединицDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.надбавкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить вакансию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить вакансию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть форму";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.отделDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.штатныхединицDataGridViewTextBoxColumn,
            this.ставкаDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn,
            this.надбавкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.штатноеРасписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(213, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // бД_отдела_кадровDataSet
            // 
            this.бД_отдела_кадровDataSet.DataSetName = "БД_отдела_кадровDataSet";
            this.бД_отдела_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // штатноеРасписаниеBindingSource
            // 
            this.штатноеРасписаниеBindingSource.DataMember = "Штатное расписание";
            this.штатноеРасписаниеBindingSource.DataSource = this.бД_отдела_кадровDataSet;
            // 
            // штатное_расписаниеTableAdapter
            // 
            this.штатное_расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // отделDataGridViewTextBoxColumn
            // 
            this.отделDataGridViewTextBoxColumn.DataPropertyName = "Отдел";
            this.отделDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.отделDataGridViewTextBoxColumn.Name = "отделDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // штатныхединицDataGridViewTextBoxColumn
            // 
            this.штатныхединицDataGridViewTextBoxColumn.DataPropertyName = "Штатных_единиц";
            this.штатныхединицDataGridViewTextBoxColumn.HeaderText = "Штатных_единиц";
            this.штатныхединицDataGridViewTextBoxColumn.Name = "штатныхединицDataGridViewTextBoxColumn";
            // 
            // ставкаDataGridViewTextBoxColumn
            // 
            this.ставкаDataGridViewTextBoxColumn.DataPropertyName = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.Name = "ставкаDataGridViewTextBoxColumn";
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            // 
            // надбавкаDataGridViewTextBoxColumn
            // 
            this.надбавкаDataGridViewTextBoxColumn.DataPropertyName = "Надбавка";
            this.надбавкаDataGridViewTextBoxColumn.HeaderText = "Надбавка";
            this.надбавкаDataGridViewTextBoxColumn.Name = "надбавкаDataGridViewTextBoxColumn";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 234);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.Text = "Штатное расписание";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.штатноеРасписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD бД_отдела_кадровDataSet;
        private System.Windows.Forms.BindingSource штатноеРасписаниеBindingSource;
        private БД_отдела_кадровDataSetTableAdapters.Штатное_расписаниеTableAdapter штатное_расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn штатныхединицDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкаDataGridViewTextBoxColumn;
    }
}