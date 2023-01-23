using BECodeFirst;
using GameEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCodeFirst
{
    public partial class FormTestCodeFirst : Form
    {
        public FormTestCodeFirst()
        {
            InitializeComponent();
            comboBoxChooseTypeConnection.SelectedIndex = 0;
            textBoxNameSQLServer.Text = Properties.Settings.Default.SqlServer;
            textBoxNameDB.Text = Properties.Settings.Default.NameDB;
            textBoxLogin.Text = Properties.Settings.Default.Login;
            textBoxPassword.Text = Properties.Settings.Default.Password;
        }

        private void comboBoxChooseTypeConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxLogin.Enabled = comboBoxChooseTypeConnection.SelectedIndex == 1;
            textBoxPassword.Enabled = comboBoxChooseTypeConnection.SelectedIndex == 1;
        }

        private string GetConnection()
        {
            if (comboBoxChooseTypeConnection.SelectedIndex == 1)
                return $@"Data Source={textBoxNameSQLServer.Text}; Initial Catalog={textBoxNameDB.Text}; User ID={textBoxLogin.Text}; Password={textBoxPassword.Text}; Persist Security Info=True";
            else
                return $@"Data Source={textBoxNameSQLServer.Text}; Initial Catalog={textBoxNameDB.Text}; Integrated Security=True";
        }

        private void buttonCreateDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (GameContext context = new GameContext(GetConnection()))
                {
                    Game game = new Game();
                    //Компании
                    List<Company> companies = new List<Company>()
                    {
                        new Company{ Name = "Lesta Games" },
                        new Company{ Name = "Rockstar Gamess" },
                        new Company{ Name = "Gaijin Entertainment"}
                    };
                    context.Company.AddRange(companies);
                    //Стили игры
                    List<StyleGame> styleGames = new List<StyleGame>()
                    {
                        new StyleGame{ Name = "Экшен"},
                        new StyleGame{ Name = "Стратегия"},
                        new StyleGame{ Name = "Шутер"}
                    };
                    context.GameStyle.AddRange(styleGames);
                    //Режим игры
                    List<GameMode> gameModes = new List<GameMode>()
                    {
                        new GameMode{ Name="Однопользовательский"},
                        new GameMode{ Name="Многопользовательский"},
                        new GameMode{ Name="Универсальный"}
                    };
                    context.GameMode.AddRange(gameModes);
                    context.SaveChanges();
                    List<Game> games = new List<Game>()
                    {
                        new Game{ Name="Параграф 78", ReleaseDate=Convert.ToDateTime("2007.03.09"), StyleGameId=3, CompanyId=3, GameModeId=3, SalesCopy=150}
                    };
                    context.Game.AddRange(games);
                    context.SaveChanges();
                }                
                MessageBox.Show("The database has been created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControlTestCodeFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (GameContext db = new GameContext(GetConnection()))
                {
                    switch (tabControlTestCodeFirst.SelectedIndex)
                    {
                        case 1:
                            ShowInfo(dataGridViewShowInfoCompany, (from c in db.Company
                                                                   select new
                                                                   {
                                                                       Id_Company = c.CompanyId,
                                                                       Name_Company = c.Name
                                                                   }).ToList());
                            break;
                        case 2:
                            ShowInfo(dataGridViewStyleGame, (from c in db.GameStyle
                                                             select new
                                                             {
                                                                 Id_GameStyle = c.StyleGameId,
                                                                 Name_Style = c.Name
                                                             }).ToList());
                            break;
                        case 3:
                            ShowInfo(dataGridViewShowInfoGames, (from c1 in db.Game
                                                                 join c2 in db.Company on c1.CompanyId equals c2.CompanyId
                                                                 join c3 in db.GameStyle on c1.StyleGameId equals c3.StyleGameId
                                                                 join c4 in db.GameMode on c1.GameModeId equals c4.GameModeId
                                                                 select new
                                                                 {
                                                                    Id_Game = c1.GameId,
                                                                    Name_Game = c1.Name,
                                                                    Release_Date = c1.ReleaseDate,
                                                                    Company_Game = c2.Name,
                                                                    Style_Game = c3.Name,
                                                                    Game_Mode = c4.Name,
                                                                    Sales_Copy = c1.SalesCopy
                                                                 }).ToList());
                            break;
                        case 4:
                            ShowInfo(dataGridViewGameMode, (from c1 in db.GameMode
                                                            select new
                                                            {
                                                                Id_GameMode = c1.GameModeId,
                                                                Name_GameMode = c1.Name
                                                            }).ToList());
                            break;



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInfo<T>(DataGridView dataGridView, List<T> sql)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = sql;
        }

        private void FormTestCodeFirst_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SqlServer = textBoxNameSQLServer.Text;
            Properties.Settings.Default.NameDB = textBoxNameDB.Text;
            Properties.Settings.Default.Login = textBoxLogin.Text;
            Properties.Settings.Default.Password = textBoxPassword.Text;
            Properties.Settings.Default.Save();
        }
    }
}
