using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace clvbrew_wpf
{
    public partial class clvbrew : Form
    {
        public clvbrew()
        {
            InitializeComponent();
        }

        private void obfuscate_Click(object sender, EventArgs e)
        {
            // suck my ass
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
                    noCompressBS = compBytecode.Checked,
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
    }
}
