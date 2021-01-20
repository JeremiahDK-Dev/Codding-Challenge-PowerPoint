using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.SqlServer.Server;
using System.Net.Http;
using Google.API.Search;
using Google.API;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;

namespace Codding_Challenge_PowerPoint
{
    public partial class ImageGenerator : Form
    {
        private List<string> _topics = new List<string> { "dog", "car", "truck", "cat", "florida" };
        public List<string> _searchTerms = new List<string>();

        public string _titleText;
        // public TextBox boldText;
        public bool bold = false;
        public bool itallic = false;
        public bool strikeout = false;
        public bool underline = false;
        public Image img;
        public bool groupenable = false;
        

        public DataGridView dlSearch;
        

        public RichTextBox _textBox;
        // public byte[] address = null;


        public ImageGenerator()
        {
            /*
            form2 = new ImageResults();
            form2.titleText = _titleText;
            */
            
            InitializeComponent();
           
            _titleText = textBox2.Text;

           
            


           


        }

        






        private void Form1_Load(object sender, EventArgs e)
        {
            string templateUrl = @"https://www.google.co.uk/search?q={0}&tbm=isch&site=imghp";
            
           // _boldText.Add(textBox2.Text.ToString());

        }

     
        

        [System.ComponentModel.Browsable(false)]
        public override bool AutoSize { get; set; }

        private void BoldCheck(object sender, EventArgs e)
        {
            if (boldBox.Checked == true)
            {
                bold = true;
            }
            else
            {
                bold = false;
            }
        }

        private void ItalicCheck(object sender, EventArgs e)
        {
            if (italicBox.Checked == true)
            {
                itallic = true;
            }
            else
            {
                itallic = false;
            }
        }

        private void StrikeoutCheck(object sender, EventArgs e)
        {
            if (strikeoutBox.Checked == true)
            {
                strikeout = true;
            }
            else
            {
                strikeout = false;
            }
        }

        private void UnderLineCheck(object sender, EventArgs e)
        {

            if (underlineBox.Checked == true)
            {
                underline = true;
            }
            else
            {
                underline = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupenable == false)
            {
                groupBox1.Enabled = false;
                groupBox1.Visible = false;
                groupenable = true;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
                groupenable = false;
            }
        }

        private string GetHtmlCode()
        {
            var rnd = new Random();

        
            int topic = rnd.Next(0, _searchTerms.Count - 1);

            string url = "https://www.google.com/search?q=" + _searchTerms[topic] + "&tbm=isch";
            string data = "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return "";
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }

        public List<string> GetUrls(string html)
        {
            
            var urls = new List<string>();

            string search = @",""ou"":""(.*?)"",";
            MatchCollection matches = Regex.Matches(html, search);

            foreach (Match match in matches)
            {
                urls.Add(match.Groups[1].Value);
            }

            return urls;
        }

   

        private byte[] GetImage(string url)
        {


            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000000);

                    return bytes;
                }
            }

            return null;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //Two Attempts On using Google Api's to get search images and displaying them in ImageResults Page When Generate Button Is Clicked//
           // _searchTerms.Add(textBox2.Text.ToString());
            if (_searchTerms.Count <= 0)
                {
                    System.Windows.MessageBox.Show("Please add Title or Body text"; return;
                } /*
                else
                {

                    string html = GetHtmlCode();
                    List<string> urls = GetUrls(html);
                    var rnd = new Random();
                int randomUrl = rnd.Next(0, urls.Count);

                string luckyUrl = urls[randomUrl];

                byte[] image = GetImage(luckyUrl);

                using (var ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                if (urls.Count <= 0)
                    {
                        System.Windows.MessageBox.Show("URLs Count is zero" + urls.Count.ToString()); return;
                    }
                    else
                    {
                       

                    }

                } */

            ControllerSlide.titleText = textBox2.Text.ToString();
            ControllerSlide.bodyText = richTextBox1.Text.ToString();
           ImageResults form2 = new ImageResults();
            form2.Show();

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _titleText = textBox2.Text;
            _searchTerms.Add(textBox2.Text.ToString());
        }

        /*
        private void CheckTextStyleChange()
        {
            //Checks To See If The Static Variable Fonts Are Active Or Not And Switches Text Font Accordingly//
           RichTextBox _richTextBox1 = richTextBox1;
            if (ControllerSlide.bold == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Bold);
            }
            else if (ControllerSlide.itallic == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Italic);
            }
            else if (ControllerSlide.strikeout == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Strikeout);
            }
            else if (ControllerSlide.underline == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Underline);
            }
            else
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Regular);
            }
        } */
          
        private void BodyTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //Add The Bold Text In Rich Box To A List Of A String To Then Later Be Used In The Image Suggestion Search//
            if (ControllerSlide.bold == true)
            {
                this.richTextBox1.Select();
                this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Bold);
                _searchTerms.Add(richTextBox1.Text.ToString());
            }
            else if (ControllerSlide.itallic == true)
            {
                this.richTextBox1.Select();
                this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Italic);
            }
            else if (ControllerSlide.strikeout == true)
            {
                this.richTextBox1.Select();
                this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Strikeout);
            }
            else if (ControllerSlide.underline == true)
            {
                this.richTextBox1.Select();
                this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Underline);
            }
            else
            {
                this.richTextBox1.Select();
                this.richTextBox1.SelectionFont = new Font(richTextBox1.Font, System.Drawing.FontStyle.Regular);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
