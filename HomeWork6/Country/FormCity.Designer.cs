﻿namespace Country
{
    partial class FormCity
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
            this.tabControlCity = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowCity = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCountry = new System.Windows.Forms.ComboBox();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.buttonInputCity = new System.Windows.Forms.Button();
            this.textBoxCityCountPeopleAdd = new System.Windows.Forms.TextBox();
            this.textBoxCityNameAdd = new System.Windows.Forms.TextBox();
            this.labelCityAreaAdd = new System.Windows.Forms.Label();
            this.labelCityNameAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChooseEditCountry = new System.Windows.Forms.ComboBox();
            this.dataGridViewEditCity = new System.Windows.Forms.DataGridView();
            this.textBoxCityCountPeopleEdit = new System.Windows.Forms.TextBox();
            this.textBoxCityNameEdit = new System.Windows.Forms.TextBox();
            this.labelCityCountPeopleEdit = new System.Windows.Forms.Label();
            this.labelCityNameEdit = new System.Windows.Forms.Label();
            this.buttonEditCity = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteCity = new System.Windows.Forms.Label();
            this.buttonDeleteCity = new System.Windows.Forms.Button();
            this.dataGridViewDeleteCity = new System.Windows.Forms.DataGridView();
            this.tabControlCity.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCity)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCity)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCity
            // 
            this.tabControlCity.Controls.Add(this.tabPageShow);
            this.tabControlCity.Controls.Add(this.tabPageAdd);
            this.tabControlCity.Controls.Add(this.tabPageEdit);
            this.tabControlCity.Controls.Add(this.tabPageDelete);
            this.tabControlCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCity.Location = new System.Drawing.Point(0, 0);
            this.tabControlCity.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlCity.Name = "tabControlCity";
            this.tabControlCity.SelectedIndex = 0;
            this.tabControlCity.Size = new System.Drawing.Size(648, 406);
            this.tabControlCity.TabIndex = 1;
            this.tabControlCity.SelectedIndexChanged += new System.EventHandler(this.tabControlCity_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowCity);
            this.tabPageShow.Location = new System.Drawing.Point(4, 22);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageShow.Size = new System.Drawing.Size(640, 380);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowCity
            // 
            this.dataGridViewShowCity.AllowUserToAddRows = false;
            this.dataGridViewShowCity.AllowUserToDeleteRows = false;
            this.dataGridViewShowCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowCity.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewShowCity.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShowCity.MultiSelect = false;
            this.dataGridViewShowCity.Name = "dataGridViewShowCity";
            this.dataGridViewShowCity.ReadOnly = true;
            this.dataGridViewShowCity.RowHeadersWidth = 51;
            this.dataGridViewShowCity.RowTemplate.Height = 24;
            this.dataGridViewShowCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowCity.Size = new System.Drawing.Size(636, 376);
            this.dataGridViewShowCity.TabIndex = 0;
            this.dataGridViewShowCity.SelectionChanged += new System.EventHandler(this.dataGridViewShowCity_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.comboBoxChooseCountry);
            this.tabPageAdd.Controls.Add(this.labelChooseCountry);
            this.tabPageAdd.Controls.Add(this.buttonInputCity);
            this.tabPageAdd.Controls.Add(this.textBoxCityCountPeopleAdd);
            this.tabPageAdd.Controls.Add(this.textBoxCityNameAdd);
            this.tabPageAdd.Controls.Add(this.labelCityAreaAdd);
            this.tabPageAdd.Controls.Add(this.labelCityNameAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Size = new System.Drawing.Size(640, 380);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseCountry
            // 
            this.comboBoxChooseCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Location = new System.Drawing.Point(136, 83);
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            this.comboBoxChooseCountry.Size = new System.Drawing.Size(224, 21);
            this.comboBoxChooseCountry.TabIndex = 6;
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(14, 86);
            this.labelChooseCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(97, 13);
            this.labelChooseCountry.TabIndex = 5;
            this.labelChooseCountry.Text = "Выберите страну:";
            // 
            // buttonInputCity
            // 
            this.buttonInputCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputCity.Location = new System.Drawing.Point(17, 120);
            this.buttonInputCity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInputCity.Name = "buttonInputCity";
            this.buttonInputCity.Size = new System.Drawing.Size(118, 39);
            this.buttonInputCity.TabIndex = 4;
            this.buttonInputCity.Text = "Добавить";
            this.buttonInputCity.UseVisualStyleBackColor = true;
            this.buttonInputCity.Click += new System.EventHandler(this.buttonInputCountry_Click);
            // 
            // textBoxCityCountPeopleAdd
            // 
            this.textBoxCityCountPeopleAdd.Location = new System.Drawing.Point(195, 46);
            this.textBoxCityCountPeopleAdd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCityCountPeopleAdd.Name = "textBoxCityCountPeopleAdd";
            this.textBoxCityCountPeopleAdd.Size = new System.Drawing.Size(165, 20);
            this.textBoxCityCountPeopleAdd.TabIndex = 3;
            // 
            // textBoxCityNameAdd
            // 
            this.textBoxCityNameAdd.Location = new System.Drawing.Point(195, 13);
            this.textBoxCityNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCityNameAdd.Name = "textBoxCityNameAdd";
            this.textBoxCityNameAdd.Size = new System.Drawing.Size(165, 20);
            this.textBoxCityNameAdd.TabIndex = 2;
            // 
            // labelCityAreaAdd
            // 
            this.labelCityAreaAdd.AutoSize = true;
            this.labelCityAreaAdd.Location = new System.Drawing.Point(14, 49);
            this.labelCityAreaAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityAreaAdd.Name = "labelCityAreaAdd";
            this.labelCityAreaAdd.Size = new System.Drawing.Size(176, 13);
            this.labelCityAreaAdd.TabIndex = 1;
            this.labelCityAreaAdd.Text = "Введите численность населения:";
            // 
            // labelCityNameAdd
            // 
            this.labelCityNameAdd.AutoSize = true;
            this.labelCityNameAdd.Location = new System.Drawing.Point(14, 15);
            this.labelCityNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityNameAdd.Name = "labelCityNameAdd";
            this.labelCityNameAdd.Size = new System.Drawing.Size(141, 13);
            this.labelCityNameAdd.TabIndex = 0;
            this.labelCityNameAdd.Text = "Введите название города:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.label1);
            this.tabPageEdit.Controls.Add(this.comboBoxChooseEditCountry);
            this.tabPageEdit.Controls.Add(this.dataGridViewEditCity);
            this.tabPageEdit.Controls.Add(this.textBoxCityCountPeopleEdit);
            this.tabPageEdit.Controls.Add(this.textBoxCityNameEdit);
            this.tabPageEdit.Controls.Add(this.labelCityCountPeopleEdit);
            this.tabPageEdit.Controls.Add(this.labelCityNameEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditCity);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(640, 380);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите страну:";
            // 
            // comboBoxChooseEditCountry
            // 
            this.comboBoxChooseEditCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseEditCountry.FormattingEnabled = true;
            this.comboBoxChooseEditCountry.Location = new System.Drawing.Point(120, 84);
            this.comboBoxChooseEditCountry.Name = "comboBoxChooseEditCountry";
            this.comboBoxChooseEditCountry.Size = new System.Drawing.Size(350, 21);
            this.comboBoxChooseEditCountry.TabIndex = 11;
            // 
            // dataGridViewEditCity
            // 
            this.dataGridViewEditCity.AllowUserToAddRows = false;
            this.dataGridViewEditCity.AllowUserToDeleteRows = false;
            this.dataGridViewEditCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditCity.Location = new System.Drawing.Point(20, 134);
            this.dataGridViewEditCity.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEditCity.MultiSelect = false;
            this.dataGridViewEditCity.Name = "dataGridViewEditCity";
            this.dataGridViewEditCity.ReadOnly = true;
            this.dataGridViewEditCity.RowHeadersWidth = 51;
            this.dataGridViewEditCity.RowTemplate.Height = 24;
            this.dataGridViewEditCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditCity.Size = new System.Drawing.Size(601, 227);
            this.dataGridViewEditCity.TabIndex = 10;
            // 
            // textBoxCityCountPeopleEdit
            // 
            this.textBoxCityCountPeopleEdit.Location = new System.Drawing.Point(232, 44);
            this.textBoxCityCountPeopleEdit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCityCountPeopleEdit.Name = "textBoxCityCountPeopleEdit";
            this.textBoxCityCountPeopleEdit.Size = new System.Drawing.Size(238, 20);
            this.textBoxCityCountPeopleEdit.TabIndex = 9;
            // 
            // textBoxCityNameEdit
            // 
            this.textBoxCityNameEdit.Location = new System.Drawing.Point(232, 10);
            this.textBoxCityNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCityNameEdit.Name = "textBoxCityNameEdit";
            this.textBoxCityNameEdit.Size = new System.Drawing.Size(238, 20);
            this.textBoxCityNameEdit.TabIndex = 8;
            // 
            // labelCityCountPeopleEdit
            // 
            this.labelCityCountPeopleEdit.AutoSize = true;
            this.labelCityCountPeopleEdit.Location = new System.Drawing.Point(18, 47);
            this.labelCityCountPeopleEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityCountPeopleEdit.Name = "labelCityCountPeopleEdit";
            this.labelCityCountPeopleEdit.Size = new System.Drawing.Size(210, 13);
            this.labelCityCountPeopleEdit.TabIndex = 7;
            this.labelCityCountPeopleEdit.Text = "Введите новую численность населения:";
            // 
            // labelCityNameEdit
            // 
            this.labelCityNameEdit.AutoSize = true;
            this.labelCityNameEdit.Location = new System.Drawing.Point(17, 13);
            this.labelCityNameEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityNameEdit.Name = "labelCityNameEdit";
            this.labelCityNameEdit.Size = new System.Drawing.Size(174, 13);
            this.labelCityNameEdit.TabIndex = 6;
            this.labelCityNameEdit.Text = "Введите новое название города:";
            // 
            // buttonEditCity
            // 
            this.buttonEditCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCity.Location = new System.Drawing.Point(503, 33);
            this.buttonEditCity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditCity.Name = "buttonEditCity";
            this.buttonEditCity.Size = new System.Drawing.Size(118, 39);
            this.buttonEditCity.TabIndex = 5;
            this.buttonEditCity.Text = "Изменить";
            this.buttonEditCity.UseVisualStyleBackColor = true;
            this.buttonEditCity.Click += new System.EventHandler(this.buttonEditCity_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteCity);
            this.tabPageDelete.Controls.Add(this.buttonDeleteCity);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteCity);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(640, 380);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteCity
            // 
            this.labelDeleteCity.AutoSize = true;
            this.labelDeleteCity.Location = new System.Drawing.Point(8, 14);
            this.labelDeleteCity.Name = "labelDeleteCity";
            this.labelDeleteCity.Size = new System.Drawing.Size(296, 13);
            this.labelDeleteCity.TabIndex = 13;
            this.labelDeleteCity.Text = "Выберите город из списка и нажмите на кнопку удалить";
            // 
            // buttonDeleteCity
            // 
            this.buttonDeleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCity.Location = new System.Drawing.Point(11, 304);
            this.buttonDeleteCity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteCity.Name = "buttonDeleteCity";
            this.buttonDeleteCity.Size = new System.Drawing.Size(118, 47);
            this.buttonDeleteCity.TabIndex = 12;
            this.buttonDeleteCity.Text = "Удалить";
            this.buttonDeleteCity.UseVisualStyleBackColor = true;
            this.buttonDeleteCity.Click += new System.EventHandler(this.buttonDeleteCountry_Click);
            // 
            // dataGridViewDeleteCity
            // 
            this.dataGridViewDeleteCity.AllowUserToAddRows = false;
            this.dataGridViewDeleteCity.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteCity.Location = new System.Drawing.Point(11, 38);
            this.dataGridViewDeleteCity.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeleteCity.MultiSelect = false;
            this.dataGridViewDeleteCity.Name = "dataGridViewDeleteCity";
            this.dataGridViewDeleteCity.ReadOnly = true;
            this.dataGridViewDeleteCity.RowHeadersWidth = 51;
            this.dataGridViewDeleteCity.RowTemplate.Height = 24;
            this.dataGridViewDeleteCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteCity.Size = new System.Drawing.Size(601, 252);
            this.dataGridViewDeleteCity.TabIndex = 11;
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 406);
            this.Controls.Add(this.tabControlCity);
            this.Name = "FormCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Города";
            this.tabControlCity.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCity)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCity)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCity;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowCity;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonInputCity;
        private System.Windows.Forms.TextBox textBoxCityCountPeopleAdd;
        private System.Windows.Forms.TextBox textBoxCityNameAdd;
        private System.Windows.Forms.Label labelCityAreaAdd;
        private System.Windows.Forms.Label labelCityNameAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditCity;
        private System.Windows.Forms.TextBox textBoxCityCountPeopleEdit;
        private System.Windows.Forms.TextBox textBoxCityNameEdit;
        private System.Windows.Forms.Label labelCityCountPeopleEdit;
        private System.Windows.Forms.Label labelCityNameEdit;
        private System.Windows.Forms.Button buttonEditCity;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label labelDeleteCity;
        private System.Windows.Forms.Button buttonDeleteCity;
        private System.Windows.Forms.DataGridView dataGridViewDeleteCity;
        private System.Windows.Forms.ComboBox comboBoxChooseCountry;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChooseEditCountry;
    }
}