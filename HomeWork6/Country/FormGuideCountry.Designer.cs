
namespace Country
{
    partial class FormGuideCountry
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
            this.buttonCapital = new System.Windows.Forms.Button();
            this.buttonBigCity = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCountry
            // 
            this.buttonCountry.Location = new System.Drawing.Point(95, 12);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(181, 50);
            this.buttonCountry.TabIndex = 0;
            this.buttonCountry.Text = "Справочник стран";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(95, 79);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(181, 50);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Справочник городов";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonCapital
            // 
            this.buttonCapital.Location = new System.Drawing.Point(95, 144);
            this.buttonCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCapital.Name = "buttonCapital";
            this.buttonCapital.Size = new System.Drawing.Size(181, 50);
            this.buttonCapital.TabIndex = 2;
            this.buttonCapital.Text = "Справочник столиц";
            this.buttonCapital.UseVisualStyleBackColor = true;
            this.buttonCapital.Click += new System.EventHandler(this.buttonCapital_Click);
            // 
            // buttonBigCity
            // 
            this.buttonBigCity.Location = new System.Drawing.Point(95, 209);
            this.buttonBigCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBigCity.Name = "buttonBigCity";
            this.buttonBigCity.Size = new System.Drawing.Size(181, 50);
            this.buttonBigCity.TabIndex = 3;
            this.buttonBigCity.Text = "Справочник крупных городов";
            this.buttonBigCity.UseVisualStyleBackColor = true;
            this.buttonBigCity.Click += new System.EventHandler(this.buttonBigCity_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(95, 275);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(181, 50);
            this.buttonShowInfo.TabIndex = 4;
            this.buttonShowInfo.Text = "Справочная информация";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // FormGuideCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 363);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonBigCity);
            this.Controls.Add(this.buttonCapital);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonCountry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGuideCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник стран";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCountry;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonCapital;
        private System.Windows.Forms.Button buttonBigCity;
        private System.Windows.Forms.Button buttonShowInfo;
    }
}

