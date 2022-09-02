namespace BancoTransacc.presentacion
{
    partial class frmClienteGral
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
            this.clientegralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet2 = new BancoTransacc.bancoDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientegralTableAdapter = new BancoTransacc.bancoDataSet2TableAdapters.ClientegralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientegralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientegralBindingSource
            // 
            this.clientegralBindingSource.DataMember = "Clientegral";
            this.clientegralBindingSource.DataSource = this.bancoDataSet2;
            // 
            // bancoDataSet2
            // 
            this.bancoDataSet2.DataSetName = "bancoDataSet2";
            this.bancoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.clientegralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BancoTransacc.presentacion.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientegralTableAdapter
            // 
            this.clientegralTableAdapter.ClearBeforeFill = true;
            // 
            // frmClienteGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmClienteGral";
            this.Text = "frmClienteGral";
            this.Load += new System.EventHandler(this.frmClienteGral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientegralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bancoDataSet2 bancoDataSet2;
        private System.Windows.Forms.BindingSource clientegralBindingSource;
        private bancoDataSet2TableAdapters.ClientegralTableAdapter clientegralTableAdapter;
    }
}