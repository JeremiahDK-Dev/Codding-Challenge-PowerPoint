using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Google.API.Search;
namespace Codding_Challenge_PowerPoint
{
    public partial class ImageResults : Form
    {


        public PictureBox imageResult1;
        public string titleText;
        public string boldTexts;
        public ImageGenerator imageGenerator = new ImageGenerator();

        public ImageResults()
        {
           
            
            InitializeComponent();


      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        //All Functions That Would Of Handled The Image to Slide Background.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox1.BackColor;
           
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ImageGenerator imageGenerator = new ImageGenerator();
            RichTextBox richTextBox1 = imageGenerator._textBox;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Title", typeof(string)));
            dt.Columns.Add(new DataColumn("OriginalContextUrl", typeof(string)));
            dt.Columns.Add(new DataColumn("Url", typeof(string)));
            GimageSearchClient client = new GimageSearchClient("www.c-sharpcorner.com");
            IList<IImageResult> results = client.Search(richTextBox1.Text, 30);
            foreach (IImageResult result in results)
            {
                DataRow dr = dt.NewRow();
                dr["Title"] = result.Title.ToString();
                dr["OriginalContextUrl"] = result.OriginalContextUrl;
                dr["Url"] = result.Url;
                dt.Rows.Add(dr);
            }
        //   DataGridView  dlSearch = dataGridView1;
            
           // dlSearch.DataSource = dt;
           // dlSearch.DataBindings();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox2.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox3.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox4.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox5.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox6.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox7.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackColor = pictureBox8.BackColor;
        }
    }
}
