namespace DataBase
{
    partial class FormFine
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
            System.Windows.Forms.Label iD_CarLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            System.Windows.Forms.Label type_DamageLabel;
            System.Windows.Forms.Label sum_FineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFine));
            this.label1 = new System.Windows.Forms.Label();
            this.carDataBaseDataSet = new DataBase.CarDataBaseDataSet();
            this.fineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fineTableAdapter = new DataBase.CarDataBaseDataSetTableAdapters.FineTableAdapter();
            this.tableAdapterManager = new DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager();
            this.fineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CarTextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientTextBox = new System.Windows.Forms.TextBox();
            this.type_DamageTextBox = new System.Windows.Forms.TextBox();
            this.sum_FineTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_CarLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            type_DamageLabel = new System.Windows.Forms.Label();
            sum_FineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingNavigator)).BeginInit();
            this.fineBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_CarLabel
            // 
            iD_CarLabel.AutoSize = true;
            iD_CarLabel.Location = new System.Drawing.Point(67, 98);
            iD_CarLabel.Name = "iD_CarLabel";
            iD_CarLabel.Size = new System.Drawing.Size(40, 13);
            iD_CarLabel.TabIndex = 4;
            iD_CarLabel.Text = "ID Car:";
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Location = new System.Drawing.Point(57, 124);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClientLabel.TabIndex = 6;
            iD_ClientLabel.Text = "ID Client:";
            // 
            // type_DamageLabel
            // 
            type_DamageLabel.AutoSize = true;
            type_DamageLabel.Location = new System.Drawing.Point(30, 151);
            type_DamageLabel.Name = "type_DamageLabel";
            type_DamageLabel.Size = new System.Drawing.Size(77, 13);
            type_DamageLabel.TabIndex = 8;
            type_DamageLabel.Text = "Type Damage:";
            // 
            // sum_FineLabel
            // 
            sum_FineLabel.AutoSize = true;
            sum_FineLabel.Location = new System.Drawing.Point(52, 179);
            sum_FineLabel.Name = "sum_FineLabel";
            sum_FineLabel.Size = new System.Drawing.Size(54, 13);
            sum_FineLabel.TabIndex = 10;
            sum_FineLabel.Text = "Sum Fine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Штрафы\"";
            // 
            // carDataBaseDataSet
            // 
            this.carDataBaseDataSet.DataSetName = "CarDataBaseDataSet";
            this.carDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fineBindingSource
            // 
            this.fineBindingSource.DataMember = "Fine";
            this.fineBindingSource.DataSource = this.carDataBaseDataSet;
            // 
            // fineTableAdapter
            // 
            this.fineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoparkTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarNameTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.FineTableAdapter = this.fineTableAdapter;
            this.tableAdapterManager.Issued_CarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fineBindingNavigator
            // 
            this.fineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fineBindingNavigator.BindingSource = this.fineBindingSource;
            this.fineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fineBindingNavigatorSaveItem});
            this.fineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fineBindingNavigator.Name = "fineBindingNavigator";
            this.fineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fineBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.fineBindingNavigator.TabIndex = 2;
            this.fineBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fineBindingNavigatorSaveItem
            // 
            this.fineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fineBindingNavigatorSaveItem.Image")));
            this.fineBindingNavigatorSaveItem.Name = "fineBindingNavigatorSaveItem";
            this.fineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fineBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.fineBindingNavigatorSaveItem.Click += new System.EventHandler(this.fineBindingNavigatorSaveItem_Click);
            // 
            // iD_CarTextBox
            // 
            this.iD_CarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineBindingSource, "ID_Car", true));
            this.iD_CarTextBox.Location = new System.Drawing.Point(113, 95);
            this.iD_CarTextBox.Name = "iD_CarTextBox";
            this.iD_CarTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CarTextBox.TabIndex = 5;
            // 
            // iD_ClientTextBox
            // 
            this.iD_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineBindingSource, "ID_Client", true));
            this.iD_ClientTextBox.Location = new System.Drawing.Point(113, 121);
            this.iD_ClientTextBox.Name = "iD_ClientTextBox";
            this.iD_ClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ClientTextBox.TabIndex = 7;
            // 
            // type_DamageTextBox
            // 
            this.type_DamageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineBindingSource, "Type_Damage", true));
            this.type_DamageTextBox.Location = new System.Drawing.Point(113, 148);
            this.type_DamageTextBox.Name = "type_DamageTextBox";
            this.type_DamageTextBox.Size = new System.Drawing.Size(100, 20);
            this.type_DamageTextBox.TabIndex = 9;
            // 
            // sum_FineTextBox
            // 
            this.sum_FineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fineBindingSource, "Sum_Fine", true));
            this.sum_FineTextBox.Location = new System.Drawing.Point(112, 176);
            this.sum_FineTextBox.Name = "sum_FineTextBox";
            this.sum_FineTextBox.Size = new System.Drawing.Size(100, 20);
            this.sum_FineTextBox.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(122, 264);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(219, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(122, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 295);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(sum_FineLabel);
            this.Controls.Add(this.sum_FineTextBox);
            this.Controls.Add(type_DamageLabel);
            this.Controls.Add(this.type_DamageTextBox);
            this.Controls.Add(iD_ClientLabel);
            this.Controls.Add(this.iD_ClientTextBox);
            this.Controls.Add(iD_CarLabel);
            this.Controls.Add(this.iD_CarTextBox);
            this.Controls.Add(this.fineBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormFine";
            this.Text = "FormFine";
            this.Load += new System.EventHandler(this.FormFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingNavigator)).EndInit();
            this.fineBindingNavigator.ResumeLayout(false);
            this.fineBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CarDataBaseDataSet carDataBaseDataSet;
        private System.Windows.Forms.BindingSource fineBindingSource;
        private CarDataBaseDataSetTableAdapters.FineTableAdapter fineTableAdapter;
        private CarDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fineBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fineBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CarTextBox;
        private System.Windows.Forms.TextBox iD_ClientTextBox;
        private System.Windows.Forms.TextBox type_DamageTextBox;
        private System.Windows.Forms.TextBox sum_FineTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}