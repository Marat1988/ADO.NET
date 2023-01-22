
namespace TestCodeFirst
{
    partial class FormTestCodeFirst
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlTestCodeFirst = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.textBoxNameDB = new System.Windows.Forms.TextBox();
            this.labelNameDB = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelChooseTypeCollection = new System.Windows.Forms.Label();
            this.comboBoxChooseTypeConnection = new System.Windows.Forms.ComboBox();
            this.textBoxNameSQLServer = new System.Windows.Forms.TextBox();
            this.labelNameSQLServer = new System.Windows.Forms.Label();
            this.tabPageShowInfo = new System.Windows.Forms.TabPage();
            this.tabControlTestCodeFirst.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подключиться и создать базу данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlTestCodeFirst
            // 
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageConnection);
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageShowInfo);
            this.tabControlTestCodeFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTestCodeFirst.Location = new System.Drawing.Point(0, 0);
            this.tabControlTestCodeFirst.Name = "tabControlTestCodeFirst";
            this.tabControlTestCodeFirst.SelectedIndex = 0;
            this.tabControlTestCodeFirst.Size = new System.Drawing.Size(928, 535);
            this.tabControlTestCodeFirst.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.textBoxNameDB);
            this.tabPageConnection.Controls.Add(this.labelNameDB);
            this.tabPageConnection.Controls.Add(this.textBoxPassword);
            this.tabPageConnection.Controls.Add(this.textBoxLogin);
            this.tabPageConnection.Controls.Add(this.labelPassword);
            this.tabPageConnection.Controls.Add(this.labelLogin);
            this.tabPageConnection.Controls.Add(this.labelChooseTypeCollection);
            this.tabPageConnection.Controls.Add(this.comboBoxChooseTypeConnection);
            this.tabPageConnection.Controls.Add(this.textBoxNameSQLServer);
            this.tabPageConnection.Controls.Add(this.labelNameSQLServer);
            this.tabPageConnection.Controls.Add(this.button1);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(920, 509);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Подключение к БД";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // textBoxNameDB
            // 
            this.textBoxNameDB.Location = new System.Drawing.Point(213, 147);
            this.textBoxNameDB.Name = "textBoxNameDB";
            this.textBoxNameDB.Size = new System.Drawing.Size(236, 20);
            this.textBoxNameDB.TabIndex = 10;
            this.textBoxNameDB.Text = "GameDB";
            // 
            // labelNameDB
            // 
            this.labelNameDB.AutoSize = true;
            this.labelNameDB.Location = new System.Drawing.Point(8, 150);
            this.labelNameDB.Name = "labelNameDB";
            this.labelNameDB.Size = new System.Drawing.Size(199, 13);
            this.labelNameDB.TabIndex = 9;
            this.labelNameDB.Text = "Введите желаемой имя базы данных:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(241, 114);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(208, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(241, 83);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(208, 20);
            this.textBoxLogin.TabIndex = 7;
            this.textBoxLogin.Text = "sa";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(190, 117);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(189, 86);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин:";
            // 
            // labelChooseTypeCollection
            // 
            this.labelChooseTypeCollection.AutoSize = true;
            this.labelChooseTypeCollection.Location = new System.Drawing.Point(8, 51);
            this.labelChooseTypeCollection.Name = "labelChooseTypeCollection";
            this.labelChooseTypeCollection.Size = new System.Drawing.Size(227, 13);
            this.labelChooseTypeCollection.TabIndex = 4;
            this.labelChooseTypeCollection.Text = "Выберите тип подключения к SQL-серверу:";
            // 
            // comboBoxChooseTypeConnection
            // 
            this.comboBoxChooseTypeConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseTypeConnection.FormattingEnabled = true;
            this.comboBoxChooseTypeConnection.Items.AddRange(new object[] {
            "Проверка подлинности Windows",
            "Проверка подлинности SQL Server"});
            this.comboBoxChooseTypeConnection.Location = new System.Drawing.Point(241, 48);
            this.comboBoxChooseTypeConnection.Name = "comboBoxChooseTypeConnection";
            this.comboBoxChooseTypeConnection.Size = new System.Drawing.Size(208, 21);
            this.comboBoxChooseTypeConnection.TabIndex = 3;
            this.comboBoxChooseTypeConnection.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseTypeConnection_SelectedIndexChanged);
            // 
            // textBoxNameSQLServer
            // 
            this.textBoxNameSQLServer.Location = new System.Drawing.Point(199, 13);
            this.textBoxNameSQLServer.Name = "textBoxNameSQLServer";
            this.textBoxNameSQLServer.Size = new System.Drawing.Size(250, 20);
            this.textBoxNameSQLServer.TabIndex = 2;
            this.textBoxNameSQLServer.Text = "LAPTOP-FO5QIN3I\\SQLEXPRESS";
            // 
            // labelNameSQLServer
            // 
            this.labelNameSQLServer.AutoSize = true;
            this.labelNameSQLServer.Location = new System.Drawing.Point(8, 16);
            this.labelNameSQLServer.Name = "labelNameSQLServer";
            this.labelNameSQLServer.Size = new System.Drawing.Size(185, 13);
            this.labelNameSQLServer.TabIndex = 1;
            this.labelNameSQLServer.Text = "Введите имя Вашего SQL сервера:";
            // 
            // tabPageShowInfo
            // 
            this.tabPageShowInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowInfo.Name = "tabPageShowInfo";
            this.tabPageShowInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowInfo.Size = new System.Drawing.Size(920, 509);
            this.tabPageShowInfo.TabIndex = 1;
            this.tabPageShowInfo.Text = "Вывод информации";
            this.tabPageShowInfo.UseVisualStyleBackColor = true;
            // 
            // FormTestCodeFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 535);
            this.Controls.Add(this.tabControlTestCodeFirst);
            this.Name = "FormTestCodeFirst";
            this.Text = "Test code first";
            this.tabControlTestCodeFirst.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlTestCodeFirst;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TextBox textBoxNameSQLServer;
        private System.Windows.Forms.Label labelNameSQLServer;
        private System.Windows.Forms.TabPage tabPageShowInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelChooseTypeCollection;
        private System.Windows.Forms.ComboBox comboBoxChooseTypeConnection;
        private System.Windows.Forms.TextBox textBoxNameDB;
        private System.Windows.Forms.Label labelNameDB;
    }
}

