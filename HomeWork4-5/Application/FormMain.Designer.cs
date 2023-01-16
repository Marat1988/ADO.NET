
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxChooseProvider = new System.Windows.Forms.ComboBox();
            this.labelChooseProvider = new System.Windows.Forms.Label();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageShowInfo = new System.Windows.Forms.TabPage();
            this.tabPageUpdateInfo = new System.Windows.Forms.TabPage();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.numericUpDownNewCaloric = new System.Windows.Forms.NumericUpDown();
            this.labelNewCaloric = new System.Windows.Forms.Label();
            this.textBoxNewColor = new System.Windows.Forms.TextBox();
            this.labelNewColor = new System.Windows.Forms.Label();
            this.tabPageDeleteInfo = new System.Windows.Forms.TabPage();
            this.buttonDeleteInfo = new System.Windows.Forms.Button();
            this.labelDeleteInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageShowInfo.SuspendLayout();
            this.tabPageUpdateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewCaloric)).BeginInit();
            this.tabPageDeleteInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChooseProvider
            // 
            this.comboBoxChooseProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseProvider.FormattingEnabled = true;
            this.comboBoxChooseProvider.Location = new System.Drawing.Point(11, 25);
            this.comboBoxChooseProvider.Name = "comboBoxChooseProvider";
            this.comboBoxChooseProvider.Size = new System.Drawing.Size(246, 21);
            this.comboBoxChooseProvider.TabIndex = 0;
            this.comboBoxChooseProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProvider_SelectedIndexChanged);
            // 
            // labelChooseProvider
            // 
            this.labelChooseProvider.AutoSize = true;
            this.labelChooseProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseProvider.Location = new System.Drawing.Point(11, 9);
            this.labelChooseProvider.Name = "labelChooseProvider";
            this.labelChooseProvider.Size = new System.Drawing.Size(246, 13);
            this.labelChooseProvider.TabIndex = 1;
            this.labelChooseProvider.Text = "Выберите провайдера для подключения";
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(6, 16);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 360);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(910, 253);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageShowInfo);
            this.tabControl1.Controls.Add(this.tabPageUpdateInfo);
            this.tabControl1.Controls.Add(this.tabPageDeleteInfo);
            this.tabControl1.Location = new System.Drawing.Point(11, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 306);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageShowInfo
            // 
            this.tabPageShowInfo.Controls.Add(this.buttonShowInfo);
            this.tabPageShowInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowInfo.Name = "tabPageShowInfo";
            this.tabPageShowInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowInfo.Size = new System.Drawing.Size(909, 280);
            this.tabPageShowInfo.TabIndex = 0;
            this.tabPageShowInfo.Text = "Асинхронное чтение";
            this.tabPageShowInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdateInfo
            // 
            this.tabPageUpdateInfo.Controls.Add(this.buttonUpdateInfo);
            this.tabPageUpdateInfo.Controls.Add(this.numericUpDownNewCaloric);
            this.tabPageUpdateInfo.Controls.Add(this.labelNewCaloric);
            this.tabPageUpdateInfo.Controls.Add(this.textBoxNewColor);
            this.tabPageUpdateInfo.Controls.Add(this.labelNewColor);
            this.tabPageUpdateInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateInfo.Name = "tabPageUpdateInfo";
            this.tabPageUpdateInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateInfo.Size = new System.Drawing.Size(909, 280);
            this.tabPageUpdateInfo.TabIndex = 1;
            this.tabPageUpdateInfo.Text = "Асинхронное обновление";
            this.tabPageUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(18, 103);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(224, 36);
            this.buttonUpdateInfo.TabIndex = 5;
            this.buttonUpdateInfo.Text = "Обновление информации о продукте";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // numericUpDownNewCaloric
            // 
            this.numericUpDownNewCaloric.Location = new System.Drawing.Point(287, 67);
            this.numericUpDownNewCaloric.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownNewCaloric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewCaloric.Name = "numericUpDownNewCaloric";
            this.numericUpDownNewCaloric.Size = new System.Drawing.Size(192, 20);
            this.numericUpDownNewCaloric.TabIndex = 3;
            this.numericUpDownNewCaloric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNewCaloric
            // 
            this.labelNewCaloric.AutoSize = true;
            this.labelNewCaloric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewCaloric.Location = new System.Drawing.Point(15, 67);
            this.labelNewCaloric.Name = "labelNewCaloric";
            this.labelNewCaloric.Size = new System.Drawing.Size(265, 16);
            this.labelNewCaloric.TabIndex = 2;
            this.labelNewCaloric.Text = "Введите новое значение калории:";
            // 
            // textBoxNewColor
            // 
            this.textBoxNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewColor.Location = new System.Drawing.Point(184, 22);
            this.textBoxNewColor.Name = "textBoxNewColor";
            this.textBoxNewColor.Size = new System.Drawing.Size(295, 22);
            this.textBoxNewColor.TabIndex = 1;
            // 
            // labelNewColor
            // 
            this.labelNewColor.AutoSize = true;
            this.labelNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewColor.Location = new System.Drawing.Point(15, 25);
            this.labelNewColor.Name = "labelNewColor";
            this.labelNewColor.Size = new System.Drawing.Size(163, 16);
            this.labelNewColor.TabIndex = 0;
            this.labelNewColor.Text = "Введите новый цвет:";
            // 
            // tabPageDeleteInfo
            // 
            this.tabPageDeleteInfo.Controls.Add(this.labelDeleteInfo);
            this.tabPageDeleteInfo.Controls.Add(this.buttonDeleteInfo);
            this.tabPageDeleteInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteInfo.Name = "tabPageDeleteInfo";
            this.tabPageDeleteInfo.Size = new System.Drawing.Size(909, 280);
            this.tabPageDeleteInfo.TabIndex = 2;
            this.tabPageDeleteInfo.Text = "Асинхронное удаление";
            this.tabPageDeleteInfo.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteInfo
            // 
            this.buttonDeleteInfo.Location = new System.Drawing.Point(18, 49);
            this.buttonDeleteInfo.Name = "buttonDeleteInfo";
            this.buttonDeleteInfo.Size = new System.Drawing.Size(145, 36);
            this.buttonDeleteInfo.TabIndex = 6;
            this.buttonDeleteInfo.Text = "Удаление продукта";
            this.buttonDeleteInfo.UseVisualStyleBackColor = true;
            this.buttonDeleteInfo.Click += new System.EventHandler(this.buttonDeleteInfo_Click);
            // 
            // labelDeleteInfo
            // 
            this.labelDeleteInfo.AutoSize = true;
            this.labelDeleteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteInfo.Location = new System.Drawing.Point(15, 20);
            this.labelDeleteInfo.Name = "labelDeleteInfo";
            this.labelDeleteInfo.Size = new System.Drawing.Size(339, 16);
            this.labelDeleteInfo.TabIndex = 7;
            this.labelDeleteInfo.Text = "Выберите продукт из таблицы для удаления";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(326, 25);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(443, 16);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Количество секунд, потраченных на выполнение запроса:";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecond.ForeColor = System.Drawing.Color.Red;
            this.labelSecond.Location = new System.Drawing.Point(775, 23);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(19, 20);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 621);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelChooseProvider);
            this.Controls.Add(this.comboBoxChooseProvider);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фабрика провайдеров, асинхронный режим доступа, конфигурационные файлы. ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageShowInfo.ResumeLayout(false);
            this.tabPageUpdateInfo.ResumeLayout(false);
            this.tabPageUpdateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewCaloric)).EndInit();
            this.tabPageDeleteInfo.ResumeLayout(false);
            this.tabPageDeleteInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseProvider;
        private System.Windows.Forms.Label labelChooseProvider;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageShowInfo;
        private System.Windows.Forms.TabPage tabPageUpdateInfo;
        private System.Windows.Forms.TextBox textBoxNewColor;
        private System.Windows.Forms.Label labelNewColor;
        private System.Windows.Forms.Label labelNewCaloric;
        private System.Windows.Forms.NumericUpDown numericUpDownNewCaloric;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.TabPage tabPageDeleteInfo;
        private System.Windows.Forms.Button buttonDeleteInfo;
        private System.Windows.Forms.Label labelDeleteInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelSecond;
    }
}

