namespace Samoilov
{
    partial class FormB
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
            this.writersTableAdapter1 = new Samoilov.OKRDataSetTableAdapters.WritersTableAdapter();
            this.okrDataSet1 = new Samoilov.OKRDataSet();
            this.okrDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // writersTableAdapter1
            // 
            this.writersTableAdapter1.ClearBeforeFill = true;
            // 
            // okrDataSet1
            // 
            this.okrDataSet1.DataSetName = "OKRDataSet";
            this.okrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // okrDataSet1BindingSource
            // 
            this.okrDataSet1BindingSource.DataSource = this.okrDataSet1;
            this.okrDataSet1BindingSource.Position = 0;
            // 
            // writersBindingSource
            // 
            this.writersBindingSource.DataMember = "Writers";
            this.writersBindingSource.DataSource = this.okrDataSet1BindingSource;
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormB";
            this.Text = "FormB";
            this.Load += new System.EventHandler(this.FormB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okrDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OKRDataSetTableAdapters.WritersTableAdapter writersTableAdapter1;
        private OKRDataSet okrDataSet1;
        private System.Windows.Forms.BindingSource writersBindingSource;
        private System.Windows.Forms.BindingSource okrDataSet1BindingSource;
    }
}