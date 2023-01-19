﻿
namespace Country
{
    partial class FormCountry
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
            this.tabControlCountry = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowCountry = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.buttonInputCountry = new System.Windows.Forms.Button();
            this.textBoxCountryAreaAdd = new System.Windows.Forms.TextBox();
            this.textBoxCountryNameAdd = new System.Windows.Forms.TextBox();
            this.labelCountryAreaAdd = new System.Windows.Forms.Label();
            this.labelCountryNameAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditCountry = new System.Windows.Forms.DataGridView();
            this.textBoxCountryAreaEdit = new System.Windows.Forms.TextBox();
            this.textBoxCountryNameEdit = new System.Windows.Forms.TextBox();
            this.labelCountryAreaEdit = new System.Windows.Forms.Label();
            this.labelCountryNameEdit = new System.Windows.Forms.Label();
            this.buttonEditCountry = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteCountry = new System.Windows.Forms.Label();
            this.buttonDeleteCountry = new System.Windows.Forms.Button();
            this.dataGridViewDeleteCountry = new System.Windows.Forms.DataGridView();
            this.tabControlCountry.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCountry)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCountry)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCountry
            // 
            this.tabControlCountry.Controls.Add(this.tabPageShow);
            this.tabControlCountry.Controls.Add(this.tabPageAdd);
            this.tabControlCountry.Controls.Add(this.tabPageEdit);
            this.tabControlCountry.Controls.Add(this.tabPageDelete);
            this.tabControlCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCountry.Location = new System.Drawing.Point(0, 0);
            this.tabControlCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCountry.Name = "tabControlCountry";
            this.tabControlCountry.SelectedIndex = 0;
            this.tabControlCountry.Size = new System.Drawing.Size(864, 500);
            this.tabControlCountry.TabIndex = 0;
            this.tabControlCountry.SelectedIndexChanged += new System.EventHandler(this.tabControlCountry_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowCountry);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Size = new System.Drawing.Size(856, 471);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowCountry
            // 
            this.dataGridViewShowCountry.AllowUserToAddRows = false;
            this.dataGridViewShowCountry.AllowUserToDeleteRows = false;
            this.dataGridViewShowCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowCountry.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewShowCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowCountry.MultiSelect = false;
            this.dataGridViewShowCountry.Name = "dataGridViewShowCountry";
            this.dataGridViewShowCountry.ReadOnly = true;
            this.dataGridViewShowCountry.RowHeadersWidth = 51;
            this.dataGridViewShowCountry.RowTemplate.Height = 24;
            this.dataGridViewShowCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowCountry.Size = new System.Drawing.Size(850, 467);
            this.dataGridViewShowCountry.TabIndex = 0;
            this.dataGridViewShowCountry.SelectionChanged += new System.EventHandler(this.dataGridViewShowCountry_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonInputCountry);
            this.tabPageAdd.Controls.Add(this.textBoxCountryAreaAdd);
            this.tabPageAdd.Controls.Add(this.textBoxCountryNameAdd);
            this.tabPageAdd.Controls.Add(this.labelCountryAreaAdd);
            this.tabPageAdd.Controls.Add(this.labelCountryNameAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdd.Size = new System.Drawing.Size(856, 471);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonInputCountry
            // 
            this.buttonInputCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputCountry.Location = new System.Drawing.Point(21, 94);
            this.buttonInputCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInputCountry.Name = "buttonInputCountry";
            this.buttonInputCountry.Size = new System.Drawing.Size(157, 48);
            this.buttonInputCountry.TabIndex = 4;
            this.buttonInputCountry.Text = "Добавить";
            this.buttonInputCountry.UseVisualStyleBackColor = true;
            this.buttonInputCountry.Click += new System.EventHandler(this.buttonInputCountry_Click);
            // 
            // textBoxCountryAreaAdd
            // 
            this.textBoxCountryAreaAdd.Location = new System.Drawing.Point(260, 57);
            this.textBoxCountryAreaAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCountryAreaAdd.Name = "textBoxCountryAreaAdd";
            this.textBoxCountryAreaAdd.Size = new System.Drawing.Size(155, 22);
            this.textBoxCountryAreaAdd.TabIndex = 3;
            // 
            // textBoxCountryNameAdd
            // 
            this.textBoxCountryNameAdd.Location = new System.Drawing.Point(260, 16);
            this.textBoxCountryNameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCountryNameAdd.Name = "textBoxCountryNameAdd";
            this.textBoxCountryNameAdd.Size = new System.Drawing.Size(155, 22);
            this.textBoxCountryNameAdd.TabIndex = 2;
            // 
            // labelCountryAreaAdd
            // 
            this.labelCountryAreaAdd.AutoSize = true;
            this.labelCountryAreaAdd.Location = new System.Drawing.Point(19, 60);
            this.labelCountryAreaAdd.Name = "labelCountryAreaAdd";
            this.labelCountryAreaAdd.Size = new System.Drawing.Size(222, 17);
            this.labelCountryAreaAdd.TabIndex = 1;
            this.labelCountryAreaAdd.Text = "Введите площадь (в кв. метрах):";
            // 
            // labelCountryNameAdd
            // 
            this.labelCountryNameAdd.AutoSize = true;
            this.labelCountryNameAdd.Location = new System.Drawing.Point(19, 18);
            this.labelCountryNameAdd.Name = "labelCountryNameAdd";
            this.labelCountryNameAdd.Size = new System.Drawing.Size(185, 17);
            this.labelCountryNameAdd.TabIndex = 0;
            this.labelCountryNameAdd.Text = "Введите название страны:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.dataGridViewEditCountry);
            this.tabPageEdit.Controls.Add(this.textBoxCountryAreaEdit);
            this.tabPageEdit.Controls.Add(this.textBoxCountryNameEdit);
            this.tabPageEdit.Controls.Add(this.labelCountryAreaEdit);
            this.tabPageEdit.Controls.Add(this.labelCountryNameEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditCountry);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(856, 471);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditCountry
            // 
            this.dataGridViewEditCountry.AllowUserToAddRows = false;
            this.dataGridViewEditCountry.AllowUserToDeleteRows = false;
            this.dataGridViewEditCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditCountry.Location = new System.Drawing.Point(27, 101);
            this.dataGridViewEditCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEditCountry.MultiSelect = false;
            this.dataGridViewEditCountry.Name = "dataGridViewEditCountry";
            this.dataGridViewEditCountry.ReadOnly = true;
            this.dataGridViewEditCountry.RowHeadersWidth = 51;
            this.dataGridViewEditCountry.RowTemplate.Height = 24;
            this.dataGridViewEditCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditCountry.Size = new System.Drawing.Size(801, 249);
            this.dataGridViewEditCountry.TabIndex = 10;
            this.dataGridViewEditCountry.SelectionChanged += new System.EventHandler(this.dataGridViewShowCountry_SelectionChanged);
            // 
            // textBoxCountryAreaEdit
            // 
            this.textBoxCountryAreaEdit.Location = new System.Drawing.Point(459, 54);
            this.textBoxCountryAreaEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCountryAreaEdit.Name = "textBoxCountryAreaEdit";
            this.textBoxCountryAreaEdit.Size = new System.Drawing.Size(368, 22);
            this.textBoxCountryAreaEdit.TabIndex = 9;
            // 
            // textBoxCountryNameEdit
            // 
            this.textBoxCountryNameEdit.Location = new System.Drawing.Point(309, 12);
            this.textBoxCountryNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCountryNameEdit.Name = "textBoxCountryNameEdit";
            this.textBoxCountryNameEdit.Size = new System.Drawing.Size(517, 22);
            this.textBoxCountryNameEdit.TabIndex = 8;
            // 
            // labelCountryAreaEdit
            // 
            this.labelCountryAreaEdit.AutoSize = true;
            this.labelCountryAreaEdit.Location = new System.Drawing.Point(24, 58);
            this.labelCountryAreaEdit.Name = "labelCountryAreaEdit";
            this.labelCountryAreaEdit.Size = new System.Drawing.Size(420, 17);
            this.labelCountryAreaEdit.TabIndex = 7;
            this.labelCountryAreaEdit.Text = "Введите новые данные по размеру территории (в кв. метрах):";
            // 
            // labelCountryNameEdit
            // 
            this.labelCountryNameEdit.AutoSize = true;
            this.labelCountryNameEdit.Location = new System.Drawing.Point(23, 16);
            this.labelCountryNameEdit.Name = "labelCountryNameEdit";
            this.labelCountryNameEdit.Size = new System.Drawing.Size(228, 17);
            this.labelCountryNameEdit.TabIndex = 6;
            this.labelCountryNameEdit.Text = "Введите новое название страны:";
            // 
            // buttonEditCountry
            // 
            this.buttonEditCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCountry.Location = new System.Drawing.Point(27, 368);
            this.buttonEditCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditCountry.Name = "buttonEditCountry";
            this.buttonEditCountry.Size = new System.Drawing.Size(157, 48);
            this.buttonEditCountry.TabIndex = 5;
            this.buttonEditCountry.Text = "Изменить";
            this.buttonEditCountry.UseVisualStyleBackColor = true;
            this.buttonEditCountry.Click += new System.EventHandler(this.buttonEditCountry_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteCountry);
            this.tabPageDelete.Controls.Add(this.buttonDeleteCountry);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteCountry);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(856, 471);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteCountry
            // 
            this.labelDeleteCountry.AutoSize = true;
            this.labelDeleteCountry.Location = new System.Drawing.Point(11, 17);
            this.labelDeleteCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteCountry.Name = "labelDeleteCountry";
            this.labelDeleteCountry.Size = new System.Drawing.Size(390, 17);
            this.labelDeleteCountry.TabIndex = 13;
            this.labelDeleteCountry.Text = "Выберите страну из списка и нажмите на кнопку удалить";
            // 
            // buttonDeleteCountry
            // 
            this.buttonDeleteCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCountry.Location = new System.Drawing.Point(15, 374);
            this.buttonDeleteCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCountry.Name = "buttonDeleteCountry";
            this.buttonDeleteCountry.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteCountry.TabIndex = 12;
            this.buttonDeleteCountry.Text = "Удалить";
            this.buttonDeleteCountry.UseVisualStyleBackColor = true;
            this.buttonDeleteCountry.Click += new System.EventHandler(this.buttonDeleteCountry_Click);
            // 
            // dataGridViewDeleteCountry
            // 
            this.dataGridViewDeleteCountry.AllowUserToAddRows = false;
            this.dataGridViewDeleteCountry.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteCountry.Location = new System.Drawing.Point(15, 47);
            this.dataGridViewDeleteCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeleteCountry.MultiSelect = false;
            this.dataGridViewDeleteCountry.Name = "dataGridViewDeleteCountry";
            this.dataGridViewDeleteCountry.ReadOnly = true;
            this.dataGridViewDeleteCountry.RowHeadersWidth = 51;
            this.dataGridViewDeleteCountry.RowTemplate.Height = 24;
            this.dataGridViewDeleteCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteCountry.Size = new System.Drawing.Size(801, 310);
            this.dataGridViewDeleteCountry.TabIndex = 11;
            this.dataGridViewDeleteCountry.SelectionChanged += new System.EventHandler(this.dataGridViewShowCountry_SelectionChanged);
            // 
            // FormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 500);
            this.Controls.Add(this.tabControlCountry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны";
            this.tabControlCountry.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCountry)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCountry)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCountry;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.DataGridView dataGridViewShowCountry;
        private System.Windows.Forms.TextBox textBoxCountryAreaAdd;
        private System.Windows.Forms.TextBox textBoxCountryNameAdd;
        private System.Windows.Forms.Label labelCountryAreaAdd;
        private System.Windows.Forms.Label labelCountryNameAdd;
        private System.Windows.Forms.Button buttonInputCountry;
        private System.Windows.Forms.TextBox textBoxCountryAreaEdit;
        private System.Windows.Forms.TextBox textBoxCountryNameEdit;
        private System.Windows.Forms.Label labelCountryAreaEdit;
        private System.Windows.Forms.Label labelCountryNameEdit;
        private System.Windows.Forms.Button buttonEditCountry;
        private System.Windows.Forms.DataGridView dataGridViewEditCountry;
        private System.Windows.Forms.Button buttonDeleteCountry;
        private System.Windows.Forms.DataGridView dataGridViewDeleteCountry;
        private System.Windows.Forms.Label labelDeleteCountry;
    }
}