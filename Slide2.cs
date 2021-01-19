using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Codding_Challenge_PowerPoint
{
    public partial class Slide2 : Form
    {
        public Slide2()
        {
            InitializeComponent();
        }

        private void Slide2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
            pictureBox2.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }

        private void bodyTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox _richTextBox1 = bodyTextBox;
            if (ControllerSlide.bold == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(bodyTextBox.Font, System.Drawing.FontStyle.Bold);
            }
            else if (ControllerSlide.itallic == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(bodyTextBox.Font, System.Drawing.FontStyle.Italic);
            }
            else if (ControllerSlide.strikeout == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(bodyTextBox.Font, System.Drawing.FontStyle.Strikeout);
            }
            else if (ControllerSlide.underline == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(bodyTextBox.Font, System.Drawing.FontStyle.Underline);
            }
            else
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(bodyTextBox.Font, System.Drawing.FontStyle.Regular);
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox _richTextBox1 = titleTextBox;
            if (ControllerSlide.bold == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(titleTextBox.Font, System.Drawing.FontStyle.Bold);
            }
            else if (ControllerSlide.itallic == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(titleTextBox.Font, System.Drawing.FontStyle.Italic);
            }
            else if (ControllerSlide.strikeout == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(titleTextBox.Font, System.Drawing.FontStyle.Strikeout);
            }
            else if (ControllerSlide.underline == true)
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(titleTextBox.Font, System.Drawing.FontStyle.Underline);
            }
            else
            {
                _richTextBox1.Select();
                _richTextBox1.SelectionFont = new Font(titleTextBox.Font, System.Drawing.FontStyle.Regular);
            }
        }
    }
}
