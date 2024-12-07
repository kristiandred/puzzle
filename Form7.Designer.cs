namespace WinFormsApp1
{
    partial class Form7
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            button1 = new Button();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.хомяк;
            pictureBox1.Location = new Point(248, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 176);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.пифагор;
            pictureBox2.Location = new Point(284, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 176);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.минус;
            pictureBox3.Location = new Point(248, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(249, 176);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(296, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(34, 33);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(327, 261);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(34, 33);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(359, 261);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(34, 33);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(391, 261);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(34, 33);
            richTextBox4.TabIndex = 6;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(422, 261);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(34, 33);
            richTextBox5.TabIndex = 7;
            richTextBox5.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(481, 326);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(482, 261);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(34, 33);
            richTextBox6.TabIndex = 10;
            richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(451, 261);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(34, 33);
            richTextBox7.TabIndex = 9;
            richTextBox7.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(482, 326);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(482, 326);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "проверить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox7);
            Controls.Add(button1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form7";
            Text = "Головоломка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Button button1;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private Button button2;
        private Button button3;
    }
}