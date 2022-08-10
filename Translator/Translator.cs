using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NAudio.Wave;

namespace Translator
{
    public partial class Translator : Form
    {

        public Translator()
        {
            InitializeComponent();
            AddItems();
        }
        private void AddItems()
        {
            this.input_select.Items.Add("English");
            this.input_select.Items.Add("Persian");
            this.input_select.Items.Add("Chinese");
            this.input_select.Items.Add("Hindi");
            this.input_select.Items.Add("Spanish");
            this.input_select.Items.Add("Ukrainian");
            this.input_select.Items.Add("Russian");
            this.input_select.Items.Add("Arabic");
            this.input_select.Items.Add("German");
            this.input_select.Items.Add("French");

            this.output_select.Items.Add("English");
            this.output_select.Items.Add("Persian");
            this.output_select.Items.Add("Chinese");
            this.output_select.Items.Add("Hindi");
            this.output_select.Items.Add("Spanish");
            this.output_select.Items.Add("Ukrainian");
            this.output_select.Items.Add("Russian");
            this.output_select.Items.Add("Arabic");
            this.output_select.Items.Add("German");
            this.output_select.Items.Add("French");

            this.input_select.SelectedItem = "Persian";
            this.output_select.SelectedItem = "English";
        }

        private string getLanguage(string language)
        {
            string result = null;
            if (language == "English")
            {
                result = "en";
            }
            else if (language == "Persian")
            {
                result = "fa";
            }
            else if (language == "Chinese")
            {
                result = "zh-CN";
            }
            else if (language == "Hindi")
            {
                result = "hi";
            }
            else if (language == "Spanish")
            {
                result = "es";
            }
            else if (language == "Russian")
            {
                result = "ru";
            }
            else if (language == "Ukrainian")
            {
                result = "uk";
            }
            else if (language == "Arabic")
            {
                result = "ar";
            }
            else if (language == "German")
            {
                result = "de";
            }
            else if (language == "French")
            {
                result = "fr";
            }
            return result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Guid TranslationGuid
        {
            get;
            private set;
        }

        public string TranslateText(string text)
        {
            string translatetext = null;
            this.TranslationGuid = Guid.NewGuid();
            try
            {
                string input_s = input_select.GetItemText(input_select.SelectedItem);
                string output_s = output_select.GetItemText(output_select.SelectedItem);
                string source = getLanguage(input_s);
                string target = getLanguage(output_s);
                var data = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", source, target, input.Text);
                string file = Path.Combine(Path.GetTempPath(), TranslationGuid.ToString());
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    wc.DownloadFile(data, file);
                }
                if (File.Exists(file))
                {
                    string textof = File.ReadAllText(file);

                    var jsonObject = JsonConvert.DeserializeObject<JArray>(textof);

                    foreach (var item in jsonObject[0])
                    {
                        translatetext += item[0];
                    }
                }
            }
            catch
            {
                // Nothing XD
            }
            return translatetext;
        }

        private void translate_button_Click(object sender, EventArgs e)
        {
            try
            {
                string text = input.Text;
                Console.WriteLine(text);
                string callback = TranslateText(text);
                output.Text = callback;
                notification.Visible = false;
            }
            catch
            {
                ShowNotification("Enter text for translate !");
            }
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(output.Text);
                notification.Visible = false;
            } catch
            {
                ShowNotification("Enter text for translate !");
            }
        }

        private void speak_Click(object sender, EventArgs e)
        {
            try
            {
                string output_s = output_select.GetItemText(output_select.SelectedItem);
                string target = getLanguage(output_s);
                var url = string.Format("https://translate.google.com/translate_tts?ie=UTF-8&tl={0}&client=tw-ob&q={1}", target, output.Text);
                using (var mf = new MediaFoundationReader(url))
                using (var wo = new WasapiOut())
                {
                    wo.Init(mf);
                    wo.Play();
                    notification.Visible = false;
                    while (wo.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(0);
                    }
                }
            }
            catch
            {
                // No Error Or Notif
            }
        }

        private void ShowNotification(string text)
        {
            notification.Visible = true;
            notification.Text = text;
        }

        private void swap_Click(object sender, EventArgs e)
        {
            string input_s = input_select.GetItemText(input_select.SelectedItem);
            string output_s = output_select.GetItemText(output_select.SelectedItem);
            this.input_select.SelectedItem = output_s; this.output_select.SelectedItem = input_s;

            string main   = input.Text;
            string export = output.Text;
            input.Text = export;  output.Text = main;
        }
    }
}
