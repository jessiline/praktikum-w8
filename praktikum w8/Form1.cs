using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum_w8
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //data koneksi ke dbms
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable player = new DataTable();
            DataTable playerKanan = new DataTable();
            sqlQuery = "select team_name as 'Nama Tim', team_id as 'ID Team' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);

            sqlQuery = "select team_name as 'Nama Tim', team_id as 'ID Team' from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(playerKanan);
            
            comboBoxKiri.DataSource = player;
            comboBoxKiri.DisplayMember = "Nama Tim" ;
            comboBoxKiri.ValueMember = "Nama Tim";

            comboBoxKanan.DataSource = playerKanan;
            comboBoxKanan.DisplayMember = "Nama Tim";
            comboBoxKanan.ValueMember = "Nama Tim";
           
        }

        private void comboBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dtManager = new DataTable();
                sqlQuery = "select p.player_name , m.manager_name, concat(t.home_stadium, ',', t.city), t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + comboBoxKiri.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtManager);
                labelManagerKiri.Text = dtManager.Rows[0][1].ToString();
                labelKaptenKiri.Text = dtManager.Rows[0][0].ToString();
                labelstadium.Text = dtManager.Rows[0][2].ToString();
                labelkapasitas.Text = dtManager.Rows[0][3].ToString();
                ////dari sini
                //sqlQuery = "select manager_name as `Manager` from manager m ,team t where t.team_name = '" + comboBoxKiri.SelectedValue.ToString() + "' and m.manager_id = t.manager_id ";
                //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtManager);
                ////sampai sini
                //labelManagerKiri.Text = dtManager.Rows[0]["Manager"].ToString();

                //sqlQuery = "select p.player_name, as `Player` from player p ,team t where t.captain_id = p.player_id and t.team_name = '" + comboBoxKiri.SelectedValue + "'";
                //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //sqlAdapter.Fill(dtKapten);
                //labelKaptenKiri.Text = dtKapten.Rows[0]["Player"].ToString();

            }
            catch (Exception )
            {
               

            }
            

        }

        private void comboBoxKiri_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtManager = new DataTable();
                sqlQuery = "select p.player_name , m.manager_name, concat(t.home_stadium, ',', t.city), t.capacity from team t, manager m, player p WHERE t.manager_id = m.manager_id and t.captain_id = p.player_id and team_name = '" + comboBoxKanan.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtManager);
                labelManagerKanan.Text = dtManager.Rows[0][1].ToString();
                labelKaptenKanan.Text = dtManager.Rows[0][0].ToString();
            }
            catch (Exception)
            {


            }
        }

        private void labelKaptenKiri_Click(object sender, EventArgs e)
        {

        }
    }
}
