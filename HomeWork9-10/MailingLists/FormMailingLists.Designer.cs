
namespace MailingLists
{
    partial class FormMailingLists
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCountry = new System.Windows.Forms.Button();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonBuyers = new System.Windows.Forms.Button();
            this.buttonGroupProduct = new System.Windows.Forms.Button();
            this.buttonInfoHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCountry
            // 
            this.buttonCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Location = new System.Drawing.Point(45, 27);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(517, 70);
            this.buttonCountry.TabIndex = 0;
            this.buttonCountry.Text = "Справочник стран";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Location = new System.Drawing.Point(45, 106);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(517, 66);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Справочник городов";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonBuyers
            // 
            this.buttonBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyers.Location = new System.Drawing.Point(45, 180);
            this.buttonBuyers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuyers.Name = "buttonBuyers";
            this.buttonBuyers.Size = new System.Drawing.Size(517, 66);
            this.buttonBuyers.TabIndex = 2;
            this.buttonBuyers.Text = "Справочник покупателей";
            this.buttonBuyers.UseVisualStyleBackColor = true;
            this.buttonBuyers.Click += new System.EventHandler(this.buttonBuyers_Click);
            // 
            // buttonGroupProduct
            // 
            this.buttonGroupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupProduct.Location = new System.Drawing.Point(45, 254);
            this.buttonGroupProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupProduct.Name = "buttonGroupProduct";
            this.buttonGroupProduct.Size = new System.Drawing.Size(517, 66);
            this.buttonGroupProduct.TabIndex = 3;
            this.buttonGroupProduct.Text = "Справочник разделов/групп товаров";
            this.buttonGroupProduct.UseVisualStyleBackColor = true;
            this.buttonGroupProduct.Click += new System.EventHandler(this.buttonGroupProduct_Click);
            // 
            // buttonInfoHelp
            // 
            this.buttonInfoHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfoHelp.Location = new System.Drawing.Point(45, 328);
            this.buttonInfoHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfoHelp.Name = "buttonInfoHelp";
            this.buttonInfoHelp.Size = new System.Drawing.Size(517, 66);
            this.buttonInfoHelp.TabIndex = 4;
            this.buttonInfoHelp.Text = "Справочная информация";
            this.buttonInfoHelp.UseVisualStyleBackColor = true;
            this.buttonInfoHelp.Click += new System.EventHandler(this.buttonInfoHelp_Click);
            // 
            // FormMailingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 475);
            this.Controls.Add(this.buttonInfoHelp);
            this.Controls.Add(this.buttonGroupProduct);
            this.Controls.Add(this.buttonBuyers);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMailingLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рассылок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCountry;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonBuyers;
        private System.Windows.Forms.Button buttonGroupProduct;
        private System.Windows.Forms.Button buttonInfoHelp;
    }
}

