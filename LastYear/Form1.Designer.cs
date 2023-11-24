namespace LastYear
{
    partial class Form1
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
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label moduleNameLabel;
            System.Windows.Forms.Label moduleYearLabel;
            System.Windows.Forms.Label moduleTypeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.universityDataSet = new LastYear.UniversityDataSet();
            this.tb_ModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTableAdapter = new LastYear.UniversityDataSetTableAdapters.tb_ModuleTableAdapter();
            this.tableAdapterManager = new LastYear.UniversityDataSetTableAdapters.TableAdapterManager();
            this.tb_ModuleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_ModuleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.moduleNameTextBox = new System.Windows.Forms.TextBox();
            this.moduleYearTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTypeTableAdapter = new LastYear.UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            moduleCodeLabel = new System.Windows.Forms.Label();
            moduleNameLabel = new System.Windows.Forms.Label();
            moduleYearLabel = new System.Windows.Forms.Label();
            moduleTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).BeginInit();
            this.tb_ModuleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(214, 31);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(73, 13);
            moduleCodeLabel.TabIndex = 4;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // moduleNameLabel
            // 
            moduleNameLabel.AutoSize = true;
            moduleNameLabel.Location = new System.Drawing.Point(214, 57);
            moduleNameLabel.Name = "moduleNameLabel";
            moduleNameLabel.Size = new System.Drawing.Size(76, 13);
            moduleNameLabel.TabIndex = 6;
            moduleNameLabel.Text = "Module Name:";
            // 
            // moduleYearLabel
            // 
            moduleYearLabel.AutoSize = true;
            moduleYearLabel.Location = new System.Drawing.Point(214, 83);
            moduleYearLabel.Name = "moduleYearLabel";
            moduleYearLabel.Size = new System.Drawing.Size(70, 13);
            moduleYearLabel.TabIndex = 8;
            moduleYearLabel.Text = "Module Year:";
            // 
            // moduleTypeLabel
            // 
            moduleTypeLabel.AutoSize = true;
            moduleTypeLabel.Location = new System.Drawing.Point(214, 109);
            moduleTypeLabel.Name = "moduleTypeLabel";
            moduleTypeLabel.Size = new System.Drawing.Size(72, 13);
            moduleTypeLabel.TabIndex = 10;
            moduleTypeLabel.Text = "Module Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 13);
            label1.TabIndex = 17;
            label1.Text = "Module Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 13);
            label2.TabIndex = 19;
            label2.Text = "Module Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 21;
            label3.Text = "Module Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 13);
            label4.TabIndex = 23;
            label4.Text = "Module Type:";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ModuleBindingSource
            // 
            this.tb_ModuleBindingSource.DataMember = "tb_Module";
            this.tb_ModuleBindingSource.DataSource = this.universityDataSet;
            // 
            // tb_ModuleTableAdapter
            // 
            this.tb_ModuleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ModuleTableAdapter = this.tb_ModuleTableAdapter;
            this.tableAdapterManager.tb_ModuleTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LastYear.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ModuleBindingNavigator
            // 
            this.tb_ModuleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ModuleBindingNavigator.BindingSource = this.tb_ModuleBindingSource;
            this.tb_ModuleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ModuleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ModuleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_ModuleBindingNavigatorSaveItem});
            this.tb_ModuleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ModuleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ModuleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ModuleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ModuleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ModuleBindingNavigator.Name = "tb_ModuleBindingNavigator";
            this.tb_ModuleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ModuleBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.tb_ModuleBindingNavigator.TabIndex = 0;
            this.tb_ModuleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ModuleBindingNavigatorSaveItem
            // 
            this.tb_ModuleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ModuleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ModuleBindingNavigatorSaveItem.Image")));
            this.tb_ModuleBindingNavigatorSaveItem.Name = "tb_ModuleBindingNavigatorSaveItem";
            this.tb_ModuleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_ModuleBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ModuleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ModuleBindingNavigatorSaveItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ModuleBindingSource;
            this.listBox1.DisplayMember = "ModuleName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 95);
            this.listBox1.TabIndex = 1;
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleCode", true));
            this.moduleCodeTextBox.Location = new System.Drawing.Point(296, 28);
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduleCodeTextBox.TabIndex = 5;
            // 
            // moduleNameTextBox
            // 
            this.moduleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleName", true));
            this.moduleNameTextBox.Location = new System.Drawing.Point(296, 54);
            this.moduleNameTextBox.Name = "moduleNameTextBox";
            this.moduleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduleNameTextBox.TabIndex = 7;
            // 
            // moduleYearTextBox
            // 
            this.moduleYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleYear", true));
            this.moduleYearTextBox.Location = new System.Drawing.Point(296, 80);
            this.moduleYearTextBox.Name = "moduleYearTextBox";
            this.moduleYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduleYearTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ModuleBindingSource, "ModuleType", true));
            this.comboBox1.DataSource = this.tbModuleTypeBindingSource;
            this.comboBox1.DisplayMember = "ModuleTypeName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            // 
            // tbModuleTypeBindingSource
            // 
            this.tbModuleTypeBindingSource.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource.DataSource = this.universityDataSet;
            // 
            // tb_ModuleTypeTableAdapter
            // 
            this.tb_ModuleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.tbxYear);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.tbxCode);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ModuleBindingSource, "ModuleType", true));
            this.comboBox2.DataSource = this.tbModuleTypeBindingSource;
            this.comboBox2.DisplayMember = "ModuleTypeName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "Id";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(91, 71);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 20);
            this.tbxYear.TabIndex = 25;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(91, 45);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 24;
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(91, 19);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(100, 20);
            this.tbxCode.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(211, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(211, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(402, 28);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(100, 20);
            this.tbxFilter.TabIndex = 20;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(moduleCodeLabel);
            this.Controls.Add(this.moduleCodeTextBox);
            this.Controls.Add(moduleNameLabel);
            this.Controls.Add(this.moduleNameTextBox);
            this.Controls.Add(moduleYearLabel);
            this.Controls.Add(this.moduleYearTextBox);
            this.Controls.Add(moduleTypeLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tb_ModuleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).EndInit();
            this.tb_ModuleBindingNavigator.ResumeLayout(false);
            this.tb_ModuleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource tb_ModuleBindingSource;
        private UniversityDataSetTableAdapters.tb_ModuleTableAdapter tb_ModuleTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ModuleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_ModuleBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.TextBox moduleNameTextBox;
        private System.Windows.Forms.TextBox moduleYearTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource;
        private UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter tb_ModuleTypeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

