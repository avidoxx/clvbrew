using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using clvbrew.Properties;

namespace clvbrew
{
    public partial class clvbrew : Form
    {
        public clvbrew()
        {
            InitializeComponent();
        }

        private void obfuscate_Click(object sender, EventArgs e)
        {
            if(apikey.Text == "" || apikey.Text == null) return;
            if (apikey.Text.Length < 32) return;
            var source = fastColoredTextBox1.Text;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://ibidk.herokuapp.com/obfuscate-key");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    key = apikey.Text,
                    encAllStrings = encStrings.Checked,
                    encImportantStrings = encImpStrings.Checked,
                    noControlFlow = !obfCtrlFlow.Checked,
                    debugInfo = prsvLnInfo.Checked,
                    noCompressBS = !compBytecode.Checked,
                    script = source
                });
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            fastColoredTextBox1.Text = result;
        }

        private string Base64Encode(string plainText)
        {
            string result = "";
            try
            {
                byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                result = System.Convert.ToBase64String(plainTextBytes);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = "";
            }
            return result;
        }

        private string Base64Decode(string base64EncodedData)
        {
            string result = "";
            try
            {
                byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                result = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = "";
            }
            return result;
        }

        private void clvbrew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.API_Key = Base64Encode(apikey.Text);
            Settings.Default.encStrings = encStrings.Checked;
            Settings.Default.encImpStrings = encImpStrings.Checked;
            Settings.Default.obfCtrlFlow = obfCtrlFlow.Checked;
            Settings.Default.compBytecode = compBytecode.Checked;
            Settings.Default.prsvLnInfo = prsvLnInfo.Checked;
            Settings.Default.script = Base64Encode(fastColoredTextBox1.Text);
            Settings.Default.Save();
        }

        private void clvbrew_Load(object sender, EventArgs e)
        {
            apikey.Text = Base64Decode(Settings.Default.API_Key);
            encStrings.Checked = Settings.Default.encStrings;
            encImpStrings.Checked = Settings.Default.encImpStrings;
            obfCtrlFlow.Checked = Settings.Default.obfCtrlFlow;
            compBytecode.Checked = Settings.Default.compBytecode;
            prsvLnInfo.Checked = Settings.Default.prsvLnInfo;
            fastColoredTextBox1.Text = Base64Decode(Settings.Default.script);
        }
    }
}
