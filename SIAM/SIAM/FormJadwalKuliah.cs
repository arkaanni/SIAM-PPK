using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAM
{
    public partial class FormJadwalKuliah : Form
    {
        public FormJadwalKuliah()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormJadwalKuliah_Load(object sender, EventArgs e)
        {
            DataTable mahasiswa = new DataTable();

            mahasiswa.Columns.Add("HARI", typeof(string));
            mahasiswa.Columns.Add("JAM", typeof(string));
            mahasiswa.Columns.Add("KODE", typeof(string));
            mahasiswa.Columns.Add("MATA KULIAH", typeof(string));
            mahasiswa.Columns.Add("THN KURIKULUM", typeof(string));
            mahasiswa.Columns.Add("DOSEN", typeof(string));
            mahasiswa.Columns.Add("RUANG", typeof(string));
            mahasiswa.Columns.Add("PENGUMUMAN", typeof(String));

            mahasiswa.Rows.Add("Senin","09.30-11.59","CIF61252","Pengenalan Pola","2016","", "Ged E PTIIK-E2.1", "");
            mahasiswa.Rows.Add("Selasa", "09.30-11.59", "CIF61252", "Logika Fuzzy", "2016", "", "Ged E PTIIK-E2.1", "");
            dataGridView1.DataSource = mahasiswa;
        }

        private void lbKeluar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
