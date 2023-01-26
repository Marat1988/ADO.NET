
namespace MailingLists.Forms
{
    partial class FormStockProduct
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
            this.tabControlStockProduct = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowStockProduct = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.numericUpDownPriceAdd = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChooseProductAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseStockNumberAdd = new System.Windows.Forms.ComboBox();
            this.labelChooseProduct = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelChooseNumberStock = new System.Windows.Forms.Label();
            this.buttonInputStockProduct = new System.Windows.Forms.Button();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditStockProduct = new System.Windows.Forms.DataGridView();
            this.buttonEditStockProduct = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonDeleteStockProduct = new System.Windows.Forms.Button();
            this.dataGridViewDeleteStockProduct = new System.Windows.Forms.DataGridView();
            this.numericUpDownPriceEdit = new System.Windows.Forms.NumericUpDown();
            this.labelPriceEdit = new System.Windows.Forms.Label();
            this.labelInfoDelete = new System.Windows.Forms.Label();
            this.tabControlStockProduct.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStockProduct)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceAdd)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditStockProduct)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteStockProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStockProduct
            // 
            this.tabControlStockProduct.Controls.Add(this.tabPageShow);
            this.tabControlStockProduct.Controls.Add(this.tabPageAdd);
            this.tabControlStockProduct.Controls.Add(this.tabPageEdit);
            this.tabControlStockProduct.Controls.Add(this.tabPageDelete);
            this.tabControlStockProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStockProduct.Location = new System.Drawing.Point(0, 0);
            this.tabControlStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlStockProduct.Name = "tabControlStockProduct";
            this.tabControlStockProduct.SelectedIndex = 0;
            this.tabControlStockProduct.Size = new System.Drawing.Size(879, 494);
            this.tabControlStockProduct.TabIndex = 2;
            this.tabControlStockProduct.SelectedIndexChanged += new System.EventHandler(this.tabControlStockProduct_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowStockProduct);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Size = new System.Drawing.Size(871, 465);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowStockProduct
            // 
            this.dataGridViewShowStockProduct.AllowUserToAddRows = false;
            this.dataGridViewShowStockProduct.AllowUserToDeleteRows = false;
            this.dataGridViewShowStockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowStockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowStockProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowStockProduct.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewShowStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowStockProduct.MultiSelect = false;
            this.dataGridViewShowStockProduct.Name = "dataGridViewShowStockProduct";
            this.dataGridViewShowStockProduct.ReadOnly = true;
            this.dataGridViewShowStockProduct.RowHeadersWidth = 51;
            this.dataGridViewShowStockProduct.RowTemplate.Height = 24;
            this.dataGridViewShowStockProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowStockProduct.Size = new System.Drawing.Size(865, 461);
            this.dataGridViewShowStockProduct.TabIndex = 0;
            this.dataGridViewShowStockProduct.SelectionChanged += new System.EventHandler(this.dataGridViewShowStockProduct_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.numericUpDownPriceAdd);
            this.tabPageAdd.Controls.Add(this.comboBoxChooseProductAdd);
            this.tabPageAdd.Controls.Add(this.comboBoxChooseStockNumberAdd);
            this.tabPageAdd.Controls.Add(this.labelChooseProduct);
            this.tabPageAdd.Controls.Add(this.labelPrice);
            this.tabPageAdd.Controls.Add(this.labelChooseNumberStock);
            this.tabPageAdd.Controls.Add(this.buttonInputStockProduct);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(871, 465);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPriceAdd
            // 
            this.numericUpDownPriceAdd.DecimalPlaces = 2;
            this.numericUpDownPriceAdd.Location = new System.Drawing.Point(150, 83);
            this.numericUpDownPriceAdd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPriceAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriceAdd.Name = "numericUpDownPriceAdd";
            this.numericUpDownPriceAdd.Size = new System.Drawing.Size(367, 22);
            this.numericUpDownPriceAdd.TabIndex = 10;
            this.numericUpDownPriceAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxChooseProductAdd
            // 
            this.comboBoxChooseProductAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseProductAdd.FormattingEnabled = true;
            this.comboBoxChooseProductAdd.Location = new System.Drawing.Point(150, 48);
            this.comboBoxChooseProductAdd.Name = "comboBoxChooseProductAdd";
            this.comboBoxChooseProductAdd.Size = new System.Drawing.Size(367, 24);
            this.comboBoxChooseProductAdd.TabIndex = 9;
            // 
            // comboBoxChooseStockNumberAdd
            // 
            this.comboBoxChooseStockNumberAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseStockNumberAdd.FormattingEnabled = true;
            this.comboBoxChooseStockNumberAdd.Location = new System.Drawing.Point(197, 15);
            this.comboBoxChooseStockNumberAdd.Name = "comboBoxChooseStockNumberAdd";
            this.comboBoxChooseStockNumberAdd.Size = new System.Drawing.Size(320, 24);
            this.comboBoxChooseStockNumberAdd.TabIndex = 8;
            // 
            // labelChooseProduct
            // 
            this.labelChooseProduct.AutoSize = true;
            this.labelChooseProduct.Location = new System.Drawing.Point(24, 51);
            this.labelChooseProduct.Name = "labelChooseProduct";
            this.labelChooseProduct.Size = new System.Drawing.Size(120, 17);
            this.labelChooseProduct.TabIndex = 7;
            this.labelChooseProduct.Text = "Выберите товар:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(24, 83);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(102, 17);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Введите цену:";
            // 
            // labelChooseNumberStock
            // 
            this.labelChooseNumberStock.AutoSize = true;
            this.labelChooseNumberStock.Location = new System.Drawing.Point(24, 15);
            this.labelChooseNumberStock.Name = "labelChooseNumberStock";
            this.labelChooseNumberStock.Size = new System.Drawing.Size(166, 17);
            this.labelChooseNumberStock.TabIndex = 5;
            this.labelChooseNumberStock.Text = "Выберите номер акции:";
            // 
            // buttonInputStockProduct
            // 
            this.buttonInputStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputStockProduct.Location = new System.Drawing.Point(27, 124);
            this.buttonInputStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInputStockProduct.Name = "buttonInputStockProduct";
            this.buttonInputStockProduct.Size = new System.Drawing.Size(157, 48);
            this.buttonInputStockProduct.TabIndex = 4;
            this.buttonInputStockProduct.Text = "Добавить";
            this.buttonInputStockProduct.UseVisualStyleBackColor = true;
            this.buttonInputStockProduct.Click += new System.EventHandler(this.buttonInputStockProduct_Click);
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.numericUpDownPriceEdit);
            this.tabPageEdit.Controls.Add(this.labelPriceEdit);
            this.tabPageEdit.Controls.Add(this.dataGridViewEditStockProduct);
            this.tabPageEdit.Controls.Add(this.buttonEditStockProduct);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(871, 465);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditStockProduct
            // 
            this.dataGridViewEditStockProduct.AllowUserToAddRows = false;
            this.dataGridViewEditStockProduct.AllowUserToDeleteRows = false;
            this.dataGridViewEditStockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditStockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditStockProduct.Location = new System.Drawing.Point(27, 50);
            this.dataGridViewEditStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEditStockProduct.MultiSelect = false;
            this.dataGridViewEditStockProduct.Name = "dataGridViewEditStockProduct";
            this.dataGridViewEditStockProduct.ReadOnly = true;
            this.dataGridViewEditStockProduct.RowHeadersWidth = 51;
            this.dataGridViewEditStockProduct.RowTemplate.Height = 24;
            this.dataGridViewEditStockProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditStockProduct.Size = new System.Drawing.Size(801, 249);
            this.dataGridViewEditStockProduct.TabIndex = 10;
            // 
            // buttonEditStockProduct
            // 
            this.buttonEditStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditStockProduct.Location = new System.Drawing.Point(27, 316);
            this.buttonEditStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditStockProduct.Name = "buttonEditStockProduct";
            this.buttonEditStockProduct.Size = new System.Drawing.Size(157, 48);
            this.buttonEditStockProduct.TabIndex = 5;
            this.buttonEditStockProduct.Text = "Изменить";
            this.buttonEditStockProduct.UseVisualStyleBackColor = true;
            this.buttonEditStockProduct.Click += new System.EventHandler(this.buttonEditStockProduct_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelInfoDelete);
            this.tabPageDelete.Controls.Add(this.buttonDeleteStockProduct);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteStockProduct);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(871, 465);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteStockProduct
            // 
            this.buttonDeleteStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStockProduct.Location = new System.Drawing.Point(15, 363);
            this.buttonDeleteStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteStockProduct.Name = "buttonDeleteStockProduct";
            this.buttonDeleteStockProduct.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteStockProduct.TabIndex = 12;
            this.buttonDeleteStockProduct.Text = "Удалить";
            this.buttonDeleteStockProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteStockProduct.Click += new System.EventHandler(this.buttonDeleteStockProduct_Click);
            // 
            // dataGridViewDeleteStockProduct
            // 
            this.dataGridViewDeleteStockProduct.AllowUserToAddRows = false;
            this.dataGridViewDeleteStockProduct.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteStockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteStockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteStockProduct.Location = new System.Drawing.Point(15, 38);
            this.dataGridViewDeleteStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeleteStockProduct.MultiSelect = false;
            this.dataGridViewDeleteStockProduct.Name = "dataGridViewDeleteStockProduct";
            this.dataGridViewDeleteStockProduct.ReadOnly = true;
            this.dataGridViewDeleteStockProduct.RowHeadersWidth = 51;
            this.dataGridViewDeleteStockProduct.RowTemplate.Height = 24;
            this.dataGridViewDeleteStockProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteStockProduct.Size = new System.Drawing.Size(801, 310);
            this.dataGridViewDeleteStockProduct.TabIndex = 11;
            // 
            // numericUpDownPriceEdit
            // 
            this.numericUpDownPriceEdit.DecimalPlaces = 2;
            this.numericUpDownPriceEdit.Location = new System.Drawing.Point(148, 14);
            this.numericUpDownPriceEdit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPriceEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriceEdit.Name = "numericUpDownPriceEdit";
            this.numericUpDownPriceEdit.Size = new System.Drawing.Size(367, 22);
            this.numericUpDownPriceEdit.TabIndex = 12;
            this.numericUpDownPriceEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPriceEdit
            // 
            this.labelPriceEdit.AutoSize = true;
            this.labelPriceEdit.Location = new System.Drawing.Point(24, 14);
            this.labelPriceEdit.Name = "labelPriceEdit";
            this.labelPriceEdit.Size = new System.Drawing.Size(102, 17);
            this.labelPriceEdit.TabIndex = 11;
            this.labelPriceEdit.Text = "Введите цену:";
            // 
            // labelInfoDelete
            // 
            this.labelInfoDelete.AutoSize = true;
            this.labelInfoDelete.Location = new System.Drawing.Point(12, 19);
            this.labelInfoDelete.Name = "labelInfoDelete";
            this.labelInfoDelete.Size = new System.Drawing.Size(398, 17);
            this.labelInfoDelete.TabIndex = 13;
            this.labelInfoDelete.Text = "Выберите необходимую позицию ниже и нажмите удалить:";
            // 
            // FormStockProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 494);
            this.Controls.Add(this.tabControlStockProduct);
            this.Name = "FormStockProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStockProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlStockProduct.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStockProduct)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceAdd)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditStockProduct)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteStockProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStockProduct;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowStockProduct;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonInputStockProduct;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditStockProduct;
        private System.Windows.Forms.Button buttonEditStockProduct;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonDeleteStockProduct;
        private System.Windows.Forms.DataGridView dataGridViewDeleteStockProduct;
        private System.Windows.Forms.Label labelChooseProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelChooseNumberStock;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseProductAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseStockNumberAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceEdit;
        private System.Windows.Forms.Label labelPriceEdit;
        private System.Windows.Forms.Label labelInfoDelete;
    }
}