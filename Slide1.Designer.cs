
namespace Codding_Challenge_PowerPoint
{
    partial class Slide1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Slide1TextBox = new System.Windows.Forms.RichTextBox();
            this.Slide1TitleBox = new System.Windows.Forms.RichTextBox();
            this.Slide1Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slide1Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Slide1TextBox
            // 
            this.Slide1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slide1TextBox.Location = new System.Drawing.Point(12, 175);
            this.Slide1TextBox.Name = "Slide1TextBox";
            this.Slide1TextBox.Size = new System.Drawing.Size(776, 263);
            this.Slide1TextBox.TabIndex = 0;
            this.Slide1TextBox.Text = "";
            this.Slide1TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Slide1TitleBox
            // 
            this.Slide1TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slide1TitleBox.Location = new System.Drawing.Point(12, 93);
            this.Slide1TitleBox.Name = "Slide1TitleBox";
            this.Slide1TitleBox.Size = new System.Drawing.Size(301, 76);
            this.Slide1TitleBox.TabIndex = 2;
            this.Slide1TitleBox.Text = "";
            // 
            // Slide1Background
            // 
            this.Slide1Background.BackColor = System.Drawing.Color.Transparent;
            this.Slide1Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slide1Background.Location = new System.Drawing.Point(-7, -2);
            this.Slide1Background.Name = "Slide1Background";
            this.Slide1Background.Size = new System.Drawing.Size(814, 455);
            this.Slide1Background.TabIndex = 1;
            this.Slide1Background.TabStop = false;
            this.Slide1Background.Click += new System.EventHandler(this.Slide1Background_Click);
            // 
            // Slide1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Slide1TitleBox);
            this.Controls.Add(this.Slide1TextBox);
            this.Controls.Add(this.Slide1Background);
            this.Name = "Slide1";
            this.Text = "Slide1";
            this.Load += new System.EventHandler(this.Slide1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slide1Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Slide1TextBox;
        private System.Windows.Forms.PictureBox Slide1Background;
        private System.Windows.Forms.RichTextBox Slide1TitleBox;
    }
}