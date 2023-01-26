
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
            this.buttonInputStockProduct = new System.Windows.Forms.Button();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dataGridViewEditStockProduct = new System.Windows.Forms.DataGridView();
            this.buttonEditStockProduct = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonDeleteStockProduct = new System.Windows.Forms.Button();
            this.dataGridViewDeleteStockProduct = new System.Windows.Forms.DataGridView();
            this.tabControlStockProduct.SuspendLayout();
            this.tabPageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStockProduct)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditStockProduct)).BeginInit();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteStockProduct)).BeginInit();
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
            // 
            // tabPageAdd
            // 
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
            // buttonInputStockProduct
            // 
            this.buttonInputStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputStockProduct.Location = new System.Drawing.Point(24, 120);
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
            this.dataGridViewEditStockProduct.Location = new System.Drawing.Point(27, 101);
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
            this.buttonEditStockProduct.Location = new System.Drawing.Point(27, 368);
            this.buttonEditStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditStockProduct.Name = "buttonEditStockProduct";
            this.buttonEditStockProduct.Size = new System.Drawing.Size(157, 48);
            this.buttonEditStockProduct.TabIndex = 5;
            this.buttonEditStockProduct.Text = "Изменить";
            this.buttonEditStockProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
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
            this.buttonDeleteStockProduct.Location = new System.Drawing.Point(15, 374);
            this.buttonDeleteStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteStockProduct.Name = "buttonDeleteStockProduct";
            this.buttonDeleteStockProduct.Size = new System.Drawing.Size(157, 58);
            this.buttonDeleteStockProduct.TabIndex = 12;
            this.buttonDeleteStockProduct.Text = "Удалить";
            this.buttonDeleteStockProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeleteStockProduct
            // 
            this.dataGridViewDeleteStockProduct.AllowUserToAddRows = false;
            this.dataGridViewDeleteStockProduct.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteStockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteStockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteStockProduct.Location = new System.Drawing.Point(15, 47);
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
            this.tabPageEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditStockProduct)).EndInit();
            this.tabPageDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteStockProduct)).EndInit();
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
    }
}