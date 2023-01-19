
namespace Country
{
    partial class FormBigCity
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
            this.tabControlBigCity = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowBigCity = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCity = new System.Windows.Forms.ComboBox();
            this.labelChooseCity = new System.Windows.Forms.Label();
            this.buttonInputBigCity = new System.Windows.Forms.Button();
            this.textBoxBigCityBudgetAdd = new System.Windows.Forms.TextBox();
            this.labelBigCityBudgetAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditBigCity = new System.Windows.Forms.DataGridView();
            this.textBoxBigCityBudgetEdit = new System.Windows.Forms.TextBox();
            this.labelBigCityBudgetEdit = new System.Windows.Forms.Label();
            this.buttonEditBigCity = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteBigCity = new System.Windows.Forms.Label();
            this.buttonDeleteBigCity = new System.Windows.Forms.Button();
            this.dataGridViewDeleteBigCity = new System.Windows.Forms.DataGridView();
            this.tabControlBigCity.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBigCity)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBigCity)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteBigCity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBigCity
            // 
            this.tabControlBigCity.Controls.Add(this.tabPageShow);
            this.tabControlBigCity.Controls.Add(this.tabPageAdd);
            this.tabControlBigCity.Controls.Add(this.tabPageEdit);
            this.tabControlBigCity.Controls.Add(this.tabPageDelete);
            this.tabControlBigCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBigCity.Location = new System.Drawing.Point(0, 0);
            this.tabControlBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlBigCity.Name = "tabControlBigCity";
            this.tabControlBigCity.SelectedIndex = 0;
            this.tabControlBigCity.Size = new System.Drawing.Size(864, 500);
            this.tabControlBigCity.TabIndex = 3;
            this.tabControlBigCity.SelectedIndexChanged += new System.EventHandler(this.tabControlBigCity_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowBigCity);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Size = new System.Drawing.Size(856, 471);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowBigCity
            // 
            this.dataGridViewShowBigCity.AllowUserToAddRows = false;
            this.dataGridViewShowBigCity.AllowUserToDeleteRows = false;
            this.dataGridViewShowBigCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowBigCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowBigCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowBigCity.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewShowBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowBigCity.MultiSelect = false;
            this.dataGridViewShowBigCity.Name = "dataGridViewShowBigCity";
            this.dataGridViewShowBigCity.ReadOnly = true;
            this.dataGridViewShowBigCity.RowHeadersWidth = 51;
            this.dataGridViewShowBigCity.RowTemplate.Height = 24;
            this.dataGridViewShowBigCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowBigCity.Size = new System.Drawing.Size(850, 467);
            this.dataGridViewShowBigCity.TabIndex = 0;
            this.dataGridViewShowBigCity.SelectionChanged += new System.EventHandler(this.dataGridViewShowBigCity_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.comboBoxChooseCity);
            this.tabPageAdd.Controls.Add(this.labelChooseCity);
            this.tabPageAdd.Controls.Add(this.buttonInputBigCity);
            this.tabPageAdd.Controls.Add(this.textBoxBigCityBudgetAdd);
            this.tabPageAdd.Controls.Add(this.labelBigCityBudgetAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(856, 471);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseCity
            // 
            this.comboBoxChooseCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxChooseCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCity.FormattingEnabled = true;
            this.comboBoxChooseCity.Location = new System.Drawing.Point(181, 19);
            this.comboBoxChooseCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChooseCity.Name = "comboBoxChooseCity";
            this.comboBoxChooseCity.Size = new System.Drawing.Size(330, 24);
            this.comboBoxChooseCity.TabIndex = 6;
            // 
            // labelChooseCity
            // 
            this.labelChooseCity.AutoSize = true;
            this.labelChooseCity.Location = new System.Drawing.Point(20, 19);
            this.labelChooseCity.Name = "labelChooseCity";
            this.labelChooseCity.Size = new System.Drawing.Size(119, 17);
            this.labelChooseCity.TabIndex = 5;
            this.labelChooseCity.Text = "Выберите город:";
            // 
            // buttonInputBigCity
            // 
            this.buttonInputBigCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputBigCity.Location = new System.Drawing.Point(23, 102);
            this.buttonInputBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInputBigCity.Name = "buttonInputBigCity";
            this.buttonInputBigCity.Size = new System.Drawing.Size(157, 53);
            this.buttonInputBigCity.TabIndex = 4;
            this.buttonInputBigCity.Text = "Добавить";
            this.buttonInputBigCity.UseVisualStyleBackColor = true;
            this.buttonInputBigCity.Click += new System.EventHandler(this.buttonInputBigCity_Click);
            // 
            // textBoxBigCityBudgetAdd
            // 
            this.textBoxBigCityBudgetAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBigCityBudgetAdd.Location = new System.Drawing.Point(181, 59);
            this.textBoxBigCityBudgetAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBigCityBudgetAdd.Name = "textBoxBigCityBudgetAdd";
            this.textBoxBigCityBudgetAdd.Size = new System.Drawing.Size(330, 22);
            this.textBoxBigCityBudgetAdd.TabIndex = 2;
            // 
            // labelBigCityBudgetAdd
            // 
            this.labelBigCityBudgetAdd.AutoSize = true;
            this.labelBigCityBudgetAdd.Location = new System.Drawing.Point(20, 64);
            this.labelBigCityBudgetAdd.Name = "labelBigCityBudgetAdd";
            this.labelBigCityBudgetAdd.Size = new System.Drawing.Size(121, 17);
            this.labelBigCityBudgetAdd.TabIndex = 0;
            this.labelBigCityBudgetAdd.Text = "Введите бюджет:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.dataGridViewEditBigCity);
            this.tabPageEdit.Controls.Add(this.textBoxBigCityBudgetEdit);
            this.tabPageEdit.Controls.Add(this.labelBigCityBudgetEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditBigCity);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(856, 471);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditBigCity
            // 
            this.dataGridViewEditBigCity.AllowUserToAddRows = false;
            this.dataGridViewEditBigCity.AllowUserToDeleteRows = false;
            this.dataGridViewEditBigCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEditBigCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditBigCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditBigCity.Location = new System.Drawing.Point(32, 115);
            this.dataGridViewEditBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEditBigCity.MultiSelect = false;
            this.dataGridViewEditBigCity.Name = "dataGridViewEditBigCity";
            this.dataGridViewEditBigCity.ReadOnly = true;
            this.dataGridViewEditBigCity.RowHeadersWidth = 51;
            this.dataGridViewEditBigCity.RowTemplate.Height = 24;
            this.dataGridViewEditBigCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditBigCity.Size = new System.Drawing.Size(595, 279);
            this.dataGridViewEditBigCity.TabIndex = 10;
            this.dataGridViewEditBigCity.SelectionChanged += new System.EventHandler(this.dataGridViewShowBigCity_SelectionChanged);
            // 
            // textBoxBigCityBudgetEdit
            // 
            this.textBoxBigCityBudgetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBigCityBudgetEdit.Location = new System.Drawing.Point(309, 14);
            this.textBoxBigCityBudgetEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBigCityBudgetEdit.Name = "textBoxBigCityBudgetEdit";
            this.textBoxBigCityBudgetEdit.Size = new System.Drawing.Size(312, 22);
            this.textBoxBigCityBudgetEdit.TabIndex = 9;
            // 
            // labelBigCityBudgetEdit
            // 
            this.labelBigCityBudgetEdit.AutoSize = true;
            this.labelBigCityBudgetEdit.Location = new System.Drawing.Point(29, 17);
            this.labelBigCityBudgetEdit.Name = "labelBigCityBudgetEdit";
            this.labelBigCityBudgetEdit.Size = new System.Drawing.Size(239, 17);
            this.labelBigCityBudgetEdit.TabIndex = 7;
            this.labelBigCityBudgetEdit.Text = "Введите новое значение бюджета:";
            // 
            // buttonEditBigCity
            // 
            this.buttonEditBigCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditBigCity.Location = new System.Drawing.Point(32, 50);
            this.buttonEditBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditBigCity.Name = "buttonEditBigCity";
            this.buttonEditBigCity.Size = new System.Drawing.Size(157, 48);
            this.buttonEditBigCity.TabIndex = 5;
            this.buttonEditBigCity.Text = "Изменить";
            this.buttonEditBigCity.UseVisualStyleBackColor = true;
            this.buttonEditBigCity.Click += new System.EventHandler(this.buttonEditBigCity_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteBigCity);
            this.tabPageDelete.Controls.Add(this.buttonDeleteBigCity);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteBigCity);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(856, 471);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteBigCity
            // 
            this.labelDeleteBigCity.AutoSize = true;
            this.labelDeleteBigCity.Location = new System.Drawing.Point(11, 17);
            this.labelDeleteBigCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteBigCity.Name = "labelDeleteBigCity";
            this.labelDeleteBigCity.Size = new System.Drawing.Size(382, 17);
            this.labelDeleteBigCity.TabIndex = 13;
            this.labelDeleteBigCity.Text = "Выберите город из списка и нажмите на кнопку удалить";
            // 
            // buttonDeleteBigCity
            // 
            this.buttonDeleteBigCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBigCity.Location = new System.Drawing.Point(15, 374);
            this.buttonDeleteBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteBigCity.Name = "buttonDeleteBigCity";
            this.buttonDeleteBigCity.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteBigCity.TabIndex = 12;
            this.buttonDeleteBigCity.Text = "Удалить";
            this.buttonDeleteBigCity.UseVisualStyleBackColor = true;
            this.buttonDeleteBigCity.Click += new System.EventHandler(this.buttonDeleteBigCity_Click);
            // 
            // dataGridViewDeleteBigCity
            // 
            this.dataGridViewDeleteBigCity.AllowUserToAddRows = false;
            this.dataGridViewDeleteBigCity.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteBigCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeleteBigCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteBigCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteBigCity.Location = new System.Drawing.Point(15, 47);
            this.dataGridViewDeleteBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeleteBigCity.MultiSelect = false;
            this.dataGridViewDeleteBigCity.Name = "dataGridViewDeleteBigCity";
            this.dataGridViewDeleteBigCity.ReadOnly = true;
            this.dataGridViewDeleteBigCity.RowHeadersWidth = 51;
            this.dataGridViewDeleteBigCity.RowTemplate.Height = 24;
            this.dataGridViewDeleteBigCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteBigCity.Size = new System.Drawing.Size(797, 310);
            this.dataGridViewDeleteBigCity.TabIndex = 11;
            this.dataGridViewDeleteBigCity.SelectionChanged += new System.EventHandler(this.dataGridViewShowBigCity_SelectionChanged);
            // 
            // FormBigCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 500);
            this.Controls.Add(this.tabControlBigCity);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBigCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крупные города";
            this.tabControlBigCity.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBigCity)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBigCity)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteBigCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBigCity;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowBigCity;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseCity;
        private System.Windows.Forms.Label labelChooseCity;
        private System.Windows.Forms.Button buttonInputBigCity;
        private System.Windows.Forms.TextBox textBoxBigCityBudgetAdd;
        private System.Windows.Forms.Label labelBigCityBudgetAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditBigCity;
        private System.Windows.Forms.TextBox textBoxBigCityBudgetEdit;
        private System.Windows.Forms.Label labelBigCityBudgetEdit;
        private System.Windows.Forms.Button buttonEditBigCity;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label labelDeleteBigCity;
        private System.Windows.Forms.Button buttonDeleteBigCity;
        private System.Windows.Forms.DataGridView dataGridViewDeleteBigCity;
    }
}