namespace DataBase
{
    partial class FormIssued_Cars
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
            System.Windows.Forms.Label iD_DealLabel;
            System.Windows.Forms.Label iD_ClientLabel;
            System.Windows.Forms.Label iD_CarLabel;
            System.Windows.Forms.Label date_IssueLabel;
            System.Windows.Forms.Label date_ReturnLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIssued_Cars));
            this.label1 = new System.Windows.Forms.Label();
            this.carDataBaseDataSet = new DataBase.CarDataBaseDataSet();
            this.issued_CarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issued_CarsTableAdapter = new DataBase.CarDataBaseDataSetTableAdapters.Issued_CarsTableAdapter();
            this.tableAdapterManager = new DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager();
            this.issued_CarsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.issued_CarsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_DealTextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientTextBox = new System.Windows.Forms.TextBox();
            this.iD_CarTextBox = new System.Windows.Forms.TextBox();
            this.date_IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_ReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            iD_DealLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            iD_CarLabel = new System.Windows.Forms.Label();
            date_IssueLabel = new System.Windows.Forms.Label();
            date_ReturnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issued_CarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issued_CarsBindingNavigator)).BeginInit();
            this.issued_CarsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_DealLabel
            // 
            iD_DealLabel.AutoSize = true;
            iD_DealLabel.Location = new System.Drawing.Point(27, 84);
            iD_DealLabel.Name = "iD_DealLabel";
            iD_DealLabel.Size = new System.Drawing.Size(46, 13);
            iD_DealLabel.TabIndex = 2;
            iD_DealLabel.Text = "ID Deal:";
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Location = new System.Drawing.Point(23, 111);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClientLabel.TabIndex = 4;
            iD_ClientLabel.Text = "ID Client:";
            // 
            // iD_CarLabel
            // 
            iD_CarLabel.AutoSize = true;
            iD_CarLabel.Location = new System.Drawing.Point(33, 137);
            iD_CarLabel.Name = "iD_CarLabel";
            iD_CarLabel.Size = new System.Drawing.Size(40, 13);
            iD_CarLabel.TabIndex = 6;
            iD_CarLabel.Text = "ID Car:";
            // 
            // date_IssueLabel
            // 
            date_IssueLabel.AutoSize = true;
            date_IssueLabel.Location = new System.Drawing.Point(12, 164);
            date_IssueLabel.Name = "date_IssueLabel";
            date_IssueLabel.Size = new System.Drawing.Size(61, 13);
            date_IssueLabel.TabIndex = 8;
            date_IssueLabel.Text = "Date Issue:";
            // 
            // date_ReturnLabel
            // 
            date_ReturnLabel.AutoSize = true;
            date_ReturnLabel.Location = new System.Drawing.Point(5, 190);
            date_ReturnLabel.Name = "date_ReturnLabel";
            date_ReturnLabel.Size = new System.Drawing.Size(68, 13);
            date_ReturnLabel.TabIndex = 10;
            date_ReturnLabel.Text = "Date Return:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Арендованные автомобили\"";
            // 
            // carDataBaseDataSet
            // 
            this.carDataBaseDataSet.DataSetName = "CarDataBaseDataSet";
            this.carDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issued_CarsBindingSource
            // 
            this.issued_CarsBindingSource.DataMember = "Issued_Cars";
            this.issued_CarsBindingSource.DataSource = this.carDataBaseDataSet;
            // 
            // issued_CarsTableAdapter
            // 
            this.issued_CarsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoparkTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarNameTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = null;
            this.tableAdapterManager.FineTableAdapter = null;
            this.tableAdapterManager.Issued_CarsTableAdapter = this.issued_CarsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issued_CarsBindingNavigator
            // 
            this.issued_CarsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issued_CarsBindingNavigator.BindingSource = this.issued_CarsBindingSource;
            this.issued_CarsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issued_CarsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issued_CarsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.issued_CarsBindingNavigatorSaveItem});
            this.issued_CarsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issued_CarsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issued_CarsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issued_CarsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issued_CarsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issued_CarsBindingNavigator.Name = "issued_CarsBindingNavigator";
            this.issued_CarsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issued_CarsBindingNavigator.Size = new System.Drawing.Size(410, 25);
            this.issued_CarsBindingNavigator.TabIndex = 2;
            this.issued_CarsBindingNavigator.Text = "bindingNavigator1";
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
            // issued_CarsBindingNavigatorSaveItem
            // 
            this.issued_CarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issued_CarsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issued_CarsBindingNavigatorSaveItem.Image")));
            this.issued_CarsBindingNavigatorSaveItem.Name = "issued_CarsBindingNavigatorSaveItem";
            this.issued_CarsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.issued_CarsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.issued_CarsBindingNavigatorSaveItem.Click += new System.EventHandler(this.issued_CarsBindingNavigatorSaveItem_Click);
            // 
            // iD_DealTextBox
            // 
            this.iD_DealTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issued_CarsBindingSource, "ID_Deal", true));
            this.iD_DealTextBox.Location = new System.Drawing.Point(79, 81);
            this.iD_DealTextBox.Name = "iD_DealTextBox";
            this.iD_DealTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_DealTextBox.TabIndex = 3;
            // 
            // iD_ClientTextBox
            // 
            this.iD_ClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issued_CarsBindingSource, "ID_Client", true));
            this.iD_ClientTextBox.Location = new System.Drawing.Point(79, 108);
            this.iD_ClientTextBox.Name = "iD_ClientTextBox";
            this.iD_ClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ClientTextBox.TabIndex = 5;
            // 
            // iD_CarTextBox
            // 
            this.iD_CarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issued_CarsBindingSource, "ID_Car", true));
            this.iD_CarTextBox.Location = new System.Drawing.Point(79, 134);
            this.iD_CarTextBox.Name = "iD_CarTextBox";
            this.iD_CarTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CarTextBox.TabIndex = 7;
            // 
            // date_IssueDateTimePicker
            // 
            this.date_IssueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issued_CarsBindingSource, "Date_Issue", true));
            this.date_IssueDateTimePicker.Location = new System.Drawing.Point(79, 160);
            this.date_IssueDateTimePicker.Name = "date_IssueDateTimePicker";
            this.date_IssueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_IssueDateTimePicker.TabIndex = 9;
            // 
            // date_ReturnDateTimePicker
            // 
            this.date_ReturnDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issued_CarsBindingSource, "Date_Return", true));
            this.date_ReturnDateTimePicker.Location = new System.Drawing.Point(79, 186);
            this.date_ReturnDateTimePicker.Name = "date_ReturnDateTimePicker";
            this.date_ReturnDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_ReturnDateTimePicker.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(107, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIssued_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(date_ReturnLabel);
            this.Controls.Add(this.date_ReturnDateTimePicker);
            this.Controls.Add(date_IssueLabel);
            this.Controls.Add(this.date_IssueDateTimePicker);
            this.Controls.Add(iD_CarLabel);
            this.Controls.Add(this.iD_CarTextBox);
            this.Controls.Add(iD_ClientLabel);
            this.Controls.Add(this.iD_ClientTextBox);
            this.Controls.Add(iD_DealLabel);
            this.Controls.Add(this.iD_DealTextBox);
            this.Controls.Add(this.issued_CarsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormIssued_Cars";
            this.Text = "FormIssued_Cars";
            this.Load += new System.EventHandler(this.FormIssued_Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issued_CarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issued_CarsBindingNavigator)).EndInit();
            this.issued_CarsBindingNavigator.ResumeLayout(false);
            this.issued_CarsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CarDataBaseDataSet carDataBaseDataSet;
        private System.Windows.Forms.BindingSource issued_CarsBindingSource;
        private CarDataBaseDataSetTableAdapters.Issued_CarsTableAdapter issued_CarsTableAdapter;
        private CarDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issued_CarsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton issued_CarsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_DealTextBox;
        private System.Windows.Forms.TextBox iD_ClientTextBox;
        private System.Windows.Forms.TextBox iD_CarTextBox;
        private System.Windows.Forms.DateTimePicker date_IssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_ReturnDateTimePicker;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}