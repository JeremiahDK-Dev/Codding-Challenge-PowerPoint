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


        public Image imageResult1;
        public string titleText;
        public string boldTexts;
        private bool imageChosen = false;
        public List<Form> formList = new List<Form>();
        public Slide1 slide1;
        public ImageGenerator imageGenerator = new ImageGenerator();

        public ImageResults()
        {
           
            
            InitializeComponent();
            

      
        }

        private void GenerateSlideButton_Click(object sender, EventArgs e)
        {
            var rng = new Random();

            if(imageChosen == false)
            {
                System.Windows.MessageBox.Show("Must chose a Background, Click on a Background");
            }
            else
            {


                int randomSlide = rng.Next(1, 3);

                if(randomSlide == 1)
                {
                    Slide1 slide1 = new Slide1();
                    slide1.Show();
                }else if(randomSlide == 2)
                {
                    Slide2 slide2 = new Slide2();
                    slide2.Show();
                }else if(randomSlide == 3)
                {
                    Slide3 slide3 = new Slide3();
                    slide3.Show();
                }

                
                this.Close();
            }
           
        }

        private void ImageResults_Load(object sender, EventArgs e)
        {
            imageChosen = false;
        }
        //All Functions That Would Of Handled The Image to Slide Background.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox1.BackgroundImage;
            
            //imageResult1 = pictureBox1.Image;
            imageChosen = true;
          
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
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox2.BackgroundImage;
            imageChosen = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox3.BackgroundImage;
            imageChosen = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox4.BackgroundImage;
            imageChosen = true;
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox5.BackgroundImage;
            imageChosen = true;
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox6.BackgroundImage;
            imageChosen = true;
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox7.BackgroundImage;
            imageChosen = true;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ControllerSlide.pictureBox1Reference.BackgroundImage = pictureBox8.BackgroundImage;
            imageChosen = true;
            
        }
    }
}
