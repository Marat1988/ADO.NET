
namespace MailingLists.Forms
{
    partial class FormBuyers
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
            this.tabControlBuyers = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowBuyers = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCityAdd = new System.Windows.Forms.ComboBox();
            this.labelCountryAdd = new System.Windows.Forms.Label();
            this.dateTimePickerBuyersDateBirthDayAdd = new System.Windows.Forms.DateTimePicker();
            this.buttonInputBuyers = new System.Windows.Forms.Button();
            this.textBoxBuyersNameAdd = new System.Windows.Forms.TextBox();
            this.labelBuyersDateBirthDayAdd = new System.Windows.Forms.Label();
            this.labelBuyersNameAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCityEdit = new System.Windows.Forms.ComboBox();
            this.labelChooseBuyersCityEdit = new System.Windows.Forms.Label();
            this.dateTimePickerBuyersDateBirthDayEdit = new System.Windows.Forms.DateTimePicker();
            this.labelBuyersDateBirthDayEdit = new System.Windows.Forms.Label();
            this.dataGridViewEditBuyers = new System.Windows.Forms.DataGridView();
            this.textBoxBuyersNameEdit = new System.Windows.Forms.TextBox();
            this.labelBuyersNameEdit = new System.Windows.Forms.Label();
            this.buttonEditBuyers = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteBuyers = new System.Windows.Forms.Label();
            this.buttonDeleteBuyers = new System.Windows.Forms.Button();
            this.dataGridViewDeleteBuyers = new System.Windows.Forms.DataGridView();
            this.tabControlBuyers.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBuyers)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBuyers)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteBuyers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBuyers
            // 
            this.tabControlBuyers.Controls.Add(this.tabPageShow);
            this.tabControlBuyers.Controls.Add(this.tabPageAdd);
            this.tabControlBuyers.Controls.Add(this.tabPageEdit);
            this.tabControlBuyers.Controls.Add(this.tabPageDelete);
            this.tabControlBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBuyers.Location = new System.Drawing.Point(0, 0);
            this.tabControlBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlBuyers.Name = "tabControlBuyers";
            this.tabControlBuyers.SelectedIndex = 0;
            this.tabControlBuyers.Size = new System.Drawing.Size(808, 505);
            this.tabControlBuyers.TabIndex = 2;
            this.tabControlBuyers.SelectedIndexChanged += new System.EventHandler(this.tabControlBuyers_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowBuyers);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Size = new System.Drawing.Size(800, 476);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowBuyers
            // 
            this.dataGridViewShowBuyers.AllowUserToAddRows = false;
            this.dataGridViewShowBuyers.AllowUserToDeleteRows = false;
            this.dataGridViewShowBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowBuyers.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewShowBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowBuyers.MultiSelect = false;
            this.dataGridViewShowBuyers.Name = "dataGridViewShowBuyers";
            this.dataGridViewShowBuyers.ReadOnly = true;
            this.dataGridViewShowBuyers.RowHeadersWidth = 51;
            this.dataGridViewShowBuyers.RowTemplate.Height = 24;
            this.dataGridViewShowBuyers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowBuyers.Size = new System.Drawing.Size(794, 472);
            this.dataGridViewShowBuyers.TabIndex = 0;
            this.dataGridViewShowBuyers.SelectionChanged += new System.EventHandler(this.dataGridViewShowBuyers_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.comboBoxChooseCityAdd);
            this.tabPageAdd.Controls.Add(this.labelCountryAdd);
            this.tabPageAdd.Controls.Add(this.dateTimePickerBuyersDateBirthDayAdd);
            this.tabPageAdd.Controls.Add(this.buttonInputBuyers);
            this.tabPageAdd.Controls.Add(this.textBoxBuyersNameAdd);
            this.tabPageAdd.Controls.Add(this.labelBuyersDateBirthDayAdd);
            this.tabPageAdd.Controls.Add(this.labelBuyersNameAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(800, 476);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseCityAdd
            // 
            this.comboBoxChooseCityAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCityAdd.FormattingEnabled = true;
            this.comboBoxChooseCityAdd.Location = new System.Drawing.Point(144, 94);
            this.comboBoxChooseCityAdd.Name = "comboBoxChooseCityAdd";
            this.comboBoxChooseCityAdd.Size = new System.Drawing.Size(282, 24);
            this.comboBoxChooseCityAdd.TabIndex = 7;
            // 
            // labelCountryAdd
            // 
            this.labelCountryAdd.AutoSize = true;
            this.labelCountryAdd.Location = new System.Drawing.Point(19, 97);
            this.labelCountryAdd.Name = "labelCountryAdd";
            this.labelCountryAdd.Size = new System.Drawing.Size(119, 17);
            this.labelCountryAdd.TabIndex = 6;
            this.labelCountryAdd.Text = "Выберите город:";
            // 
            // dateTimePickerBuyersDateBirthDayAdd
            // 
            this.dateTimePickerBuyersDateBirthDayAdd.Location = new System.Drawing.Point(195, 55);
            this.dateTimePickerBuyersDateBirthDayAdd.Name = "dateTimePickerBuyersDateBirthDayAdd";
            this.dateTimePickerBuyersDateBirthDayAdd.Size = new System.Drawing.Size(231, 22);
            this.dateTimePickerBuyersDateBirthDayAdd.TabIndex = 5;
            // 
            // buttonInputBuyers
            // 
            this.buttonInputBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputBuyers.Location = new System.Drawing.Point(22, 145);
            this.buttonInputBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInputBuyers.Name = "buttonInputBuyers";
            this.buttonInputBuyers.Size = new System.Drawing.Size(157, 48);
            this.buttonInputBuyers.TabIndex = 4;
            this.buttonInputBuyers.Text = "Добавить";
            this.buttonInputBuyers.UseVisualStyleBackColor = true;
            this.buttonInputBuyers.Click += new System.EventHandler(this.buttonInputBuyers_Click);
            // 
            // textBoxBuyersNameAdd
            // 
            this.textBoxBuyersNameAdd.Location = new System.Drawing.Point(211, 15);
            this.textBoxBuyersNameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuyersNameAdd.Name = "textBoxBuyersNameAdd";
            this.textBoxBuyersNameAdd.Size = new System.Drawing.Size(215, 22);
            this.textBoxBuyersNameAdd.TabIndex = 2;
            // 
            // labelBuyersDateBirthDayAdd
            // 
            this.labelBuyersDateBirthDayAdd.AutoSize = true;
            this.labelBuyersDateBirthDayAdd.Location = new System.Drawing.Point(19, 55);
            this.labelBuyersDateBirthDayAdd.Name = "labelBuyersDateBirthDayAdd";
            this.labelBuyersDateBirthDayAdd.Size = new System.Drawing.Size(170, 17);
            this.labelBuyersDateBirthDayAdd.TabIndex = 1;
            this.labelBuyersDateBirthDayAdd.Text = "Введите дату рождения:";
            // 
            // labelBuyersNameAdd
            // 
            this.labelBuyersNameAdd.AutoSize = true;
            this.labelBuyersNameAdd.Location = new System.Drawing.Point(19, 18);
            this.labelBuyersNameAdd.Name = "labelBuyersNameAdd";
            this.labelBuyersNameAdd.Size = new System.Drawing.Size(186, 17);
            this.labelBuyersNameAdd.TabIndex = 0;
            this.labelBuyersNameAdd.Text = "Введите ФИО покупателя:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.comboBoxChooseCityEdit);
            this.tabPageEdit.Controls.Add(this.labelChooseBuyersCityEdit);
            this.tabPageEdit.Controls.Add(this.dateTimePickerBuyersDateBirthDayEdit);
            this.tabPageEdit.Controls.Add(this.labelBuyersDateBirthDayEdit);
            this.tabPageEdit.Controls.Add(this.dataGridViewEditBuyers);
            this.tabPageEdit.Controls.Add(this.textBoxBuyersNameEdit);
            this.tabPageEdit.Controls.Add(this.labelBuyersNameEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditBuyers);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(800, 476);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseCityEdit
            // 
            this.comboBoxChooseCityEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCityEdit.FormattingEnabled = true;
            this.comboBoxChooseCityEdit.Location = new System.Drawing.Point(149, 91);
            this.comboBoxChooseCityEdit.Name = "comboBoxChooseCityEdit";
            this.comboBoxChooseCityEdit.Size = new System.Drawing.Size(318, 24);
            this.comboBoxChooseCityEdit.TabIndex = 14;
            // 
            // labelChooseBuyersCityEdit
            // 
            this.labelChooseBuyersCityEdit.AutoSize = true;
            this.labelChooseBuyersCityEdit.Location = new System.Drawing.Point(24, 94);
            this.labelChooseBuyersCityEdit.Name = "labelChooseBuyersCityEdit";
            this.labelChooseBuyersCityEdit.Size = new System.Drawing.Size(119, 17);
            this.labelChooseBuyersCityEdit.TabIndex = 13;
            this.labelChooseBuyersCityEdit.Text = "Выберите город:";
            // 
            // dateTimePickerBuyersDateBirthDayEdit
            // 
            this.dateTimePickerBuyersDateBirthDayEdit.Location = new System.Drawing.Point(200, 52);
            this.dateTimePickerBuyersDateBirthDayEdit.Name = "dateTimePickerBuyersDateBirthDayEdit";
            this.dateTimePickerBuyersDateBirthDayEdit.Size = new System.Drawing.Size(267, 22);
            this.dateTimePickerBuyersDateBirthDayEdit.TabIndex = 12;
            // 
            // labelBuyersDateBirthDayEdit
            // 
            this.labelBuyersDateBirthDayEdit.AutoSize = true;
            this.labelBuyersDateBirthDayEdit.Location = new System.Drawing.Point(24, 52);
            this.labelBuyersDateBirthDayEdit.Name = "labelBuyersDateBirthDayEdit";
            this.labelBuyersDateBirthDayEdit.Size = new System.Drawing.Size(170, 17);
            this.labelBuyersDateBirthDayEdit.TabIndex = 11;
            this.labelBuyersDateBirthDayEdit.Text = "Введите дату рождения:";
            // 
            // dataGridViewEditBuyers
            // 
            this.dataGridViewEditBuyers.AllowUserToAddRows = false;
            this.dataGridViewEditBuyers.AllowUserToDeleteRows = false;
            this.dataGridViewEditBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditBuyers.Location = new System.Drawing.Point(27, 133);
            this.dataGridViewEditBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEditBuyers.MultiSelect = false;
            this.dataGridViewEditBuyers.Name = "dataGridViewEditBuyers";
            this.dataGridViewEditBuyers.ReadOnly = true;
            this.dataGridViewEditBuyers.RowHeadersWidth = 51;
            this.dataGridViewEditBuyers.RowTemplate.Height = 24;
            this.dataGridViewEditBuyers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditBuyers.Size = new System.Drawing.Size(757, 249);
            this.dataGridViewEditBuyers.TabIndex = 10;
            this.dataGridViewEditBuyers.SelectionChanged += new System.EventHandler(this.dataGridViewShowBuyers_SelectionChanged);
            // 
            // textBoxBuyersNameEdit
            // 
            this.textBoxBuyersNameEdit.Location = new System.Drawing.Point(257, 16);
            this.textBoxBuyersNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuyersNameEdit.Name = "textBoxBuyersNameEdit";
            this.textBoxBuyersNameEdit.Size = new System.Drawing.Size(210, 22);
            this.textBoxBuyersNameEdit.TabIndex = 8;
            // 
            // labelBuyersNameEdit
            // 
            this.labelBuyersNameEdit.AutoSize = true;
            this.labelBuyersNameEdit.Location = new System.Drawing.Point(22, 19);
            this.labelBuyersNameEdit.Name = "labelBuyersNameEdit";
            this.labelBuyersNameEdit.Size = new System.Drawing.Size(229, 17);
            this.labelBuyersNameEdit.TabIndex = 6;
            this.labelBuyersNameEdit.Text = "Введите новое ФИО покупателя:";
            // 
            // buttonEditBuyers
            // 
            this.buttonEditBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditBuyers.Location = new System.Drawing.Point(27, 406);
            this.buttonEditBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditBuyers.Name = "buttonEditBuyers";
            this.buttonEditBuyers.Size = new System.Drawing.Size(157, 48);
            this.buttonEditBuyers.TabIndex = 5;
            this.buttonEditBuyers.Text = "Изменить";
            this.buttonEditBuyers.UseVisualStyleBackColor = true;
            this.buttonEditBuyers.Click += new System.EventHandler(this.buttonEditBuyers_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteBuyers);
            this.tabPageDelete.Controls.Add(this.buttonDeleteBuyers);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteBuyers);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(800, 476);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteBuyers
            // 
            this.labelDeleteBuyers.AutoSize = true;
            this.labelDeleteBuyers.Location = new System.Drawing.Point(12, 15);
            this.labelDeleteBuyers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteBuyers.Name = "labelDeleteBuyers";
            this.labelDeleteBuyers.Size = new System.Drawing.Size(422, 17);
            this.labelDeleteBuyers.TabIndex = 13;
            this.labelDeleteBuyers.Text = "Выберите покупателя из списка и нажмите на кнопку удалить";
            // 
            // buttonDeleteBuyers
            // 
            this.buttonDeleteBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBuyers.Location = new System.Drawing.Point(15, 374);
            this.buttonDeleteBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteBuyers.Name = "buttonDeleteBuyers";
            this.buttonDeleteBuyers.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteBuyers.TabIndex = 12;
            this.buttonDeleteBuyers.Text = "Удалить";
            this.buttonDeleteBuyers.UseVisualStyleBackColor = true;
            this.buttonDeleteBuyers.Click += new System.EventHandler(this.buttonDeleteBuyers_Click);
            // 
            // dataGridViewDeleteBuyers
            // 
            this.dataGridViewDeleteBuyers.AllowUserToAddRows = false;
            this.dataGridViewDeleteBuyers.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteBuyers.Location = new System.Drawing.Point(15, 47);
            this.dataGridViewDeleteBuyers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeleteBuyers.MultiSelect = false;
            this.dataGridViewDeleteBuyers.Name = "dataGridViewDeleteBuyers";
            this.dataGridViewDeleteBuyers.ReadOnly = true;
            this.dataGridViewDeleteBuyers.RowHeadersWidth = 51;
            this.dataGridViewDeleteBuyers.RowTemplate.Height = 24;
            this.dataGridViewDeleteBuyers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteBuyers.Size = new System.Drawing.Size(769, 310);
            this.dataGridViewDeleteBuyers.TabIndex = 11;
            this.dataGridViewDeleteBuyers.SelectionChanged += new System.EventHandler(this.dataGridViewShowBuyers_SelectionChanged);
            // 
            // FormBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 505);
            this.Controls.Add(this.tabControlBuyers);
            this.Name = "FormBuyers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuyers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlBuyers.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBuyers)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditBuyers)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteBuyers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBuyers;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowBuyers;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonInputBuyers;
        private System.Windows.Forms.TextBox textBoxBuyersNameAdd;
        private System.Windows.Forms.Label labelBuyersDateBirthDayAdd;
        private System.Windows.Forms.Label labelBuyersNameAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditBuyers;
        private System.Windows.Forms.TextBox textBoxBuyersNameEdit;
        private System.Windows.Forms.Label labelBuyersNameEdit;
        private System.Windows.Forms.Button buttonEditBuyers;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label labelDeleteBuyers;
        private System.Windows.Forms.Button buttonDeleteBuyers;
        private System.Windows.Forms.DataGridView dataGridViewDeleteBuyers;
        private System.Windows.Forms.ComboBox comboBoxChooseCityAdd;
        private System.Windows.Forms.Label labelCountryAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuyersDateBirthDayAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseCityEdit;
        private System.Windows.Forms.Label labelChooseBuyersCityEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuyersDateBirthDayEdit;
        private System.Windows.Forms.Label labelBuyersDateBirthDayEdit;
    }
}