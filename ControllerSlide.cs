using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Codding_Challenge_PowerPoint
{
    public partial class ControllerSlide : Form
    {

        public static bool bold = false;
        public static bool itallic = false;
        public static bool strikeout = false;
        public static bool underline = false;
        public static float textSize = 12;
        public static List<Image> suggestedImages = new List<Image>();
        public static PictureBox pictureBox1Reference;
        
        public static PictureBox pictureBox2Reference;
        public static PictureBox pictureBox3Reference;
        public static PictureBox pictureBox4Reference;
        public static PictureBox pictureBox5Reference;
        public static PictureBox pictureBox6Reference;
        public static PictureBox pictureBox7Reference;
        public static PictureBox pictureBox8Reference;
        public static PictureBox pictureBox9Reference;
        
        public static Slide1 slide1;
        public static ImageResults imageResultsPage;

        public ControllerSlide()
        {
            slide1 = new Slide1();
            imageResultsPage = new ImageResults();
            
            
            InitializeComponent();
            pictureBox1Reference = this.pictureBox1;
            pictureBox2Reference = this.pictureBox2;
            pictureBox3Reference = this.pictureBox3;
            pictureBox4Reference = this.pictureBox4;
            pictureBox5Reference = this.pictureBox5;
            pictureBox6Reference = this.pictureBox6;
            pictureBox7Reference = this.pictureBox7;
            pictureBox8Reference = this.pictureBox8;
            pictureBox9Reference = this.pictureBox9;

        }

        private void ControllerSlide_Load(object sender, EventArgs e)
        {
            
        }

        private void Slide1ToolStrip_Click(object sender, EventArgs e)
        {
            Slide1 newMDIChild = new Slide1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
           
              
            
           
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ImageGenerator newMDIChild = new ImageGenerator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Slide2ToolStrip_Click(object sender, EventArgs e)
        {
            Slide2 newMDIChild = new Slide2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void slide3ToolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slide3 newMDIChild = new Slide3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void bOLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void iTALICToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sTRIKEOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void uNDERLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void BoldEnable_Click(object sender, EventArgs e)
        {
            bold = true;
            BoldDisable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Regular);
            BoldEnable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Bold);
        }

        private void BoldDisable_Click(object sender, EventArgs e)
        {
            bold = false;
            BoldDisable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Bold);
            BoldEnable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Regular);

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Switched The Font Booleans To Tell The System To Change The Fonts When Typing//
        private void ItalicEnable_Click(object sender, EventArgs e)
        {
            itallic = true;
            ItalicDisable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Regular);
            ItalicEnable.Font = new Font(BoldDisable.Font, System.Drawing.FontStyle.Bold);
        }

        private void ItalicDisable_Click(object sender, EventArgs e)
        {
            itallic = false;
            ItalicDisable.Font = new Font(ItalicDisable.Font, System.Drawing.FontStyle.Bold);
            ItalicEnable.Font = new Font(ItalicDisable.Font, System.Drawing.FontStyle.Regular);
        }

        private void StrikeOutEnable_Click(object sender, EventArgs e)
        {
            strikeout = true;
            StrikeOutDisable.Font = new Font(StrikeOutDisable.Font, System.Drawing.FontStyle.Regular);
            StrikeOutEnable.Font = new Font(StrikeOutDisable.Font, System.Drawing.FontStyle.Bold);
        }

        private void StrikeOutDisable_Click(object sender, EventArgs e)
        {
            strikeout = false;
            StrikeOutDisable.Font = new Font(StrikeOutDisable.Font, System.Drawing.FontStyle.Bold);
            StrikeOutEnable.Font = new Font(StrikeOutDisable.Font, System.Drawing.FontStyle.Regular);
        }

        private void UnderlineEnable_Click(object sender, EventArgs e)
        {
            underline = true;
            UnderlineDisable.Font = new Font(UnderlineDisable.Font, System.Drawing.FontStyle.Regular);
            UnderlineEnable.Font = new Font(UnderlineDisable.Font, System.Drawing.FontStyle.Bold);
        }

        private void UnderlineDisable_Click(object sender, EventArgs e)
        {
            underline = false;
            UnderlineDisable.Font = new Font(UnderlineDisable.Font, System.Drawing.FontStyle.Bold);
            UnderlineEnable.Font = new Font(UnderlineDisable.Font, System.Drawing.FontStyle.Regular);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
