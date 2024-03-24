namespace Samoilov
{
    partial class FormС
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
            this.oKRDataSet = new Samoilov.OKRDataSet();
            this.oKRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writersTableAdapter = new Samoilov.OKRDataSetTableAdapters.WritersTableAdapter();
            this.writersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // oKRDataSet
            // 
            this.oKRDataSet.DataSetName = "OKRDataSet";
            this.oKRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oKRDataSetBindingSource
            // 
            this.oKRDataSetBindingSource.DataSource = this.oKRDataSet;
            this.oKRDataSetBindingSource.Position = 0;
            // 
            // writersBindingSource
            // 
            this.writersBindingSource.DataMember = "Writers";
            this.writersBindingSource.DataSource = this.oKRDataSetBindingSource;
            // 
            // writersTableAdapter
            // 
            this.writersTableAdapter.ClearBeforeFill = true;
            // 
            // writersBindingSource1
            // 
            this.writersBindingSource1.DataMember = "Writers";
            this.writersBindingSource1.DataSource = this.oKRDataSetBindingSource;
            // 
            // FormС
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormС";
            this.Text = "FormС";
            this.Load += new System.EventHandler(this.FormС_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oKRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OKRDataSet oKRDataSet;
        private System.Windows.Forms.BindingSource oKRDataSetBindingSource;
        private System.Windows.Forms.BindingSource writersBindingSource;
        private OKRDataSetTableAdapters.WritersTableAdapter writersTableAdapter;
        private System.Windows.Forms.BindingSource writersBindingSource1;
    }
}