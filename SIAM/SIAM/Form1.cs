using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace SIAM
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            String nim = tbNIM.Text;
            String password = tbPassword.Text;
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create("https://tanikita.000webhostapp.com/index.php?nim=" + tbNIM + "&password=" + tbPassword);
            http.UserAgent = "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)";

            WebResponse response = http.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            String content = sr.ReadToEnd();
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            Auth dc = json_serializer.Deserialize<Auth>(content);

            if (dc.PHPSESSID.Length > 0)
            {
                Main main = new Main(nim, password);
                main.Show();
                this.Visible = false;
            }
            
        }
    }
    class Auth
    {
        public string PHPSESSID { get; set; }
    }

}
