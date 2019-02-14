namespace view_my_own_advertisements
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.set_height = new System.Windows.Forms.Button();
            this.set_width = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.width_b = new System.Windows.Forms.Button();
            this.image_youtube = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pic_left = new System.Windows.Forms.PictureBox();
            this.pic_right = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 135);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1003, 556);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 48);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Autojacker";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "student jobs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "student jobs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // set_height
            // 
            this.set_height.Location = new System.Drawing.Point(154, 31);
            this.set_height.Name = "set_height";
            this.set_height.Size = new System.Drawing.Size(168, 46);
            this.set_height.TabIndex = 9;
            this.set_height.Text = "set height";
            this.set_height.UseVisualStyleBackColor = true;
            this.set_height.Click += new System.EventHandler(this.set_height_Click);
            // 
            // set_width
            // 
            this.set_width.Location = new System.Drawing.Point(328, 31);
            this.set_width.Name = "set_width";
            this.set_width.Size = new System.Drawing.Size(168, 46);
            this.set_width.TabIndex = 13;
            this.set_width.Text = "set_width";
            this.set_width.UseVisualStyleBackColor = true;
            this.set_width.Click += new System.EventHandler(this.set_width_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "snap doc right";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(676, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "snap doc top";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::view_my_own_advertisements.Properties.Resources.blueetooth_2;
            this.pictureBox1.Location = new System.Drawing.Point(33, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(265, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 46);
            this.button6.TabIndex = 17;
            this.button6.Text = "530";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // width_b
            // 
            this.width_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_b.Location = new System.Drawing.Point(376, 83);
            this.width_b.Name = "width_b";
            this.width_b.Size = new System.Drawing.Size(105, 46);
            this.width_b.TabIndex = 18;
            this.width_b.Text = "710";
            this.width_b.UseVisualStyleBackColor = true;
            this.width_b.Click += new System.EventHandler(this.width_b_Click);
            // 
            // image_youtube
            // 
            this.image_youtube.Image = ((System.Drawing.Image)(resources.GetObject("image_youtube.Image")));
            this.image_youtube.Location = new System.Drawing.Point(193, 176);
            this.image_youtube.Name = "image_youtube";
            this.image_youtube.Size = new System.Drawing.Size(119, 115);
            this.image_youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_youtube.TabIndex = 19;
            this.image_youtube.TabStop = false;
            this.image_youtube.Click += new System.EventHandler(this.image_youtube_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(154, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 46);
            this.button7.TabIndex = 20;
            this.button7.Text = "500";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(487, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 46);
            this.button8.TabIndex = 21;
            this.button8.Text = "610";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pic_left
            // 
            this.pic_left.Image = ((System.Drawing.Image)(resources.GetObject("pic_left.Image")));
            this.pic_left.Location = new System.Drawing.Point(33, 310);
            this.pic_left.Name = "pic_left";
            this.pic_left.Size = new System.Drawing.Size(64, 64);
            this.pic_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_left.TabIndex = 22;
            this.pic_left.TabStop = false;
            this.pic_left.Click += new System.EventHandler(this.pic_left_Click);
            // 
            // pic_right
            // 
            this.pic_right.Image = ((System.Drawing.Image)(resources.GetObject("pic_right.Image")));
            this.pic_right.Location = new System.Drawing.Point(121, 310);
            this.pic_right.Name = "pic_right";
            this.pic_right.Size = new System.Drawing.Size(64, 64);
            this.pic_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_right.TabIndex = 23;
            this.pic_right.TabStop = false;
            this.pic_right.Click += new System.EventHandler(this.pic_right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 691);
            this.Controls.Add(this.pic_right);
            this.Controls.Add(this.pic_left);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.image_youtube);
            this.Controls.Add(this.width_b);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.set_width);
            this.Controls.Add(this.set_height);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "My own advertisements";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button set_height;
        private System.Windows.Forms.Button set_width;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button width_b;
        private System.Windows.Forms.PictureBox image_youtube;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pic_left;
        private System.Windows.Forms.PictureBox pic_right;
    }
}

