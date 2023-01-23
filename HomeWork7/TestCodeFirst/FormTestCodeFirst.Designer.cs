
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
            this.buttonCreateDataBase = new System.Windows.Forms.Button();
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
            this.tabPageShowInfoCompany = new System.Windows.Forms.TabPage();
            this.dataGridViewShowInfoCompany = new System.Windows.Forms.DataGridView();
            this.tabPageStyleGame = new System.Windows.Forms.TabPage();
            this.dataGridViewStyleGame = new System.Windows.Forms.DataGridView();
            this.tabPageShowInfoGame = new System.Windows.Forms.TabPage();
            this.dataGridViewShowInfoGames = new System.Windows.Forms.DataGridView();
            this.tabControlTestCodeFirst.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageShowInfoCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfoCompany)).BeginInit();
            this.tabPageStyleGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStyleGame)).BeginInit();
            this.tabPageShowInfoGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfoGames)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateDataBase
            // 
            this.buttonCreateDataBase.Location = new System.Drawing.Point(8, 187);
            this.buttonCreateDataBase.Name = "buttonCreateDataBase";
            this.buttonCreateDataBase.Size = new System.Drawing.Size(224, 56);
            this.buttonCreateDataBase.TabIndex = 0;
            this.buttonCreateDataBase.Text = "Подключиться и создать базу данных";
            this.buttonCreateDataBase.UseVisualStyleBackColor = true;
            this.buttonCreateDataBase.Click += new System.EventHandler(this.buttonCreateDataBase_Click);
            // 
            // tabControlTestCodeFirst
            // 
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageConnection);
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageShowInfoCompany);
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageStyleGame);
            this.tabControlTestCodeFirst.Controls.Add(this.tabPageShowInfoGame);
            this.tabControlTestCodeFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTestCodeFirst.Location = new System.Drawing.Point(0, 0);
            this.tabControlTestCodeFirst.Name = "tabControlTestCodeFirst";
            this.tabControlTestCodeFirst.SelectedIndex = 0;
            this.tabControlTestCodeFirst.Size = new System.Drawing.Size(928, 535);
            this.tabControlTestCodeFirst.TabIndex = 1;
            this.tabControlTestCodeFirst.SelectedIndexChanged += new System.EventHandler(this.tabControlTestCodeFirst_SelectedIndexChanged);
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
            this.tabPageConnection.Controls.Add(this.buttonCreateDataBase);
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
            // tabPageShowInfoCompany
            // 
            this.tabPageShowInfoCompany.Controls.Add(this.dataGridViewShowInfoCompany);
            this.tabPageShowInfoCompany.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowInfoCompany.Name = "tabPageShowInfoCompany";
            this.tabPageShowInfoCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowInfoCompany.Size = new System.Drawing.Size(920, 509);
            this.tabPageShowInfoCompany.TabIndex = 1;
            this.tabPageShowInfoCompany.Text = "Вывод информации. Разработчики игр";
            this.tabPageShowInfoCompany.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowInfoCompany
            // 
            this.dataGridViewShowInfoCompany.AllowUserToAddRows = false;
            this.dataGridViewShowInfoCompany.AllowUserToDeleteRows = false;
            this.dataGridViewShowInfoCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowInfoCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowInfoCompany.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShowInfoCompany.MultiSelect = false;
            this.dataGridViewShowInfoCompany.Name = "dataGridViewShowInfoCompany";
            this.dataGridViewShowInfoCompany.ReadOnly = true;
            this.dataGridViewShowInfoCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowInfoCompany.Size = new System.Drawing.Size(914, 503);
            this.dataGridViewShowInfoCompany.TabIndex = 0;
            // 
            // tabPageStyleGame
            // 
            this.tabPageStyleGame.Controls.Add(this.dataGridViewStyleGame);
            this.tabPageStyleGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageStyleGame.Name = "tabPageStyleGame";
            this.tabPageStyleGame.Size = new System.Drawing.Size(920, 509);
            this.tabPageStyleGame.TabIndex = 2;
            this.tabPageStyleGame.Text = "Вывод информации.  Стили игры";
            this.tabPageStyleGame.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStyleGame
            // 
            this.dataGridViewStyleGame.AllowUserToAddRows = false;
            this.dataGridViewStyleGame.AllowUserToDeleteRows = false;
            this.dataGridViewStyleGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStyleGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStyleGame.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStyleGame.MultiSelect = false;
            this.dataGridViewStyleGame.Name = "dataGridViewStyleGame";
            this.dataGridViewStyleGame.ReadOnly = true;
            this.dataGridViewStyleGame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStyleGame.Size = new System.Drawing.Size(920, 509);
            this.dataGridViewStyleGame.TabIndex = 1;
            // 
            // tabPageShowInfoGame
            // 
            this.tabPageShowInfoGame.Controls.Add(this.dataGridViewShowInfoGames);
            this.tabPageShowInfoGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowInfoGame.Name = "tabPageShowInfoGame";
            this.tabPageShowInfoGame.Size = new System.Drawing.Size(920, 509);
            this.tabPageShowInfoGame.TabIndex = 3;
            this.tabPageShowInfoGame.Text = "Вывод информации. Список игр";
            this.tabPageShowInfoGame.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowInfoGames
            // 
            this.dataGridViewShowInfoGames.AllowUserToAddRows = false;
            this.dataGridViewShowInfoGames.AllowUserToDeleteRows = false;
            this.dataGridViewShowInfoGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowInfoGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowInfoGames.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShowInfoGames.MultiSelect = false;
            this.dataGridViewShowInfoGames.Name = "dataGridViewShowInfoGames";
            this.dataGridViewShowInfoGames.ReadOnly = true;
            this.dataGridViewShowInfoGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowInfoGames.Size = new System.Drawing.Size(920, 509);
            this.dataGridViewShowInfoGames.TabIndex = 2;
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
            this.tabPageShowInfoCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfoCompany)).EndInit();
            this.tabPageStyleGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStyleGame)).EndInit();
            this.tabPageShowInfoGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowInfoGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateDataBase;
        private System.Windows.Forms.TabControl tabControlTestCodeFirst;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TextBox textBoxNameSQLServer;
        private System.Windows.Forms.Label labelNameSQLServer;
        private System.Windows.Forms.TabPage tabPageShowInfoCompany;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelChooseTypeCollection;
        private System.Windows.Forms.ComboBox comboBoxChooseTypeConnection;
        private System.Windows.Forms.TextBox textBoxNameDB;
        private System.Windows.Forms.Label labelNameDB;
        private System.Windows.Forms.DataGridView dataGridViewShowInfoCompany;
        private System.Windows.Forms.TabPage tabPageStyleGame;
        private System.Windows.Forms.DataGridView dataGridViewStyleGame;
        private System.Windows.Forms.TabPage tabPageShowInfoGame;
        private System.Windows.Forms.DataGridView dataGridViewShowInfoGames;
    }
}

