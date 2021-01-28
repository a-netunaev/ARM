namespace АРМ_менеджера_отдела_кадров
{
    partial class Form13
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
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типотпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертрудовогодоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.днейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасоставленияприказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иНДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиедолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приказНаОтпускBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_отдела_кадровDataSet = new АРМ_менеджера_отдела_кадров.BD();
            this.приказ_на_отпускTableAdapter = new АРМ_менеджера_отдела_кадров.БД_отдела_кадровDataSetTableAdapters.Приказ_на_отпускTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приказНаОтпускBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавление приказа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменение приказа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 43);
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
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.табельныйномерDataGridViewTextBoxColumn,
            this.типотпускаDataGridViewTextBoxColumn,
            this.номертрудовогодоговораDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаокончанияDataGridViewTextBoxColumn,
            this.днейDataGridViewTextBoxColumn,
            this.основаниеDataGridViewTextBoxColumn,
            this.датасоставленияприказаDataGridViewTextBoxColumn,
            this.иНДолжностиDataGridViewTextBoxColumn,
            this.наименованиедолжностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.приказНаОтпускBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(237, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // табельныйномерDataGridViewTextBoxColumn
            // 
            this.табельныйномерDataGridViewTextBoxColumn.DataPropertyName = "Табельный_номер";
            this.табельныйномерDataGridViewTextBoxColumn.HeaderText = "Табельный_номер";
            this.табельныйномерDataGridViewTextBoxColumn.Name = "табельныйномерDataGridViewTextBoxColumn";
            // 
            // типотпускаDataGridViewTextBoxColumn
            // 
            this.типотпускаDataGridViewTextBoxColumn.DataPropertyName = "Тип_отпуска";
            this.типотпускаDataGridViewTextBoxColumn.HeaderText = "Тип_отпуска";
            this.типотпускаDataGridViewTextBoxColumn.Name = "типотпускаDataGridViewTextBoxColumn";
            // 
            // номертрудовогодоговораDataGridViewTextBoxColumn
            // 
            this.номертрудовогодоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер_трудового_договора";
            this.номертрудовогодоговораDataGridViewTextBoxColumn.HeaderText = "Номер_трудового_договора";
            this.номертрудовогодоговораDataGridViewTextBoxColumn.Name = "номертрудовогодоговораDataGridViewTextBoxColumn";
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            // 
            // датаокончанияDataGridViewTextBoxColumn
            // 
            this.датаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.Name = "датаокончанияDataGridViewTextBoxColumn";
            // 
            // днейDataGridViewTextBoxColumn
            // 
            this.днейDataGridViewTextBoxColumn.DataPropertyName = "Дней";
            this.днейDataGridViewTextBoxColumn.HeaderText = "Дней";
            this.днейDataGridViewTextBoxColumn.Name = "днейDataGridViewTextBoxColumn";
            // 
            // основаниеDataGridViewTextBoxColumn
            // 
            this.основаниеDataGridViewTextBoxColumn.DataPropertyName = "Основание";
            this.основаниеDataGridViewTextBoxColumn.HeaderText = "Основание";
            this.основаниеDataGridViewTextBoxColumn.Name = "основаниеDataGridViewTextBoxColumn";
            // 
            // датасоставленияприказаDataGridViewTextBoxColumn
            // 
            this.датасоставленияприказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_составления_приказа";
            this.датасоставленияприказаDataGridViewTextBoxColumn.HeaderText = "Дата_составления_приказа";
            this.датасоставленияприказаDataGridViewTextBoxColumn.Name = "датасоставленияприказаDataGridViewTextBoxColumn";
            // 
            // иНДолжностиDataGridViewTextBoxColumn
            // 
            this.иНДолжностиDataGridViewTextBoxColumn.DataPropertyName = "ИН_Должности";
            this.иНДолжностиDataGridViewTextBoxColumn.HeaderText = "ИН_Должности";
            this.иНДолжностиDataGridViewTextBoxColumn.Name = "иНДолжностиDataGridViewTextBoxColumn";
            // 
            // наименованиедолжностиDataGridViewTextBoxColumn
            // 
            this.наименованиедолжностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_должности";
            this.наименованиедолжностиDataGridViewTextBoxColumn.HeaderText = "Наименование_должности";
            this.наименованиедолжностиDataGridViewTextBoxColumn.Name = "наименованиедолжностиDataGridViewTextBoxColumn";
            // 
            // приказНаОтпускBindingSource
            // 
            this.приказНаОтпускBindingSource.DataMember = "Приказ на отпуск";
            this.приказНаОтпускBindingSource.DataSource = this.бД_отдела_кадровDataSet;
            // 
            // бД_отдела_кадровDataSet
            // 
            this.бД_отдела_кадровDataSet.DataSetName = "БД_отдела_кадровDataSet";
            this.бД_отдела_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приказ_на_отпускTableAdapter
            // 
            this.приказ_на_отпускTableAdapter.ClearBeforeFill = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 226);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form13";
            this.Text = "Приказ на отпуск";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приказНаОтпускBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD бД_отдела_кадровDataSet;
        private System.Windows.Forms.BindingSource приказНаОтпускBindingSource;
        private БД_отдела_кадровDataSetTableAdapters.Приказ_на_отпускTableAdapter приказ_на_отпускTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типотпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертрудовогодоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn днейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn основаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасоставленияприказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иНДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиедолжностиDataGridViewTextBoxColumn;
    }
}