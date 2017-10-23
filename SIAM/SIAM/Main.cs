using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SIAM
{
    public partial class Main : Form
    {
        string nim, password;
        public Main(string nim, string password)
        {
            InitializeComponent();
            this.nim = nim;
            this.password = password;
        }

        private void btnKRS_Click(object sender, EventArgs e)
        {

        }

        private void btnRHS_Click(object sender, EventArgs e)
        {
            FormRekapHasilStudi formRHS = new FormRekapHasilStudi(this.nim);
            formRHS.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //HttpWebRequest http = (HttpWebRequest)WebRequest.Create("https://tanikita.000webhostapp.com/biodata.php?nim=" + nim + "&password=" + password);

            //WebResponse response = http.GetResponse();

            //Stream stream = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream);
            //String content = sr.ReadToEnd();
            //JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            //Biodata biodata = json_serializer.Deserialize<Biodata>(content);

            //if (biodata.nama != null)
            //{
            //    lblNIM.Text = biodata.nim;
            //    lblNama.Text = biodata.nama;
            //    lblJurusan.Text += biodata.jurusan;
            //    lblProgstud.Text += biodata.progstud;
            //    lblJenjang.Text += biodata.jenjang;
            //}


            //http = (HttpWebRequest)WebRequest.Create("https://tanikita.000webhostapp.com/gambar.php?nim=" + nim + "&password=" + password);

            //response = http.GetResponse();

            //stream = response.GetResponseStream();
            //sr = new StreamReader(stream);
            //content = sr.ReadToEnd();
            //json_serializer = new JavaScriptSerializer();
            //Gambar gambar = json_serializer.Deserialize<Gambar>(content);
            //pbGambar.ImageLocation = gambar.alamat;
            //pbGambar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    class Biodata
    {
        public string nim { get; set; }
        public string nama { get; set; }
        public string jenjang { get; set; }
        public string jurusan { get; set; }
        public string progstud { get; set; }
    }
    class Gambar
    {
        public string alamat { get; set; }
    }
}
