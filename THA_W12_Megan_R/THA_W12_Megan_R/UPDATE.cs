using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W12_Megan_R
{
    public partial class UPDATE : Form
    {
        MySqlConnection MySqlConnection;
        MySqlCommand Command;
        MySqlDataAdapter DataAdapter;
        MySqlDataReader Reader;

        string mname;
        DataTable dtManager = new DataTable();
        DataTable dtManager2 = new DataTable();
        DataTable dtCbox = new DataTable();
        DataTable dtCbox2 = new DataTable();
        public UPDATE()
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

        private void button_update_Click(object sender, EventArgs e)
        {
            dtManager2.Clear();

            string mID = $"SELECT manager_id from manager WHERE manager_name='{mname}';";
            Command = new MySqlCommand(mID, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtManager2);

            string updateM = dtManager.Rows[0][0].ToString();
            string id = dtManager2.Rows[0][0].ToString();

            string update = $"UPDATE team t, manager mright, manager mleft SET t.manager_id='{id}', mleft.working=1, mright.working=0 WHERE mright.manager_name='{updateM}' AND mleft.manager_id='{id}' AND t.team_id='{comboBox_tName.SelectedValue.ToString()}';";
            try
            {
                MySqlConnection.Open();
                Command = new MySqlCommand(update, MySqlConnection);
                Reader = Command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MySqlConnection.Close();
                dtManager.Clear();
                dtCbox2.Clear();

                //CURRENT TEAM MANAGER = 1
                string em = $"SELECT m.manager_name,t.team_name,m.birthdate,n.nation FROM manager m,team t,nationality n WHERE m.manager_id=t.manager_id AND n.nationality_id=m.nationality_id AND t.team_id='{comboBox_tName.SelectedValue.ToString()}';";
                Command = new MySqlCommand(em, MySqlConnection);
                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(dtManager);
                dataGridView1.DataSource = dtManager;

                //MANAGERS NOT WORKING = 0
                string emm = "SELECT m.manager_name,m.birthdate,n.nation from manager m,nationality n WHERE m.working=0 AND m.nationality_id=n.nationality_id;";
                Command = new MySqlCommand(emm, MySqlConnection);
                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(dtCbox2);
                dataGridView2.DataSource = dtCbox2;

                mname = "";
            }
        }

        private void UPDATE_Load(object sender, EventArgs e)
        {
            string query3 = "SELECT team_id,team_name FROM team;";
            Command = new MySqlCommand(query3, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtCbox);
            comboBox_tName.DataSource = dtCbox;
            comboBox_tName.ValueMember = "team_id";
            comboBox_tName.DisplayMember = "team_name";

            string query4 = "SELECT m.manager_name, m.birthdate, n.nation FROM manager m, nationality n WHERE m.working=0 and m.nationality_id=n.nationality_id;";
            Command = new MySqlCommand(query4, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtCbox2);

            dataGridView2.DataSource = dtCbox2;
        }

        private void comboBox_tName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtManager.Clear();

            string query = $"SELECT m.manager_name,t.team_name,m.birthdate,n.nation FROM manager m,team t,nationality n WHERE m.manager_id=t.manager_id AND n.nationality_id=m.nationality_id AND t.team_id='{comboBox_tName.SelectedValue.ToString()}';";
            Command = new MySqlCommand(query, MySqlConnection);
            DataAdapter = new MySqlDataAdapter(Command);
            DataAdapter.Fill(dtManager);
            dataGridView1.DataSource = dtManager;
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //LABEL BERUBAH MENJADI NAMA MANAGER YANG DIPILIH
            mname = dataGridView2.CurrentCell.Value.ToString();
            label_mName.Text = mname;
        }
    }
}
