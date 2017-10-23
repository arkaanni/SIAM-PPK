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

namespace SIAM
{
    public partial class FormRekapHasilStudi : Form
    {

        private DataTable tabelRHS;
        private String nim;

        //connection info
        //seuaikan Dan
        private String username = "root";
        private String password = "";
        private String datasource = "localhost";
        private String port = "3306";
        private String database = "siam_ppk";

        private MySqlConnection conn;

        public FormRekapHasilStudi(String nim)
        {
            InitializeComponent();
            this.nim = nim;
            conn = MakeConnection(datasource, port, username, password, database);
        }
        
        private void FormRekapHasilStudi_Load(object sender, EventArgs e)
        {
            tabelRHS = new DataTable("Rekap Hasil Studi");
            
            dataGridViewRHS.Columns.Add("kode_mk", "Kode MK");
            dataGridViewRHS.Columns.Add("mk", "Mata Kuliah");
            dataGridViewRHS.Columns.Add("jumlah_sks", "Jumlah SKS");
            dataGridViewRHS.Columns.Add("tahun_akademik", "Tahun Akademik");
            dataGridViewRHS.Columns.Add("nilai", "Nilai");

            try
            {
                conn.Open();

                GetRekapHasilStudi(nim);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //method untuk buat koneksi
        private MySqlConnection MakeConnection(String datasource, String port, String username, String password, String database)
        {
            String cred = "datasource=" + datasource + ";" + "port=" + port + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database + ";";

            return new MySqlConnection(cred);
        }

        private void GetRekapHasilStudi(String nim)
        {
            //query nya juga disesuaikan
            String q = "SELECT * FROM rekap_hasil_studi WHERE nim='" + nim + "'";
            MySqlDataAdapter adapter;

            MySqlCommand getRHSCommand = new MySqlCommand(q, conn);
            adapter = new MySqlDataAdapter(getRHSCommand);

            adapter.Fill(tabelRHS);
            getRHSCommand.ExecuteNonQuery();

            foreach (DataRow row in tabelRHS.Rows)
            {
                dataGridViewRHS.Rows.Add(row[2], row[3], row[4], row[5], row[6]);
            }

            conn.Close();

            adapter.Dispose();
        }
    }
}
