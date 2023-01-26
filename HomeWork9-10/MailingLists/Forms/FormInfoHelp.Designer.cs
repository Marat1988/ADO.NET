
namespace MailingLists.Forms
{
    partial class FormInfoHelp
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
            this.buttonInfoStockProduct = new System.Windows.Forms.Button();
            this.buttonInfoShowGroup = new System.Windows.Forms.Button();
            this.buttonInfoShowCity = new System.Windows.Forms.Button();
            this.dataGridViewShowInfo = new System.Windows.Forms.DataGridView();
            this.labelChooseCity = new System.Windows.Forms.Label();
            this.comboBoxChooseCountry = new System.Windows.Forms.ComboBox();
            this.labelChooseBuyers = new System.Windows.Forms.Label();
            this.comboBoxChooseBuyers = new System.Windows.Forms.ComboBox();
            this.labelChooseGroupProduct = new System.Windows.Forms.Label();
            this.comboBoxChooseGroupProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfoStockProduct
            // 
            this.buttonInfoStockProduct.Location = new System.Drawing.Point(12, 394);
            this.buttonInfoStockProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfoStockProduct.Name = "buttonInfoStockProduct";
            this.buttonInfoStockProduct.Size = new System.Drawing.Size(495, 58);
            this.buttonInfoStockProduct.TabIndex = 7;
            this.buttonInfoStockProduct.Text = "Отображение списка акционных товаров конкретного раздела";
            this.buttonInfoStockProduct.UseVisualStyleBackColor = true;
            this.buttonInfoStockProduct.Click += new System.EventHandler(this.buttonInfoStockProduct_Click);
            // 
            // buttonInfoShowGroup
            // 
            this.buttonInfoShowGroup.Location = new System.Drawing.Point(12, 323);
            this.buttonInfoShowGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfoShowGroup.Name = "buttonInfoShowGroup";
            this.buttonInfoShowGroup.Size = new System.Drawing.Size(495, 58);
            this.buttonInfoShowGroup.TabIndex = 6;
            this.buttonInfoShowGroup.Text = "Отображение списка разделов конкретного покупателя";
            this.buttonInfoShowGroup.UseVisualStyleBackColor = true;
            this.buttonInfoShowGroup.Click += new System.EventHandler(this.buttonInfoShowGroup_Click);
            // 
            // buttonInfoShowCity
            // 
            this.buttonInfoShowCity.Location = new System.Drawing.Point(12, 250);
            this.buttonInfoShowCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfoShowCity.Name = "buttonInfoShowCity";
            this.buttonInfoShowCity.Size = new System.Drawing.Size(495, 58);
            this.buttonInfoShowCity.TabIndex = 5;
            this.buttonInfoShowCity.Text = "Отображение списка городов конкретной страны";
            this.buttonInfoShowCity.UseVisualStyleBackColor = true;
            this.buttonInfoShowCity.Click += new System.EventHandler(this.buttonInfoShowCity_Click);
            // 
            // dataGridViewShowInfo
            // 
            this.dataGridViewShowInfo.AllowUserToAddRows = false;
            this.dataGridViewShowInfo.AllowUserToDeleteRows = false;
            this.dataGridViewShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowInfo.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewShowInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShowInfo.MultiSelect = false;
            this.dataGridViewShowInfo.Name = "dataGridViewShowInfo";
            this.dataGridViewShowInfo.ReadOnly = true;
            this.dataGridViewShowInfo.RowHeadersWidth = 51;
            this.dataGridViewShowInfo.RowTemplate.Height = 24;
            this.dataGridViewShowInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowInfo.Size = new System.Drawing.Size(824, 222);
            this.dataGridViewShowInfo.TabIndex = 4;
            // 
            // labelChooseCity
            // 
            this.labelChooseCity.AutoSize = true;
            this.labelChooseCity.Location = new System.Drawing.Point(526, 250);
            this.labelChooseCity.Name = "labelChooseCity";
            this.labelChooseCity.Size = new System.Drawing.Size(127, 17);
            this.labelChooseCity.TabIndex = 8;
            this.labelChooseCity.Text = "Выберите страну:";
            // 
            // comboBoxChooseCountry
            // 
            this.comboBoxChooseCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCountry.FormattingEnabled = true;
            this.comboBoxChooseCountry.Location = new System.Drawing.Point(529, 270);
            this.comboBoxChooseCountry.Name = "comboBoxChooseCountry";
            this.comboBoxChooseCountry.Size = new System.Drawing.Size(307, 24);
            this.comboBoxChooseCountry.TabIndex = 9;
            // 
            // labelChooseBuyers
            // 
            this.labelChooseBuyers.AutoSize = true;
            this.labelChooseBuyers.Location = new System.Drawing.Point(526, 323);
            this.labelChooseBuyers.Name = "labelChooseBuyers";
            this.labelChooseBuyers.Size = new System.Drawing.Size(159, 17);
            this.labelChooseBuyers.TabIndex = 10;
            this.labelChooseBuyers.Text = "Выберите покупателя:";
            // 
            // comboBoxChooseBuyers
            // 
            this.comboBoxChooseBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseBuyers.FormattingEnabled = true;
            this.comboBoxChooseBuyers.Location = new System.Drawing.Point(529, 343);
            this.comboBoxChooseBuyers.Name = "comboBoxChooseBuyers";
            this.comboBoxChooseBuyers.Size = new System.Drawing.Size(307, 24);
            this.comboBoxChooseBuyers.TabIndex = 11;
            // 
            // labelChooseGroupProduct
            // 
            this.labelChooseGroupProduct.AutoSize = true;
            this.labelChooseGroupProduct.Location = new System.Drawing.Point(526, 394);
            this.labelChooseGroupProduct.Name = "labelChooseGroupProduct";
            this.labelChooseGroupProduct.Size = new System.Drawing.Size(226, 17);
            this.labelChooseGroupProduct.TabIndex = 12;
            this.labelChooseGroupProduct.Text = "Выберите группу товара/раздел:";
            // 
            // comboBoxChooseGroupProduct
            // 
            this.comboBoxChooseGroupProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseGroupProduct.FormattingEnabled = true;
            this.comboBoxChooseGroupProduct.Location = new System.Drawing.Point(529, 414);
            this.comboBoxChooseGroupProduct.Name = "comboBoxChooseGroupProduct";
            this.comboBoxChooseGroupProduct.Size = new System.Drawing.Size(307, 24);
            this.comboBoxChooseGroupProduct.TabIndex = 13;
            // 
            // FormInfoHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.comboBoxChooseGroupProduct);
            this.Controls.Add(this.labelChooseGroupProduct);
            this.Controls.Add(this.comboBoxChooseBuyers);
            this.Controls.Add(this.labelChooseBuyers);
            this.Controls.Add(this.comboBoxChooseCountry);
            this.Controls.Add(this.labelChooseCity);
            this.Controls.Add(this.buttonInfoStockProduct);
            this.Controls.Add(this.buttonInfoShowGroup);
            this.Controls.Add(this.buttonInfoShowCity);
            this.Controls.Add(this.dataGridViewShowInfo);
            this.Name = "FormInfoHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoHelp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInfoStockProduct;
        private System.Windows.Forms.Button buttonInfoShowGroup;
        private System.Windows.Forms.Button buttonInfoShowCity;
        private System.Windows.Forms.DataGridView dataGridViewShowInfo;
        private System.Windows.Forms.Label labelChooseCity;
        private System.Windows.Forms.ComboBox comboBoxChooseCountry;
        private System.Windows.Forms.Label labelChooseBuyers;
        private System.Windows.Forms.ComboBox comboBoxChooseBuyers;
        private System.Windows.Forms.Label labelChooseGroupProduct;
        private System.Windows.Forms.ComboBox comboBoxChooseGroupProduct;
    }
}