namespace АРМ_менеджера_отдела_кадров
{
    partial class Form8
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Информация_о_сотрудникахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.БД_отдела_кадровDataSet = new АРМ_менеджера_отдела_кадров.BD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Информация_о_сотрудникахTableAdapter = new АРМ_менеджера_отдела_кадров.БД_отдела_кадровDataSetTableAdapters.Информация_о_сотрудникахTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Информация_о_сотрудникахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.БД_отдела_кадровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Информация_о_сотрудникахBindingSource
            // 
            this.Информация_о_сотрудникахBindingSource.DataMember = "Информация о сотрудниках";
            this.Информация_о_сотрудникахBindingSource.DataSource = this.БД_отдела_кадровDataSet;
            // 
            // БД_отдела_кадровDataSet
            // 
            this.БД_отдела_кадровDataSet.DataSetName = "БД_отдела_кадровDataSet";
            this.БД_отдела_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Информация_о_сотрудникахBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_менеджера_отдела_кадров.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(607, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // Информация_о_сотрудникахTableAdapter
            // 
            this.Информация_о_сотрудникахTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form8";
            this.Text = "Перечень сотрудников";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Информация_о_сотрудникахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.БД_отдела_кадровDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Информация_о_сотрудникахBindingSource;
        private BD БД_отдела_кадровDataSet;
        private БД_отдела_кадровDataSetTableAdapters.Информация_о_сотрудникахTableAdapter Информация_о_сотрудникахTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}