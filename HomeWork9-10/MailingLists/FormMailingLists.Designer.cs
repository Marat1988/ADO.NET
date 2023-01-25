
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
            this.SuspendLayout();
            // 
            // buttonCountry
            // 
            this.buttonCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Location = new System.Drawing.Point(115, 22);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(254, 73);
            this.buttonCountry.TabIndex = 0;
            this.buttonCountry.Text = "Справочник стран";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Location = new System.Drawing.Point(115, 119);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(254, 73);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Справочник городов";
            this.buttonCity.UseVisualStyleBackColor = true;
            // 
            // FormMailingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 386);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMailingLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рассылок";
            this.Load += new System.EventHandler(this.FormMailingLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCountry;
        private System.Windows.Forms.Button buttonCity;
    }
}

