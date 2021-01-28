namespace АРМ_менеджера_отдела_кадров
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД_отдела_кадровDataSet = new АРМ_менеджера_отдела_кадров.BD();
            this.информацияОСотрудникахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_сотрудникахTableAdapter = new АРМ_менеджера_отдела_кадров.БД_отдела_кадровDataSetTableAdapters.Информация_о_сотрудникахTableAdapter();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видобразованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеотделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типдокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семейноеположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.табельныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертрудовогодоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сериядокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номердокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кемвыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпенсионногосвидетельстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полисОМСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресместарегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индекспоместурегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресфактическогопроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индекспоместуфактическогопроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотовыйтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотографияDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Изменить информацию о сотрудниках";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Закрыть форму";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Посмотреть отчеты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить информацию о сотрудниках";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.видобразованияDataGridViewTextBoxColumn,
            this.названиеотделаDataGridViewTextBoxColumn,
            this.типдокументаDataGridViewTextBoxColumn,
            this.семейноеположениеDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.табельныйномерDataGridViewTextBoxColumn,
            this.номертрудовогодоговораDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.сериядокументаDataGridViewTextBoxColumn,
            this.номердокументаDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.кемвыданDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.номерпенсионногосвидетельстваDataGridViewTextBoxColumn,
            this.полисОМСDataGridViewTextBoxColumn,
            this.адресместарегистрацииDataGridViewTextBoxColumn,
            this.индекспоместурегистрацииDataGridViewTextBoxColumn,
            this.адресфактическогопроживанияDataGridViewTextBoxColumn,
            this.индекспоместуфактическогопроживанияDataGridViewTextBoxColumn,
            this.домашнийтелефонDataGridViewTextBoxColumn,
            this.сотовыйтелефонDataGridViewTextBoxColumn,
            this.фотографияDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.информацияОСотрудникахBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(257, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // бД_отдела_кадровDataSet
            // 
            this.бД_отдела_кадровDataSet.DataSetName = "БД_отдела_кадровDataSet";
            this.бД_отдела_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информацияОСотрудникахBindingSource
            // 
            this.информацияОСотрудникахBindingSource.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource.DataSource = this.бД_отдела_кадровDataSet;
            // 
            // информация_о_сотрудникахTableAdapter
            // 
            this.информация_о_сотрудникахTableAdapter.ClearBeforeFill = true;
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
            // видобразованияDataGridViewTextBoxColumn
            // 
            this.видобразованияDataGridViewTextBoxColumn.DataPropertyName = "Вид_образования";
            this.видобразованияDataGridViewTextBoxColumn.HeaderText = "Вид_образования";
            this.видобразованияDataGridViewTextBoxColumn.Name = "видобразованияDataGridViewTextBoxColumn";
            // 
            // названиеотделаDataGridViewTextBoxColumn
            // 
            this.названиеотделаDataGridViewTextBoxColumn.DataPropertyName = "Название_отдела";
            this.названиеотделаDataGridViewTextBoxColumn.HeaderText = "Название_отдела";
            this.названиеотделаDataGridViewTextBoxColumn.Name = "названиеотделаDataGridViewTextBoxColumn";
            // 
            // типдокументаDataGridViewTextBoxColumn
            // 
            this.типдокументаDataGridViewTextBoxColumn.DataPropertyName = "Тип_документа";
            this.типдокументаDataGridViewTextBoxColumn.HeaderText = "Тип_документа";
            this.типдокументаDataGridViewTextBoxColumn.Name = "типдокументаDataGridViewTextBoxColumn";
            // 
            // семейноеположениеDataGridViewTextBoxColumn
            // 
            this.семейноеположениеDataGridViewTextBoxColumn.DataPropertyName = "Семейное_положение";
            this.семейноеположениеDataGridViewTextBoxColumn.HeaderText = "Семейное_положение";
            this.семейноеположениеDataGridViewTextBoxColumn.Name = "семейноеположениеDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // табельныйномерDataGridViewTextBoxColumn
            // 
            this.табельныйномерDataGridViewTextBoxColumn.DataPropertyName = "Табельный_номер";
            this.табельныйномерDataGridViewTextBoxColumn.HeaderText = "Табельный_номер";
            this.табельныйномерDataGridViewTextBoxColumn.Name = "табельныйномерDataGridViewTextBoxColumn";
            // 
            // номертрудовогодоговораDataGridViewTextBoxColumn
            // 
            this.номертрудовогодоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер_трудового_договора";
            this.номертрудовогодоговораDataGridViewTextBoxColumn.HeaderText = "Номер_трудового_договора";
            this.номертрудовогодоговораDataGridViewTextBoxColumn.Name = "номертрудовогодоговораDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "Область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "Область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // сериядокументаDataGridViewTextBoxColumn
            // 
            this.сериядокументаDataGridViewTextBoxColumn.DataPropertyName = "Серия_документа";
            this.сериядокументаDataGridViewTextBoxColumn.HeaderText = "Серия_документа";
            this.сериядокументаDataGridViewTextBoxColumn.Name = "сериядокументаDataGridViewTextBoxColumn";
            // 
            // номердокументаDataGridViewTextBoxColumn
            // 
            this.номердокументаDataGridViewTextBoxColumn.DataPropertyName = "Номер_документа";
            this.номердокументаDataGridViewTextBoxColumn.HeaderText = "Номер_документа";
            this.номердокументаDataGridViewTextBoxColumn.Name = "номердокументаDataGridViewTextBoxColumn";
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            // 
            // кемвыданDataGridViewTextBoxColumn
            // 
            this.кемвыданDataGridViewTextBoxColumn.DataPropertyName = "Кем_выдан";
            this.кемвыданDataGridViewTextBoxColumn.HeaderText = "Кем_выдан";
            this.кемвыданDataGridViewTextBoxColumn.Name = "кемвыданDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // номерпенсионногосвидетельстваDataGridViewTextBoxColumn
            // 
            this.номерпенсионногосвидетельстваDataGridViewTextBoxColumn.DataPropertyName = "Номер_пенсионного_свидетельства";
            this.номерпенсионногосвидетельстваDataGridViewTextBoxColumn.HeaderText = "Номер_пенсионного_свидетельства";
            this.номерпенсионногосвидетельстваDataGridViewTextBoxColumn.Name = "номерпенсионногосвидетельстваDataGridViewTextBoxColumn";
            // 
            // полисОМСDataGridViewTextBoxColumn
            // 
            this.полисОМСDataGridViewTextBoxColumn.DataPropertyName = "Полис_ОМС";
            this.полисОМСDataGridViewTextBoxColumn.HeaderText = "Полис_ОМС";
            this.полисОМСDataGridViewTextBoxColumn.Name = "полисОМСDataGridViewTextBoxColumn";
            // 
            // адресместарегистрацииDataGridViewTextBoxColumn
            // 
            this.адресместарегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Адрес_места_регистрации";
            this.адресместарегистрацииDataGridViewTextBoxColumn.HeaderText = "Адрес_места_регистрации";
            this.адресместарегистрацииDataGridViewTextBoxColumn.Name = "адресместарегистрацииDataGridViewTextBoxColumn";
            // 
            // индекспоместурегистрацииDataGridViewTextBoxColumn
            // 
            this.индекспоместурегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Индекс_по_месту_регистрации";
            this.индекспоместурегистрацииDataGridViewTextBoxColumn.HeaderText = "Индекс_по_месту_регистрации";
            this.индекспоместурегистрацииDataGridViewTextBoxColumn.Name = "индекспоместурегистрацииDataGridViewTextBoxColumn";
            // 
            // адресфактическогопроживанияDataGridViewTextBoxColumn
            // 
            this.адресфактическогопроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес_фактического_проживания";
            this.адресфактическогопроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес_фактического_проживания";
            this.адресфактическогопроживанияDataGridViewTextBoxColumn.Name = "адресфактическогопроживанияDataGridViewTextBoxColumn";
            // 
            // индекспоместуфактическогопроживанияDataGridViewTextBoxColumn
            // 
            this.индекспоместуфактическогопроживанияDataGridViewTextBoxColumn.DataPropertyName = "Индекс_по_месту_фактического_проживания";
            this.индекспоместуфактическогопроживанияDataGridViewTextBoxColumn.HeaderText = "Индекс_по_месту_фактического_проживания";
            this.индекспоместуфактическогопроживанияDataGridViewTextBoxColumn.Name = "индекспоместуфактическогопроживанияDataGridViewTextBoxColumn";
            // 
            // домашнийтелефонDataGridViewTextBoxColumn
            // 
            this.домашнийтелефонDataGridViewTextBoxColumn.DataPropertyName = "Домашний_телефон";
            this.домашнийтелефонDataGridViewTextBoxColumn.HeaderText = "Домашний_телефон";
            this.домашнийтелефонDataGridViewTextBoxColumn.Name = "домашнийтелефонDataGridViewTextBoxColumn";
            // 
            // сотовыйтелефонDataGridViewTextBoxColumn
            // 
            this.сотовыйтелефонDataGridViewTextBoxColumn.DataPropertyName = "Сотовый_телефон";
            this.сотовыйтелефонDataGridViewTextBoxColumn.HeaderText = "Сотовый_телефон";
            this.сотовыйтелефонDataGridViewTextBoxColumn.Name = "сотовыйтелефонDataGridViewTextBoxColumn";
            // 
            // фотографияDataGridViewImageColumn
            // 
            this.фотографияDataGridViewImageColumn.DataPropertyName = "Фотография";
            this.фотографияDataGridViewImageColumn.HeaderText = "Фотография";
            this.фотографияDataGridViewImageColumn.Name = "фотографияDataGridViewImageColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_отдела_кадровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD бД_отдела_кадровDataSet;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource;
        private БД_отдела_кадровDataSetTableAdapters.Информация_о_сотрудникахTableAdapter информация_о_сотрудникахTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видобразованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеотделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типдокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семейноеположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертрудовогодоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сериядокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номердокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кемвыданDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпенсионногосвидетельстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полисОМСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресместарегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индекспоместурегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресфактическогопроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индекспоместуфактическогопроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийтелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотовыйтелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотографияDataGridViewImageColumn;
    }
}