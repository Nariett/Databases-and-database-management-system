namespace DataBase
{
    partial class FormDiscounts
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
            System.Windows.Forms.Label discount_PercentageLabel;
            System.Windows.Forms.Label number_TripsLabel;
            System.Windows.Forms.Label req_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscounts));
            System.Windows.Forms.Label iD_ClientLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.carDataBaseDataSet = new DataBase.CarDataBaseDataSet();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountsTableAdapter = new DataBase.CarDataBaseDataSetTableAdapters.DiscountsTableAdapter();
            this.tableAdapterManager = new DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager();
            this.discountsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.discountsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.discount_PercentageTextBox = new System.Windows.Forms.TextBox();
            this.number_TripsTextBox = new System.Windows.Forms.TextBox();
            this.req_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new DataBase.CarDataBaseDataSetTableAdapters.ClientTableAdapter();
            this.iD_ClientComboBox = new System.Windows.Forms.ComboBox();
            discount_PercentageLabel = new System.Windows.Forms.Label();
            number_TripsLabel = new System.Windows.Forms.Label();
            req_DateLabel = new System.Windows.Forms.Label();
            iD_ClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingNavigator)).BeginInit();
            this.discountsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // discount_PercentageLabel
            // 
            discount_PercentageLabel.AutoSize = true;
            discount_PercentageLabel.Location = new System.Drawing.Point(12, 106);
            discount_PercentageLabel.Name = "discount_PercentageLabel";
            discount_PercentageLabel.Size = new System.Drawing.Size(110, 13);
            discount_PercentageLabel.TabIndex = 6;
            discount_PercentageLabel.Text = "Discount Percentage:";
            // 
            // number_TripsLabel
            // 
            number_TripsLabel.AutoSize = true;
            number_TripsLabel.Location = new System.Drawing.Point(49, 132);
            number_TripsLabel.Name = "number_TripsLabel";
            number_TripsLabel.Size = new System.Drawing.Size(73, 13);
            number_TripsLabel.TabIndex = 8;
            number_TripsLabel.Text = "Number Trips:";
            // 
            // req_DateLabel
            // 
            req_DateLabel.AutoSize = true;
            req_DateLabel.Location = new System.Drawing.Point(66, 159);
            req_DateLabel.Name = "req_DateLabel";
            req_DateLabel.Size = new System.Drawing.Size(56, 13);
            req_DateLabel.TabIndex = 10;
            req_DateLabel.Text = "Req Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Скидки\"";
            // 
            // carDataBaseDataSet
            // 
            this.carDataBaseDataSet.DataSetName = "CarDataBaseDataSet";
            this.carDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "Discounts";
            this.discountsBindingSource.DataSource = this.carDataBaseDataSet;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoparkTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarNameTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DiscountsTableAdapter = this.discountsTableAdapter;
            this.tableAdapterManager.FineTableAdapter = null;
            this.tableAdapterManager.Issued_CarsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.CarDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // discountsBindingNavigator
            // 
            this.discountsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.discountsBindingNavigator.BindingSource = this.discountsBindingSource;
            this.discountsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.discountsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.discountsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.discountsBindingNavigatorSaveItem});
            this.discountsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.discountsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.discountsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.discountsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.discountsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.discountsBindingNavigator.Name = "discountsBindingNavigator";
            this.discountsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.discountsBindingNavigator.Size = new System.Drawing.Size(460, 25);
            this.discountsBindingNavigator.TabIndex = 3;
            this.discountsBindingNavigator.Text = "bindingNavigator1";
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
            // discountsBindingNavigatorSaveItem
            // 
            this.discountsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.discountsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("discountsBindingNavigatorSaveItem.Image")));
            this.discountsBindingNavigatorSaveItem.Name = "discountsBindingNavigatorSaveItem";
            this.discountsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.discountsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.discountsBindingNavigatorSaveItem.Click += new System.EventHandler(this.discountsBindingNavigatorSaveItem_Click);
            // 
            // discount_PercentageTextBox
            // 
            this.discount_PercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.discountsBindingSource, "Discount_Percentage", true));
            this.discount_PercentageTextBox.Location = new System.Drawing.Point(128, 103);
            this.discount_PercentageTextBox.Name = "discount_PercentageTextBox";
            this.discount_PercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.discount_PercentageTextBox.TabIndex = 7;
            // 
            // number_TripsTextBox
            // 
            this.number_TripsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.discountsBindingSource, "Number_Trips", true));
            this.number_TripsTextBox.Location = new System.Drawing.Point(128, 129);
            this.number_TripsTextBox.Name = "number_TripsTextBox";
            this.number_TripsTextBox.Size = new System.Drawing.Size(100, 20);
            this.number_TripsTextBox.TabIndex = 9;
            // 
            // req_DateDateTimePicker
            // 
            this.req_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.discountsBindingSource, "Req_Date", true));
            this.req_DateDateTimePicker.Location = new System.Drawing.Point(128, 155);
            this.req_DateDateTimePicker.Name = "req_DateDateTimePicker";
            this.req_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.req_DateDateTimePicker.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(137, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.carDataBaseDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // iD_ClientLabel
            // 
            iD_ClientLabel.AutoSize = true;
            iD_ClientLabel.Location = new System.Drawing.Point(72, 79);
            iD_ClientLabel.Name = "iD_ClientLabel";
            iD_ClientLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClientLabel.TabIndex = 27;
            iD_ClientLabel.Text = "ID Client:";
            // 
            // iD_ClientComboBox
            // 
            this.iD_ClientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.discountsBindingSource, "ID_Client", true));
            this.iD_ClientComboBox.DataSource = this.discountsBindingSource;
            this.iD_ClientComboBox.DisplayMember = "ID_Client";
            this.iD_ClientComboBox.FormattingEnabled = true;
            this.iD_ClientComboBox.Location = new System.Drawing.Point(128, 76);
            this.iD_ClientComboBox.Name = "iD_ClientComboBox";
            this.iD_ClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_ClientComboBox.TabIndex = 28;
            this.iD_ClientComboBox.ValueMember = "ID_Client";
            // 
            // FormDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 282);
            this.Controls.Add(iD_ClientLabel);
            this.Controls.Add(this.iD_ClientComboBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(req_DateLabel);
            this.Controls.Add(this.req_DateDateTimePicker);
            this.Controls.Add(number_TripsLabel);
            this.Controls.Add(this.number_TripsTextBox);
            this.Controls.Add(discount_PercentageLabel);
            this.Controls.Add(this.discount_PercentageTextBox);
            this.Controls.Add(this.discountsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormDiscounts";
            this.Text = "FormDiscounts";
            this.Load += new System.EventHandler(this.FormDiscounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingNavigator)).EndInit();
            this.discountsBindingNavigator.ResumeLayout(false);
            this.discountsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CarDataBaseDataSet carDataBaseDataSet;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private CarDataBaseDataSetTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private CarDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator discountsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton discountsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox discount_PercentageTextBox;
        private System.Windows.Forms.TextBox number_TripsTextBox;
        private System.Windows.Forms.DateTimePicker req_DateDateTimePicker;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private CarDataBaseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox iD_ClientComboBox;
    }
}