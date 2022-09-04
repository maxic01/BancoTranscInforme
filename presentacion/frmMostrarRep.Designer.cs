namespace BancoTransacc.presentacion
{
    partial class frmMostrarRep
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
            this.saldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new BancoTransacc.bancoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.saldosTableAdapter = new BancoTransacc.bancoDataSetTableAdapters.SaldosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saldosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // saldosBindingSource
            // 
            this.saldosBindingSource.DataMember = "Saldos";
            this.saldosBindingSource.DataSource = this.bancoDataSet;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.saldosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BancoTransacc.presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // saldosTableAdapter
            // 
            this.saldosTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMostrarRep";
            this.Text = "frmMostrarRep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMostrarRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saldosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource saldosBindingSource;
        private bancoDataSet bancoDataSet;
        private bancoDataSetTableAdapters.SaldosTableAdapter saldosTableAdapter;
    }
}