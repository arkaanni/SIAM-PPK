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
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Collections;

namespace SIAM
{
    public partial class FormRekapHasilStudi : Form
    {

        private DataTable tabelRHS;
        private String nim, password;
        private String endpoint = "https://tanikita.000webhostapp.com/rekap.php?";

        public FormRekapHasilStudi(String nim, String password)
        {
            InitializeComponent();
            this.nim = nim;
            this.password = password;
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
                GetRekapHasilStudi(nim, password);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void GetRekapHasilStudi(String nim, String password)
        {
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(endpoint + "nim=" + nim + "&password=" + password);
            http.UserAgent = "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)";

            WebResponse responseRekap = http.GetResponse();

            Stream stream = responseRekap.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            String content = sr.ReadToEnd();
            var json_serializer = new JavaScriptSerializer();

            // ngebenerin json respone pake regex
            // stackoverflow.com/questions/39516952/invalid-array-passed-in-extra-trailing-getting-this-error-when-deserializi

            var rx = new Regex(@",(\s*[\]}])", RegexOptions.Multiline);
            content = rx.Replace(content, "$1");

            dynamic rhs = json_serializer.DeserializeObject(content);

            //get length
            int length = ((ICollection)rhs).Count;

            //MessageBox.Show(length.ToString());

            for (int i = 0; i < length; i++)
            {
                dataGridViewRHS.Rows.Add(rhs[i]["kode"], rhs[i]["matkul"], rhs[i]["sks"], rhs[i]["tahun"], rhs[i]["nilai"]);
            }
        }
    }
}
