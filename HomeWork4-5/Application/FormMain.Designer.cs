
namespace HomeWork4_5
{
    partial class FormMain
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
            this.comboBoxChooseProvider = new System.Windows.Forms.ComboBox();
            this.labelChooseProvider = new System.Windows.Forms.Label();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseProvider
            // 
            this.comboBoxChooseProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseProvider.FormattingEnabled = true;
            this.comboBoxChooseProvider.Location = new System.Drawing.Point(12, 44);
            this.comboBoxChooseProvider.Name = "comboBoxChooseProvider";
            this.comboBoxChooseProvider.Size = new System.Drawing.Size(246, 21);
            this.comboBoxChooseProvider.TabIndex = 0;
            this.comboBoxChooseProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProvider_SelectedIndexChanged);
            // 
            // labelChooseProvider
            // 
            this.labelChooseProvider.AutoSize = true;
            this.labelChooseProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseProvider.Location = new System.Drawing.Point(12, 18);
            this.labelChooseProvider.Name = "labelChooseProvider";
            this.labelChooseProvider.Size = new System.Drawing.Size(246, 13);
            this.labelChooseProvider.TabIndex = 1;
            this.labelChooseProvider.Text = "Выберите провайдера для подключения";
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(12, 80);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(145, 36);
            this.buttonShowInfo.TabIndex = 3;
            this.buttonShowInfo.Text = "Информация о продуктах";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 374);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.labelChooseProvider);
            this.Controls.Add(this.comboBoxChooseProvider);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фабрика провайдеров, асинхронный режим доступа, конфигурационные файлы. ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseProvider;
        private System.Windows.Forms.Label labelChooseProvider;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

