using System;
using EmpireGUI.Objects;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace EmpireGUI
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            Globals.serverIP = txtServerAddress.Text;
            Globals.serverPort = txtServerPort.Text;
            if (tglAPI.Checked == true)
            {
                try
                {
                    Globals.apitoken = txtAPIToken.Text;
                    string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/version?" + Globals.apitoken;
                    WebClient wc = new WebClient();
                    wc.Headers[HttpRequestHeader.ContentType] = @"application/json";
                    wc.Headers[HttpRequestHeader.UserAgent] = "Empire GUI 1.0";
                    string results = wc.DownloadString(uri);
                    JObject token = JObject.Parse(results);
                    JToken apikey = token["version"];
                    Globals.apitoken = apikey.ToString();
                    frmMain mainfrm = new frmMain();
                    mainfrm.Show();
                    this.Close();

                }
                catch (WebException ex)
                {
                    EmpireGUI.frmMain.displayCustomAlert("(" + ex.Status + ") " + ex.Message);
                    return;
                }
                Globals.apitoken = txtAPIToken.Text;
            }
            else if (tglAPI.Checked == false)
            {
                try
                {
                    string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/admin/login";
                    WebClient wc = new WebClient();
                    string json = @"{""username"":""" + txtUsername.Text + @""", ""password"":""" + txtPassword.Text + @"""}";
                    wc.Headers[HttpRequestHeader.ContentType] = @"application/json";
                    wc.Headers[HttpRequestHeader.UserAgent] = "Empire GUI 1.0";
                    string results = wc.UploadString(uri, json);
                    JObject token = JObject.Parse(results);
                    JToken apikey = token["token"];
                    Globals.apitoken = apikey.ToString();

                }
                catch (WebException ex)
                {
                    //ToDO: Different Error messages depending on reasoning.
                    EmpireGUI.frmMain.displayCustomAlert("(" + ex.Status + ") " + ex.Message);
                    return;
                }
                frmMain mainfrm = new frmMain();
                mainfrm.Show();
                this.Dispose();
            }
        }
        private void tglAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAPI.Checked == true)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else if (tglAPI.Checked == false)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("What did you even do?");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
