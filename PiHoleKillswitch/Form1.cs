using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace PiHoleKillswitch
{
    public partial class form_PiHoleKillswitch : Form
    {
        bool piHoleDisabled = false;
        public form_PiHoleKillswitch()
        {
            InitializeComponent();
            txtBox_Token.Text = Properties.Settings.Default.apiToken;
            txtBox_IPPiHole.Text = Properties.Settings.Default.ipPiHole;
            piHoleDisabled = Properties.Settings.Default.piHoleDisabled;
            txtBox_TimeToDeactivateInSeconds.Value = Properties.Settings.Default.TimeToDeactivateInSeconds;
            this.Size = new System.Drawing.Size(323, 225);
            if (piHoleDisabled == false)
            {
                btn_run.Text = "Pi-hole deaktivieren";
            }
            else
            {
                btn_run.Text = "Pi-hole aktivieren";
            }
        }

        private void chkBox_showSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_showSettings.Checked == true)
            {
                this.Size = new System.Drawing.Size(323, 335);
            }
            else if (chkBox_showSettings.Checked == false)
            {
                this.Size = new System.Drawing.Size(323, 225);
            }
        }

        private void btn_saveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.apiToken = txtBox_Token.Text;
            Properties.Settings.Default.ipPiHole = txtBox_IPPiHole.Text;
            Properties.Settings.Default.Save();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (txtBox_Token.Text == "" && txtBox_IPPiHole.Text =="")
            {
                txtBox_response.Text = "Es wurde kein API Token und keine IP-Adresse hinterlegt.";
            }
            else if (txtBox_Token.Text == "")
            {
                txtBox_response.Text = "Es wurde kein API Token hinterlegt.";
            }
            else if (txtBox_IPPiHole.Text == "")
            {
                txtBox_response.Text = "Es wurde keine IP-Adresse hinterlegt.";
            }
            else
            {
                string url = null;
                if (piHoleDisabled == false)
                {
                    url = "http://" + txtBox_IPPiHole.Text + "/admin/api.php?disable=" + txtBox_TimeToDeactivateInSeconds.Value + "&auth=" + txtBox_Token.Text;
                }
                else
                {
                    url = "http://" + txtBox_IPPiHole.Text + "/admin/api.php?enable=&auth=" + txtBox_Token.Text;
                }
                WebResponse response = null;
                string data = string.Empty;
                try
                {
                    WebRequest request = WebRequest.Create(url);
                    request.Timeout = 5000;
                    response = request.GetResponse();
                    txtBox_response.Text = request.GetResponse().ToString();
                }
                catch (WebException ee)
                {
                    txtBox_response.Text = "Fehler aufgetreten:\r\n" + ee.Message;
                }

                catch (Exception ex)
                {
                    txtBox_response.Text = "Fehler aufgetreten:\r\n" + ex.Message;
                }
                finally
                {
                    if (response != null)
                    {
                        if (piHoleDisabled == false)
                        {
                            txtBox_response.Text = "Erfolgreich ausgeführt.\r\nDas Pi-hole wurde für " + txtBox_TimeToDeactivateInSeconds.Value + " Sekunden deaktiviert.";
                            btn_run.Text = "Pi-hole aktivieren";
                        } else
                        {
                            txtBox_response.Text = "Erfolgreich ausgeführt.\r\nDas Pi-hole wurde aktiviert.";
                            btn_run.Text = "Pi-hole deaktivieren";
                        }
                        response.Close();
                        piHoleDisabled = !piHoleDisabled;
                        Properties.Settings.Default.piHoleDisabled = piHoleDisabled;
                        Properties.Settings.Default.TimeToDeactivateInSeconds = txtBox_TimeToDeactivateInSeconds.Value;
                        Properties.Settings.Default.Save();


                    }
                    else
                    {
                        txtBox_response.Text = "Keine Antwort vom Pi-hole erhalten oder die IP-Adresse ist fehlerhaft.";
                    }
                }
            }
        }
    }
}
