
namespace MailingLists.Forms
{
    partial class FormGroupProduct
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
            this.tabControlGroupProduct = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.dataGridViewShowGroupProduct = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.buttonInputGroupProduct = new System.Windows.Forms.Button();
            this.textBoxGroupProductNameAdd = new System.Windows.Forms.TextBox();
            this.labelGroupProductNameAdd = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditGroupProduct = new System.Windows.Forms.DataGridView();
            this.textBoxGroupProductNameEdit = new System.Windows.Forms.TextBox();
            this.labelGroupProductNameEdit = new System.Windows.Forms.Label();
            this.buttonEditGroupProduct = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelDeleteGroupProduct = new System.Windows.Forms.Label();
            this.buttonDeleteGroupProduct = new System.Windows.Forms.Button();
            this.dataGridViewDeleteGroupProduct = new System.Windows.Forms.DataGridView();
            this.tabControlGroupProduct.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowGroupProduct)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditGroupProduct)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteGroupProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGroupProduct
            // 
            this.tabControlGroupProduct.Controls.Add(this.tabPageShow);
            this.tabControlGroupProduct.Controls.Add(this.tabPageAdd);
            this.tabControlGroupProduct.Controls.Add(this.tabPageEdit);
            this.tabControlGroupProduct.Controls.Add(this.tabPageDelete);
            this.tabControlGroupProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGroupProduct.Location = new System.Drawing.Point(0, 0);
            this.tabControlGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGroupProduct.Name = "tabControlGroupProduct";
            this.tabControlGroupProduct.SelectedIndex = 0;
            this.tabControlGroupProduct.Size = new System.Drawing.Size(800, 450);
            this.tabControlGroupProduct.TabIndex = 3;
            // 
            // tabPageShow
            // 
            this.tabPageShow.Controls.Add(this.dataGridViewShowGroupProduct);
            this.tabPageShow.Location = new System.Drawing.Point(4, 22);
            this.tabPageShow.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageShow.Size = new System.Drawing.Size(792, 424);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Показать список";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowGroupProduct
            // 
            this.dataGridViewShowGroupProduct.AllowUserToAddRows = false;
            this.dataGridViewShowGroupProduct.AllowUserToDeleteRows = false;
            this.dataGridViewShowGroupProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowGroupProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowGroupProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowGroupProduct.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewShowGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShowGroupProduct.MultiSelect = false;
            this.dataGridViewShowGroupProduct.Name = "dataGridViewShowGroupProduct";
            this.dataGridViewShowGroupProduct.ReadOnly = true;
            this.dataGridViewShowGroupProduct.RowHeadersWidth = 51;
            this.dataGridViewShowGroupProduct.RowTemplate.Height = 24;
            this.dataGridViewShowGroupProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowGroupProduct.Size = new System.Drawing.Size(788, 420);
            this.dataGridViewShowGroupProduct.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonInputGroupProduct);
            this.tabPageAdd.Controls.Add(this.textBoxGroupProductNameAdd);
            this.tabPageAdd.Controls.Add(this.labelGroupProductNameAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Size = new System.Drawing.Size(792, 424);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonInputGroupProduct
            // 
            this.buttonInputGroupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputGroupProduct.Location = new System.Drawing.Point(17, 48);
            this.buttonInputGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInputGroupProduct.Name = "buttonInputGroupProduct";
            this.buttonInputGroupProduct.Size = new System.Drawing.Size(118, 39);
            this.buttonInputGroupProduct.TabIndex = 4;
            this.buttonInputGroupProduct.Text = "Добавить";
            this.buttonInputGroupProduct.UseVisualStyleBackColor = true;
            this.buttonInputGroupProduct.Click += new System.EventHandler(this.buttonInputGroupProduct_Click);
            // 
            // textBoxGroupProductNameAdd
            // 
            this.textBoxGroupProductNameAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupProductNameAdd.Location = new System.Drawing.Point(195, 13);
            this.textBoxGroupProductNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupProductNameAdd.Name = "textBoxGroupProductNameAdd";
            this.textBoxGroupProductNameAdd.Size = new System.Drawing.Size(341, 20);
            this.textBoxGroupProductNameAdd.TabIndex = 2;
            this.textBoxGroupProductNameAdd.TextChanged += new System.EventHandler(this.textBoxCityNameAdd_TextChanged);
            // 
            // labelGroupProductNameAdd
            // 
            this.labelGroupProductNameAdd.AutoSize = true;
            this.labelGroupProductNameAdd.Location = new System.Drawing.Point(14, 15);
            this.labelGroupProductNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroupProductNameAdd.Name = "labelGroupProductNameAdd";
            this.labelGroupProductNameAdd.Size = new System.Drawing.Size(180, 13);
            this.labelGroupProductNameAdd.TabIndex = 0;
            this.labelGroupProductNameAdd.Text = "Введите название группы товара:";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.dataGridViewEditGroupProduct);
            this.tabPageEdit.Controls.Add(this.textBoxGroupProductNameEdit);
            this.tabPageEdit.Controls.Add(this.labelGroupProductNameEdit);
            this.tabPageEdit.Controls.Add(this.buttonEditGroupProduct);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(792, 424);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Изменить";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditGroupProduct
            // 
            this.dataGridViewEditGroupProduct.AllowUserToAddRows = false;
            this.dataGridViewEditGroupProduct.AllowUserToDeleteRows = false;
            this.dataGridViewEditGroupProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEditGroupProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditGroupProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditGroupProduct.Location = new System.Drawing.Point(20, 128);
            this.dataGridViewEditGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEditGroupProduct.MultiSelect = false;
            this.dataGridViewEditGroupProduct.Name = "dataGridViewEditGroupProduct";
            this.dataGridViewEditGroupProduct.ReadOnly = true;
            this.dataGridViewEditGroupProduct.RowHeadersWidth = 51;
            this.dataGridViewEditGroupProduct.RowTemplate.Height = 24;
            this.dataGridViewEditGroupProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEditGroupProduct.Size = new System.Drawing.Size(598, 227);
            this.dataGridViewEditGroupProduct.TabIndex = 10;
            // 
            // textBoxGroupProductNameEdit
            // 
            this.textBoxGroupProductNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupProductNameEdit.Location = new System.Drawing.Point(232, 10);
            this.textBoxGroupProductNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGroupProductNameEdit.Name = "textBoxGroupProductNameEdit";
            this.textBoxGroupProductNameEdit.Size = new System.Drawing.Size(387, 20);
            this.textBoxGroupProductNameEdit.TabIndex = 8;
            // 
            // labelGroupProductNameEdit
            // 
            this.labelGroupProductNameEdit.AutoSize = true;
            this.labelGroupProductNameEdit.Location = new System.Drawing.Point(17, 13);
            this.labelGroupProductNameEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroupProductNameEdit.Name = "labelGroupProductNameEdit";
            this.labelGroupProductNameEdit.Size = new System.Drawing.Size(213, 13);
            this.labelGroupProductNameEdit.TabIndex = 6;
            this.labelGroupProductNameEdit.Text = "Введите новое название группы товара:";
            // 
            // buttonEditGroupProduct
            // 
            this.buttonEditGroupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditGroupProduct.Location = new System.Drawing.Point(20, 46);
            this.buttonEditGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditGroupProduct.Name = "buttonEditGroupProduct";
            this.buttonEditGroupProduct.Size = new System.Drawing.Size(118, 39);
            this.buttonEditGroupProduct.TabIndex = 5;
            this.buttonEditGroupProduct.Text = "Изменить";
            this.buttonEditGroupProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelDeleteGroupProduct);
            this.tabPageDelete.Controls.Add(this.buttonDeleteGroupProduct);
            this.tabPageDelete.Controls.Add(this.dataGridViewDeleteGroupProduct);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(792, 424);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteGroupProduct
            // 
            this.labelDeleteGroupProduct.AutoSize = true;
            this.labelDeleteGroupProduct.Location = new System.Drawing.Point(8, 14);
            this.labelDeleteGroupProduct.Name = "labelDeleteGroupProduct";
            this.labelDeleteGroupProduct.Size = new System.Drawing.Size(338, 13);
            this.labelDeleteGroupProduct.TabIndex = 13;
            this.labelDeleteGroupProduct.Text = "Выберите группу товара из списка и нажмите на кнопку удалить";
            this.labelDeleteGroupProduct.UseMnemonic = false;
            // 
            // buttonDeleteGroupProduct
            // 
            this.buttonDeleteGroupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteGroupProduct.Location = new System.Drawing.Point(11, 304);
            this.buttonDeleteGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteGroupProduct.Name = "buttonDeleteGroupProduct";
            this.buttonDeleteGroupProduct.Size = new System.Drawing.Size(118, 47);
            this.buttonDeleteGroupProduct.TabIndex = 12;
            this.buttonDeleteGroupProduct.Text = "Удалить";
            this.buttonDeleteGroupProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeleteGroupProduct
            // 
            this.dataGridViewDeleteGroupProduct.AllowUserToAddRows = false;
            this.dataGridViewDeleteGroupProduct.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteGroupProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeleteGroupProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteGroupProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteGroupProduct.Location = new System.Drawing.Point(11, 38);
            this.dataGridViewDeleteGroupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeleteGroupProduct.MultiSelect = false;
            this.dataGridViewDeleteGroupProduct.Name = "dataGridViewDeleteGroupProduct";
            this.dataGridViewDeleteGroupProduct.ReadOnly = true;
            this.dataGridViewDeleteGroupProduct.RowHeadersWidth = 51;
            this.dataGridViewDeleteGroupProduct.RowTemplate.Height = 24;
            this.dataGridViewDeleteGroupProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteGroupProduct.Size = new System.Drawing.Size(750, 252);
            this.dataGridViewDeleteGroupProduct.TabIndex = 11;
            // 
            // FormGroupProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlGroupProduct);
            this.Name = "FormGroupProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroupProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlGroupProduct.ResumeLayout(false);
            this.tabPageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowGroupProduct)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditGroupProduct)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteGroupProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGroupProduct;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.DataGridView dataGridViewShowGroupProduct;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonInputGroupProduct;
        private System.Windows.Forms.TextBox textBoxGroupProductNameAdd;
        private System.Windows.Forms.Label labelGroupProductNameAdd;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.DataGridView dataGridViewEditGroupProduct;
        private System.Windows.Forms.TextBox textBoxGroupProductNameEdit;
        private System.Windows.Forms.Label labelGroupProductNameEdit;
        private System.Windows.Forms.Button buttonEditGroupProduct;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label labelDeleteGroupProduct;
        private System.Windows.Forms.Button buttonDeleteGroupProduct;
        private System.Windows.Forms.DataGridView dataGridViewDeleteGroupProduct;
    }
}