
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
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.dataGridViewShowCountry = new System.Windows.Forms.DataGridView();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelCountryArea = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxCountryArea = new System.Windows.Forms.TextBox();
            this.buttonInputCountry = new System.Windows.Forms.Button();
            this.tabControlCountry.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCountry)).BeginInit();
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
            this.tabControlCountry.Name = "tabControlCountry";
            this.tabControlCountry.SelectedIndex = 0;
            this.tabControlCountry.Size = new System.Drawing.Size(792, 450);
            this.tabControlCountry.TabIndex = 0;
            this.tabControlCountry.SelectedIndexChanged += new System.EventHandler(this.tabControlCountry_SelectedIndexChanged);
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowCountry);
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShow.Size = new System.Drawing.Size(784, 421);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            this.tabPageShow.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonInputCountry);
            this.tabPageAdd.Controls.Add(this.textBoxCountryArea);
            this.tabPageAdd.Controls.Add(this.textBoxCountryName);
            this.tabPageAdd.Controls.Add(this.labelCountryArea);
            this.tabPageAdd.Controls.Add(this.labelCountryName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(784, 421);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(784, 421);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(784, 421);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowCountry
            // 
            this.dataGridViewShowCountry.AllowUserToAddRows = false;
            this.dataGridViewShowCountry.AllowUserToDeleteRows = false;
            this.dataGridViewShowCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowCountry.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShowCountry.MultiSelect = false;
            this.dataGridViewShowCountry.Name = "dataGridViewShowCountry";
            this.dataGridViewShowCountry.ReadOnly = true;
            this.dataGridViewShowCountry.RowHeadersWidth = 51;
            this.dataGridViewShowCountry.RowTemplate.Height = 24;
            this.dataGridViewShowCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowCountry.Size = new System.Drawing.Size(778, 415);
            this.dataGridViewShowCountry.TabIndex = 0;
            this.dataGridViewShowCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCountry_CellContentClick);
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(18, 19);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(185, 17);
            this.labelCountryName.TabIndex = 0;
            this.labelCountryName.Text = "Введите название страны:";
            // 
            // labelCountryArea
            // 
            this.labelCountryArea.AutoSize = true;
            this.labelCountryArea.Location = new System.Drawing.Point(18, 56);
            this.labelCountryArea.Name = "labelCountryArea";
            this.labelCountryArea.Size = new System.Drawing.Size(230, 17);
            this.labelCountryArea.TabIndex = 1;
            this.labelCountryArea.Text = "Введите численность населения:";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(260, 16);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(155, 22);
            this.textBoxCountryName.TabIndex = 2;
            // 
            // textBoxCountryArea
            // 
            this.textBoxCountryArea.Location = new System.Drawing.Point(260, 56);
            this.textBoxCountryArea.Name = "textBoxCountryArea";
            this.textBoxCountryArea.Size = new System.Drawing.Size(155, 22);
            this.textBoxCountryArea.TabIndex = 3;
            // 
            // buttonInputCountry
            // 
            this.buttonInputCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputCountry.Location = new System.Drawing.Point(21, 94);
            this.buttonInputCountry.Name = "buttonInputCountry";
            this.buttonInputCountry.Size = new System.Drawing.Size(158, 48);
            this.buttonInputCountry.TabIndex = 4;
            this.buttonInputCountry.Text = "Добавить";
            this.buttonInputCountry.UseVisualStyleBackColor = true;
            this.buttonInputCountry.Click += new System.EventHandler(this.buttonInputCountry_Click);
            // 
            // FormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.tabControlCountry);
            this.Name = "FormCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны";
            this.tabControlCountry.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCountry;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.DataGridView dataGridViewShowCountry;
        private System.Windows.Forms.TextBox textBoxCountryArea;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelCountryArea;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Button buttonInputCountry;
    }
}