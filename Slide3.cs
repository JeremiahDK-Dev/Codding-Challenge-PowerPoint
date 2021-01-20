﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codding_Challenge_PowerPoint
{
    public partial class Slide3 : Form
    {
        public Slide3()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = ControllerSlide.pictureBox1Reference.BackgroundImage;
        }

        private void Slide3_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = ControllerSlide.pictureBox1Reference.BackgroundImage;
            // pictureBox2.BackgroundImage = ControllerSlide.pictureBox1Reference.BackgroundImage;
            bodyTextBox.AppendText(ControllerSlide.bodyText);
            titleTextBox.AppendText(ControllerSlide.titleText);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = ControllerSlide.pictureBox1Reference.BackColor;
        }
    }
}
