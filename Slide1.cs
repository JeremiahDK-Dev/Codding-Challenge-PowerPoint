using System;
using System.Drawing;
using System.Windows.Forms;

namespace Codding_Challenge_PowerPoint
{
    
    public partial class Slide1 : Form
    {
        
        public Slide1()
        {
           
            InitializeComponent();
          
        }

        private void Slide1_Load(object sender, EventArgs e)
        {
            Slide1Background.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Font Change Functions//
                RichTextBox _richTextBox1 = Slide1TextBox;
                if (ControllerSlide.bold == true)
                {
                    _richTextBox1.Select();
                    _richTextBox1.SelectionFont = new Font(Slide1TextBox.Font, System.Drawing.FontStyle.Bold);
                }
                else if (ControllerSlide.itallic == true)
                {
                    _richTextBox1.Select();
                    _richTextBox1.SelectionFont = new Font(Slide1TextBox.Font, System.Drawing.FontStyle.Italic);
                }
                else if (ControllerSlide.strikeout == true)
                {
                    _richTextBox1.Select();
                    _richTextBox1.SelectionFont = new Font(Slide1TextBox.Font, System.Drawing.FontStyle.Strikeout);
                }
                else if (ControllerSlide.underline == true)
                {
                    _richTextBox1.Select();
                    _richTextBox1.SelectionFont = new Font(Slide1TextBox.Font, System.Drawing.FontStyle.Underline);
                }
                else
                {
                    _richTextBox1.Select();
                    _richTextBox1.SelectionFont = new Font(Slide1TextBox.Font, System.Drawing.FontStyle.Regular);
                }
            
        }

        private void Slide1Background_Click(object sender, EventArgs e)
        {
            //Changed The Background To The Users Selected Image Background From The Image Results Page//

           // var rnd = ControllerSlide.suggestedImages;
            //int image = rnd.Next(minValue: 0, maxValue: 0);

            Slide1Background.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }
    }
}
