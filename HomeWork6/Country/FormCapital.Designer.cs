
namespace Country
{
    partial class FormCapital
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
            this.tabControlCapital = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowCapital = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCity = new System.Windows.Forms.ComboBox();
            this.labelChooseCity = new System.Windows.Forms.Label();
            this.buttonInputCapital = new System.Windows.Forms.Button();
            this.textBoxCapitalAreaAdd = new System.Windows.Forms.TextBox();
            this.textBoxCapitalMayorAdd = new System.Windows.Forms.TextBox();
            this.labelCapitalAreaAdd = new System.Windows.Forms.Label();
            this.labelCapitalMayorAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditCapital = new System.Windows.Forms.DataGridView();
            this.textBoxCapitalAreaEdit = new System.Windows.Forms.TextBox();
            this.textBoxCapitalMayorEdit = new System.Windows.Forms.TextBox();
            this.labelCapitalAreaEdit = new System.Windows.Forms.Label();
            this.labelCapitalMayorEdit = new System.Windows.Forms.Label();
            this.buttonEditCapital = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteCity = new System.Windows.Forms.Label();
            this.buttonDeleteCapital = new System.Windows.Forms.Button();
            this.dataGridViewDeleteCapital = new System.Windows.Forms.DataGridView();
            this.tabControlCapital.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCapital)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCapital)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCapital
            // 
            this.tabControlCapital.Controls.Add(this.tabPageShow);
            this.tabControlCapital.Controls.Add(this.tabPageAdd);
            this.tabControlCapital.Controls.Add(this.tabPageEdit);
            this.tabControlCapital.Controls.Add(this.tabPageDelete);
            this.tabControlCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCapital.Location = new System.Drawing.Point(0, 0);
            this.tabControlCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCapital.Name = "tabControlCapital";
            this.tabControlCapital.SelectedIndex = 0;
            this.tabControlCapital.Size = new System.Drawing.Size(864, 500);
            this.tabControlCapital.TabIndex = 2;
            this.tabControlCapital.SelectedIndexChanged += new System.EventHandler(this.tabControlCapital_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowCapital);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageShow.Size = new System.Drawing.Size(856, 471);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowCapital
            // 
            this.dataGridViewShowCapital.AllowUserToAddRows = false;
            this.dataGridViewShowCapital.AllowUserToDeleteRows = false;
            this.dataGridViewShowCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowCapital.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewShowCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowCapital.MultiSelect = false;
            this.dataGridViewShowCapital.Name = "dataGridViewShowCapital";
            this.dataGridViewShowCapital.ReadOnly = true;
            this.dataGridViewShowCapital.RowHeadersWidth = 51;
            this.dataGridViewShowCapital.RowTemplate.Height = 24;
            this.dataGridViewShowCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowCapital.Size = new System.Drawing.Size(850, 467);
            this.dataGridViewShowCapital.TabIndex = 0;
            this.dataGridViewShowCapital.SelectionChanged += new System.EventHandler(this.dataGridViewShowCapital_SelectionChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.comboBoxChooseCity);
            this.tabPageAdd.Controls.Add(this.labelChooseCity);
            this.tabPageAdd.Controls.Add(this.buttonInputCapital);
            this.tabPageAdd.Controls.Add(this.textBoxCapitalAreaAdd);
            this.tabPageAdd.Controls.Add(this.textBoxCapitalMayorAdd);
            this.tabPageAdd.Controls.Add(this.labelCapitalAreaAdd);
            this.tabPageAdd.Controls.Add(this.labelCapitalMayorAdd);
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
            // buttonInputCapital
            // 
            this.buttonInputCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputCapital.Location = new System.Drawing.Point(23, 148);
            this.buttonInputCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInputCapital.Name = "buttonInputCapital";
            this.buttonInputCapital.Size = new System.Drawing.Size(157, 53);
            this.buttonInputCapital.TabIndex = 4;
            this.buttonInputCapital.Text = "Добавить";
            this.buttonInputCapital.UseVisualStyleBackColor = true;
            this.buttonInputCapital.Click += new System.EventHandler(this.buttonInputCapital_Click);
            // 
            // textBoxCapitalAreaAdd
            // 
            this.textBoxCapitalAreaAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCapitalAreaAdd.Location = new System.Drawing.Point(260, 95);
            this.textBoxCapitalAreaAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapitalAreaAdd.Name = "textBoxCapitalAreaAdd";
            this.textBoxCapitalAreaAdd.Size = new System.Drawing.Size(251, 22);
            this.textBoxCapitalAreaAdd.TabIndex = 3;
            // 
            // textBoxCapitalMayorAdd
            // 
            this.textBoxCapitalMayorAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCapitalMayorAdd.Location = new System.Drawing.Point(181, 59);
            this.textBoxCapitalMayorAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapitalMayorAdd.Name = "textBoxCapitalMayorAdd";
            this.textBoxCapitalMayorAdd.Size = new System.Drawing.Size(330, 22);
            this.textBoxCapitalMayorAdd.TabIndex = 2;
            // 
            // labelCapitalAreaAdd
            // 
            this.labelCapitalAreaAdd.AutoSize = true;
            this.labelCapitalAreaAdd.Location = new System.Drawing.Point(20, 100);
            this.labelCapitalAreaAdd.Name = "labelCapitalAreaAdd";
            this.labelCapitalAreaAdd.Size = new System.Drawing.Size(216, 17);
            this.labelCapitalAreaAdd.TabIndex = 1;
            this.labelCapitalAreaAdd.Text = "Введите площадь (в квадр. км.)";
            // 
            // labelCapitalMayorAdd
            // 
            this.labelCapitalMayorAdd.AutoSize = true;
            this.labelCapitalMayorAdd.Location = new System.Drawing.Point(20, 64);
            this.labelCapitalMayorAdd.Name = "labelCapitalMayorAdd";
            this.labelCapitalMayorAdd.Size = new System.Drawing.Size(141, 17);
            this.labelCapitalMayorAdd.TabIndex = 0;
            this.labelCapitalMayorAdd.Text = "Введите ФИО мэра:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.dataGridViewEditCapital);
            this.tabPageEdit.Controls.Add(this.textBoxCapitalAreaEdit);
            this.tabPageEdit.Controls.Add(this.textBoxCapitalMayorEdit);
            this.tabPageEdit.Controls.Add(this.labelCapitalAreaEdit);
            this.tabPageEdit.Controls.Add(this.labelCapitalMayorEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditCapital);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(856, 471);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditCapital
            // 
            this.dataGridViewEditCapital.AllowUserToAddRows = false;
            this.dataGridViewEditCapital.AllowUserToDeleteRows = false;
            this.dataGridViewEditCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEditCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditCapital.Location = new System.Drawing.Point(26, 164);
            this.dataGridViewEditCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEditCapital.MultiSelect = false;
            this.dataGridViewEditCapital.Name = "dataGridViewEditCapital";
            this.dataGridViewEditCapital.ReadOnly = true;
            this.dataGridViewEditCapital.RowHeadersWidth = 51;
            this.dataGridViewEditCapital.RowTemplate.Height = 24;
            this.dataGridViewEditCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditCapital.Size = new System.Drawing.Size(595, 279);
            this.dataGridViewEditCapital.TabIndex = 10;
            this.dataGridViewEditCapital.SelectionChanged += new System.EventHandler(this.dataGridViewShowCapital_SelectionChanged);
            // 
            // textBoxCapitalAreaEdit
            // 
            this.textBoxCapitalAreaEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCapitalAreaEdit.Location = new System.Drawing.Point(309, 53);
            this.textBoxCapitalAreaEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapitalAreaEdit.Name = "textBoxCapitalAreaEdit";
            this.textBoxCapitalAreaEdit.Size = new System.Drawing.Size(312, 22);
            this.textBoxCapitalAreaEdit.TabIndex = 9;
            // 
            // textBoxCapitalMayorEdit
            // 
            this.textBoxCapitalMayorEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCapitalMayorEdit.Location = new System.Drawing.Point(309, 12);
            this.textBoxCapitalMayorEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapitalMayorEdit.Name = "textBoxCapitalMayorEdit";
            this.textBoxCapitalMayorEdit.Size = new System.Drawing.Size(312, 22);
            this.textBoxCapitalMayorEdit.TabIndex = 8;
            // 
            // labelCapitalAreaEdit
            // 
            this.labelCapitalAreaEdit.AutoSize = true;
            this.labelCapitalAreaEdit.Location = new System.Drawing.Point(24, 58);
            this.labelCapitalAreaEdit.Name = "labelCapitalAreaEdit";
            this.labelCapitalAreaEdit.Size = new System.Drawing.Size(274, 17);
            this.labelCapitalAreaEdit.TabIndex = 7;
            this.labelCapitalAreaEdit.Text = "Введите новую численность населения:";
            // 
            // labelCapitalMayorEdit
            // 
            this.labelCapitalMayorEdit.AutoSize = true;
            this.labelCapitalMayorEdit.Location = new System.Drawing.Point(23, 16);
            this.labelCapitalMayorEdit.Name = "labelCapitalMayorEdit";
            this.labelCapitalMayorEdit.Size = new System.Drawing.Size(189, 17);
            this.labelCapitalMayorEdit.TabIndex = 6;
            this.labelCapitalMayorEdit.Text = "Введите ФИО нового мэра:";
            // 
            // buttonEditCapital
            // 
            this.buttonEditCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCapital.Location = new System.Drawing.Point(26, 98);
            this.buttonEditCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditCapital.Name = "buttonEditCapital";
            this.buttonEditCapital.Size = new System.Drawing.Size(157, 48);
            this.buttonEditCapital.TabIndex = 5;
            this.buttonEditCapital.Text = "Изменить";
            this.buttonEditCapital.UseVisualStyleBackColor = true;
            this.buttonEditCapital.Click += new System.EventHandler(this.buttonEditCapital_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteCity);
            this.tabPageDelete.Controls.Add(this.buttonDeleteCapital);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteCapital);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(856, 471);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteCity
            // 
            this.labelDeleteCity.AutoSize = true;
            this.labelDeleteCity.Location = new System.Drawing.Point(11, 17);
            this.labelDeleteCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteCity.Name = "labelDeleteCity";
            this.labelDeleteCity.Size = new System.Drawing.Size(382, 17);
            this.labelDeleteCity.TabIndex = 13;
            this.labelDeleteCity.Text = "Выберите город из списка и нажмите на кнопку удалить";
            // 
            // buttonDeleteCapital
            // 
            this.buttonDeleteCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCapital.Location = new System.Drawing.Point(15, 374);
            this.buttonDeleteCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCapital.Name = "buttonDeleteCapital";
            this.buttonDeleteCapital.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteCapital.TabIndex = 12;
            this.buttonDeleteCapital.Text = "Удалить";
            this.buttonDeleteCapital.UseVisualStyleBackColor = true;
            this.buttonDeleteCapital.Click += new System.EventHandler(this.buttonDeleteCapital_Click);
            // 
            // dataGridViewDeleteCapital
            // 
            this.dataGridViewDeleteCapital.AllowUserToAddRows = false;
            this.dataGridViewDeleteCapital.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeleteCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteCapital.Location = new System.Drawing.Point(15, 47);
            this.dataGridViewDeleteCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeleteCapital.MultiSelect = false;
            this.dataGridViewDeleteCapital.Name = "dataGridViewDeleteCapital";
            this.dataGridViewDeleteCapital.ReadOnly = true;
            this.dataGridViewDeleteCapital.RowHeadersWidth = 51;
            this.dataGridViewDeleteCapital.RowTemplate.Height = 24;
            this.dataGridViewDeleteCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteCapital.Size = new System.Drawing.Size(797, 310);
            this.dataGridViewDeleteCapital.TabIndex = 11;
            this.dataGridViewDeleteCapital.SelectionChanged += new System.EventHandler(this.dataGridViewShowCapital_SelectionChanged);
            // 
            // FormCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 500);
            this.Controls.Add(this.tabControlCapital);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCapital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Столицы";
            this.tabControlCapital.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCapital)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditCapital)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCapital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCapital;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowCapital;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseCity;
        private System.Windows.Forms.Button buttonInputCapital;
        private System.Windows.Forms.TextBox textBoxCapitalAreaAdd;
        private System.Windows.Forms.Label labelCapitalAreaAdd;
        private System.Windows.Forms.Label labelCapitalMayorAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditCapital;
        private System.Windows.Forms.TextBox textBoxCapitalAreaEdit;
        private System.Windows.Forms.TextBox textBoxCapitalMayorEdit;
        private System.Windows.Forms.Label labelCapitalAreaEdit;
        private System.Windows.Forms.Label labelCapitalMayorEdit;
        private System.Windows.Forms.Button buttonEditCapital;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label labelDeleteCity;
        private System.Windows.Forms.Button buttonDeleteCapital;
        private System.Windows.Forms.DataGridView dataGridViewDeleteCapital;
        private System.Windows.Forms.Label labelChooseCity;
        private System.Windows.Forms.TextBox textBoxCapitalMayorAdd;
    }
}