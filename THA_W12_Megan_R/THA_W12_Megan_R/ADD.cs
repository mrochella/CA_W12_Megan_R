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
    public partial class ADD : Form
    {
        MySqlConnection MySqlConnection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader Reader;

        DataTable dtPlayer = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();
        public ADD()
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

        private void ADD_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT nationality_id,nation FROM nationality;";
            Command = new MySqlCommand(query1, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtNationality);
            comboBox_nat.DataSource = dtNationality;
            comboBox_nat.ValueMember = "nationality_id";
            comboBox_nat.DisplayMember = "nation";

            string query2 = "SELECT team_id,team_name FROM team;";
            Command = new MySqlCommand(query2, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtTeam);
            comboBox_tName.DataSource = dtTeam;
            comboBox_tName.ValueMember = "team_id";
            comboBox_tName.DisplayMember = "team_name";
        }

        private void updateP()
        {
            dtPlayer.Clear();
            try
            {
                string playerdata = "SELECT * FROM player";
                Command = new MySqlCommand(playerdata, MySqlConnection);
                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(dtPlayer);
                dataGridView_add.DataSource = (dtPlayer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string player_id = textBox_pid.Text;
            string player_name = textBox_name.Text;
            string team_number = textBox_tNum.Text;
            string nationality_id = comboBox_nat.SelectedValue.ToString();
            string playing_pos = textBox_pos.Text;
            string height = textBox_height.Text;
            string weight = textBox_weight.Text;
            string birthdate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string teamname = comboBox_tName.SelectedValue.ToString();

            string add = $"INSERT into player values('{player_id}','{team_number}','{player_name}','{nationality_id}','{playing_pos}','{height}','{weight}','{birthdate}','{teamname}',1,0)";
            try
            {
                MySqlConnection.Open();
                Command = new MySqlCommand(add, MySqlConnection);
                Reader = Command.ExecuteReader();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            finally
            {
                MySqlConnection.Close();
                updateP();

                textBox_pid.Text = "";
                textBox_name.Text = "";
                textBox_tNum.Text = "";
                comboBox_nat.Text = "";
                textBox_pos.Text = "";
                textBox_height.Text = "";
                textBox_weight.Text = "";
                comboBox_tName.Text = "";
            }
        }
    }
}
