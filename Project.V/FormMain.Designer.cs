
namespace Project.V
{
    partial class FormMain
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
            this.saveFileDialogTable_SSV = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SSV = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_SSV = new System.Windows.Forms.TabControl();
            this.tabPageOrderData_SSV = new System.Windows.Forms.TabPage();
            this.dataGridViewTableOrders_SSV = new System.Windows.Forms.DataGridView();
            this.NumberOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesOrders_SSV = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOpenOrder_SSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddOrders_SSV = new System.Windows.Forms.Button();
            this.buttonDownloadOrders_SSV = new System.Windows.Forms.Button();
            this.tabPageStats_SSV = new System.Windows.Forms.TabPage();
            this.menuStrip_SSV = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_SSV = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl_SSV.SuspendLayout();
            this.tabPageOrderData_SSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).BeginInit();
            this.groupBoxMovesOrders_SSV.SuspendLayout();
            this.menuStrip_SSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTable_SSV
            // 
            this.openFileDialogTable_SSV.FileName = "openFileDialog1";
            // 
            // tabControl_SSV
            // 
            this.tabControl_SSV.Controls.Add(this.tabPageOrderData_SSV);
            this.tabControl_SSV.Controls.Add(this.tabPageStats_SSV);
            this.tabControl_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_SSV.Location = new System.Drawing.Point(0, 28);
            this.tabControl_SSV.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_SSV.Name = "tabControl_SSV";
            this.tabControl_SSV.SelectedIndex = 0;
            this.tabControl_SSV.Size = new System.Drawing.Size(1228, 473);
            this.tabControl_SSV.TabIndex = 3;
            // 
            // tabPageOrderData_SSV
            // 
            this.tabPageOrderData_SSV.Controls.Add(this.dataGridViewTableOrders_SSV);
            this.tabPageOrderData_SSV.Controls.Add(this.groupBoxMovesOrders_SSV);
            this.tabPageOrderData_SSV.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrderData_SSV.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrderData_SSV.Name = "tabPageOrderData_SSV";
            this.tabPageOrderData_SSV.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrderData_SSV.Size = new System.Drawing.Size(1220, 444);
            this.tabPageOrderData_SSV.TabIndex = 1;
            this.tabPageOrderData_SSV.Text = "База данных по заказам";
            this.tabPageOrderData_SSV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTableOrders_SSV
            // 
            this.dataGridViewTableOrders_SSV.AllowUserToAddRows = false;
            this.dataGridViewTableOrders_SSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableOrders_SSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableOrders_SSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOrder_SSV,
            this.DateDone_SSV,
            this.PriceOrder_SSV,
            this.NameOrder_SSV,
            this.Price_SSV,
            this.Quantity_SSV});
            this.dataGridViewTableOrders_SSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableOrders_SSV.Location = new System.Drawing.Point(244, 4);
            this.dataGridViewTableOrders_SSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTableOrders_SSV.Name = "dataGridViewTableOrders_SSV";
            this.dataGridViewTableOrders_SSV.RowHeadersWidth = 51;
            this.dataGridViewTableOrders_SSV.RowTemplate.Height = 24;
            this.dataGridViewTableOrders_SSV.Size = new System.Drawing.Size(972, 436);
            this.dataGridViewTableOrders_SSV.TabIndex = 1;
            this.dataGridViewTableOrders_SSV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SSV_RowPrePaint);
            // 
            // NumberOrder_SSV
            // 
            this.NumberOrder_SSV.HeaderText = "Номер заказа";
            this.NumberOrder_SSV.MinimumWidth = 6;
            this.NumberOrder_SSV.Name = "NumberOrder_SSV";
            // 
            // DateDone_SSV
            // 
            this.DateDone_SSV.HeaderText = "Дата исполнения";
            this.DateDone_SSV.MinimumWidth = 6;
            this.DateDone_SSV.Name = "DateDone_SSV";
            this.DateDone_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PriceOrder_SSV
            // 
            this.PriceOrder_SSV.HeaderText = "Стоимость заказа";
            this.PriceOrder_SSV.MinimumWidth = 6;
            this.PriceOrder_SSV.Name = "PriceOrder_SSV";
            // 
            // NameOrder_SSV
            // 
            this.NameOrder_SSV.HeaderText = "Название товара";
            this.NameOrder_SSV.MinimumWidth = 6;
            this.NameOrder_SSV.Name = "NameOrder_SSV";
            this.NameOrder_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOrder_SSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price_SSV
            // 
            this.Price_SSV.HeaderText = "Цена товара";
            this.Price_SSV.MinimumWidth = 6;
            this.Price_SSV.Name = "Price_SSV";
            // 
            // Quantity_SSV
            // 
            this.Quantity_SSV.HeaderText = "Количество товаров";
            this.Quantity_SSV.MinimumWidth = 6;
            this.Quantity_SSV.Name = "Quantity_SSV";
            // 
            // groupBoxMovesOrders_SSV
            // 
            this.groupBoxMovesOrders_SSV.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMovesOrders_SSV.Controls.Add(this.label2);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.textBox1);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.label1);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.comboBox1);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonOpenOrder_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.button2);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.button1);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonAddOrders_SSV);
            this.groupBoxMovesOrders_SSV.Controls.Add(this.buttonDownloadOrders_SSV);
            this.groupBoxMovesOrders_SSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMovesOrders_SSV.Location = new System.Drawing.Point(4, 4);
            this.groupBoxMovesOrders_SSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMovesOrders_SSV.Name = "groupBoxMovesOrders_SSV";
            this.groupBoxMovesOrders_SSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMovesOrders_SSV.Size = new System.Drawing.Size(240, 436);
            this.groupBoxMovesOrders_SSV.TabIndex = 4;
            this.groupBoxMovesOrders_SSV.TabStop = false;
            this.groupBoxMovesOrders_SSV.Text = "Действия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Слово, которое надо найти:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите столб для поиска";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Номер заказа",
            "Дата исполнения",
            "Стоимость заказа",
            "Название товара",
            "Цена товара",
            "Количество товаров"});
            this.comboBox1.Location = new System.Drawing.Point(7, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonOpenOrder_SSV
            // 
            this.buttonOpenOrder_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenOrder_SSV.Location = new System.Drawing.Point(4, 26);
            this.buttonOpenOrder_SSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenOrder_SSV.Name = "buttonOpenOrder_SSV";
            this.buttonOpenOrder_SSV.Size = new System.Drawing.Size(227, 48);
            this.buttonOpenOrder_SSV.TabIndex = 0;
            this.buttonOpenOrder_SSV.Text = "Открыть базу данных по заказам";
            this.buttonOpenOrder_SSV.UseVisualStyleBackColor = true;
            this.buttonOpenOrder_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(4, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Удалить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddOrders_SSV
            // 
            this.buttonAddOrders_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrders_SSV.Location = new System.Drawing.Point(4, 131);
            this.buttonAddOrders_SSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddOrders_SSV.Name = "buttonAddOrders_SSV";
            this.buttonAddOrders_SSV.Size = new System.Drawing.Size(227, 48);
            this.buttonAddOrders_SSV.TabIndex = 0;
            this.buttonAddOrders_SSV.Text = "Добавить заказ";
            this.buttonAddOrders_SSV.UseVisualStyleBackColor = true;
            this.buttonAddOrders_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // buttonDownloadOrders_SSV
            // 
            this.buttonDownloadOrders_SSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadOrders_SSV.Location = new System.Drawing.Point(4, 78);
            this.buttonDownloadOrders_SSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadOrders_SSV.Name = "buttonDownloadOrders_SSV";
            this.buttonDownloadOrders_SSV.Size = new System.Drawing.Size(227, 48);
            this.buttonDownloadOrders_SSV.TabIndex = 0;
            this.buttonDownloadOrders_SSV.Text = "Сохранить базу данных по заказам";
            this.buttonDownloadOrders_SSV.UseVisualStyleBackColor = true;
            this.buttonDownloadOrders_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // tabPageStats_SSV
            // 
            this.tabPageStats_SSV.Location = new System.Drawing.Point(4, 25);
            this.tabPageStats_SSV.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStats_SSV.Name = "tabPageStats_SSV";
            this.tabPageStats_SSV.Size = new System.Drawing.Size(1220, 442);
            this.tabPageStats_SSV.TabIndex = 2;
            this.tabPageStats_SSV.Text = "Статистика";
            this.tabPageStats_SSV.UseVisualStyleBackColor = true;
            // 
            // menuStrip_SSV
            // 
            this.menuStrip_SSV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_SSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile_SSV,
            this.toolStripMenuItemInfo_SSV,
            this.toolStripMenuItemExit_SSV});
            this.menuStrip_SSV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SSV.Name = "menuStrip_SSV";
            this.menuStrip_SSV.Size = new System.Drawing.Size(1228, 28);
            this.menuStrip_SSV.TabIndex = 4;
            this.menuStrip_SSV.Text = "menuStrip1";
            // 
            // toolStripMenuFile_SSV
            // 
            this.toolStripMenuFile_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd_SSV,
            this.toolStripMenuItemOpen_SSV,
            this.toolStripMenuItemSave_SSV});
            this.toolStripMenuFile_SSV.Name = "toolStripMenuFile_SSV";
            this.toolStripMenuFile_SSV.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuFile_SSV.Text = "Файл";
            // 
            // toolStripMenuItemAdd_SSV
            // 
            this.toolStripMenuItemAdd_SSV.Name = "toolStripMenuItemAdd_SSV";
            this.toolStripMenuItemAdd_SSV.Size = new System.Drawing.Size(166, 26);
            this.toolStripMenuItemAdd_SSV.Text = "Добавить";
            this.toolStripMenuItemAdd_SSV.Click += new System.EventHandler(this.buttonAdd_SSV_Click);
            // 
            // toolStripMenuItemOpen_SSV
            // 
            this.toolStripMenuItemOpen_SSV.Name = "toolStripMenuItemOpen_SSV";
            this.toolStripMenuItemOpen_SSV.Size = new System.Drawing.Size(166, 26);
            this.toolStripMenuItemOpen_SSV.Text = "Открыть";
            this.toolStripMenuItemOpen_SSV.Click += new System.EventHandler(this.buttonOpen_SSV_Click);
            // 
            // toolStripMenuItemSave_SSV
            // 
            this.toolStripMenuItemSave_SSV.Name = "toolStripMenuItemSave_SSV";
            this.toolStripMenuItemSave_SSV.Size = new System.Drawing.Size(166, 26);
            this.toolStripMenuItemSave_SSV.Text = "Сохранить";
            this.toolStripMenuItemSave_SSV.Click += new System.EventHandler(this.buttonDownload_SSV_Click);
            // 
            // toolStripMenuItemInfo_SSV
            // 
            this.toolStripMenuItemInfo_SSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInstruction_SSV,
            this.toolStripMenuItemAbout_SSV});
            this.toolStripMenuItemInfo_SSV.Name = "toolStripMenuItemInfo_SSV";
            this.toolStripMenuItemInfo_SSV.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItemInfo_SSV.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_SSV
            // 
            this.toolStripMenuItemInstruction_SSV.Name = "toolStripMenuItemInstruction_SSV";
            this.toolStripMenuItemInstruction_SSV.Size = new System.Drawing.Size(399, 26);
            this.toolStripMenuItemInstruction_SSV.Text = "Инструкция по использованию программы";
            // 
            // toolStripMenuItemAbout_SSV
            // 
            this.toolStripMenuItemAbout_SSV.Name = "toolStripMenuItemAbout_SSV";
            this.toolStripMenuItemAbout_SSV.Size = new System.Drawing.Size(399, 26);
            this.toolStripMenuItemAbout_SSV.Text = "О программе ";
            this.toolStripMenuItemAbout_SSV.Click += new System.EventHandler(this.buttonInfo_SSV_Click);
            // 
            // toolStripMenuItemExit_SSV
            // 
            this.toolStripMenuItemExit_SSV.Name = "toolStripMenuItemExit_SSV";
            this.toolStripMenuItemExit_SSV.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItemExit_SSV.Text = "Выход";
            this.toolStripMenuItemExit_SSV.Click += new System.EventHandler(this.toolStripMenuItemExit_SSV_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Удалить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 501);
            this.Controls.Add(this.tabControl_SSV);
            this.Controls.Add(this.menuStrip_SSV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl_SSV.ResumeLayout(false);
            this.tabPageOrderData_SSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SSV)).EndInit();
            this.groupBoxMovesOrders_SSV.ResumeLayout(false);
            this.groupBoxMovesOrders_SSV.PerformLayout();
            this.menuStrip_SSV.ResumeLayout(false);
            this.menuStrip_SSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SSV;
        private System.Windows.Forms.TabControl tabControl_SSV;
        private System.Windows.Forms.TabPage tabPageOrderData_SSV;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDone_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_SSV;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_SSV;
        private System.Windows.Forms.Button buttonOpenOrder_SSV;
        private System.Windows.Forms.Button buttonAddOrders_SSV;
        private System.Windows.Forms.Button buttonDownloadOrders_SSV;
        private System.Windows.Forms.MenuStrip menuStrip_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SSV;
        private System.Windows.Forms.TabPage tabPageStats_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

