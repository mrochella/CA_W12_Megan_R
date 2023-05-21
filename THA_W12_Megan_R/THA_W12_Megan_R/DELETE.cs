using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W12_Megan_R
{
    public partial class DELETE : Form
    {
        MySqlConnection MySqlConnection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader Reader;

        int check = 0;
        string delPlayer;
        DataTable dtCbox = new DataTable();
        DataTable dtPlayer = new DataTable();
        public DELETE()
        {
            try
            {
                string connection = "server=localhost;uid=root;pwd=Meganmegan2009;database=premier_league";
                MySqlConnection = new MySqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void DELETE_Load(object sender, EventArgs e)
        {
            string query5 = "SELECT team_id,team_name FROM team;";
            Command = new MySqlCommand(query5, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtCbox);
            comboBox_tID.DataSource = dtCbox;
            comboBox_tID.ValueMember = "team_id";
            comboBox_tID.DisplayMember = "team_name";
        }

        private void comboBox_tID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            try
            {
                string chooseteam = $"SELECT p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate FROM player p, team t,nationality n WHERE p.team_id = t.team_id AND p.status = 1 AND t.team_id = '{comboBox_tID.SelectedValue.ToString()}' and n.nationality_id=p.nationality_id;";
                Command = new MySqlCommand(chooseteam, MySqlConnection);
                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(dtPlayer);
                dataGridView4.DataSource = dtPlayer;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPlayer.Rows.Count; i++)
            {
                check++;
            }
            if (check > 11)
            {
                string delete = $"UPDATE player SET status=0 WHERE player_name='{delPlayer}';";
                try
                {
                    MySqlConnection.Open();
                    Command = new MySqlCommand(delete, MySqlConnection);
                    Reader = Command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dtPlayer.Clear();
                    MySqlConnection.Close();

                    string team = $"SELECT p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate FROM player p, team t,nationality n WHERE p.team_id = t.team_id AND p.status = 1 AND t.team_id = '{comboBox_tID.SelectedValue.ToString()}' AND n.nationality_id = p.nationality_id;";
                    Command = new MySqlCommand(team, MySqlConnection);
                    DataAdapter = new MySqlDataAdapter(Command);
                    DataAdapter.Fill(dtPlayer);
                    dataGridView4.DataSource = dtPlayer;
                }
            }
            else
            {
                string msg = "Sorry! cannot remove player if less than 11.";
                MessageBox.Show(msg);
            }
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            delPlayer = dataGridView4.CurrentCell.Value.ToString();
        }
    }
}
