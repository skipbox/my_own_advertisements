using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace view_my_own_advertisements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }



        String link_1 = "autojacker.com";
        String link_2 = "studentjobs4you.info/uploadNew/coach_simple/youtube_slides.php";
        String link_3 = "google.com";
        String link_4 = "https://docs.google.com/presentation/d/e/2PACX-1vQuXPv80zJ-osAoXlhaVzxuAYNJ5lFded3ymNH_SweMDA2SIeJFlThJXUnpykripV5q8LA4JWX1fd8D/pub?start=true&loop=true&delayms=3000";
        String link_5 = "https://docs.google.com/presentation/d/1QXnxDm31Z9GD8ISN1PAhAZxCgdJQIELiShkfFWDXuf0/present?includes_info_params=1&eisi=CM758ZeFtuACFaclyAodyhYJ8Q#slide=id.g4f66e953c3_0_5";
        String link_6 = "https://docs.google.com/presentation/d/1qsLVPIQAAC4ccIP3QeeqkGK4q95oOTaJtO5V_3SmcZE/edit?usp=sharing";



        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(link_4);//google
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(link_2);//student jobs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(link_6);//student jobs
        }


        //set height

        private void set_height_Click(object sender, EventArgs e)
        {
            int my_height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            int my_width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            my_height = my_height - 33;
            this.Height = my_height;
            this.Top = 0;
            this.Left = ((my_width - this.Width)+5);
            int form_width = this.Width;
            set_height.Text = "width = "+form_width;
        }
        //set width
        private void set_width_Click(object sender, EventArgs e)
        {

        }

        //snap doc right
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //snap doc top
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //youtube size A biggest
        private void button6_Click(object sender, EventArgs e)
        {          
            //string but_text_width = this.Text;
            size_from_string("530");
        }
        //width b
        private void width_b_Click(object sender, EventArgs e)
        {
            size_from_string("710");
        }
        private void image_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com");
        }


        //public System.Drawing.Size Size { get; set; }
        //Screen.PrimaryScreen.Bounds.Width
        //size_from_string("400");
        public void size_from_string(String new_size) {
            int my_height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            int my_width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            my_height = my_height - 33;
            this.Height = my_height;//maximum height      
            this.Top = 0;
            //get width from button
            //string s = (sender as Button).Text;
            //string but_text_width = this.button6.Text;//will throw EXEption if not numeric !!!
            int final_width = int.Parse(new_size);
            //this.Width = int.Parse(but_text_width);
            this.Width = final_width;
            this.Left = (my_width - this.Width);//puts it against the right side
            int form_width = this.Width;
            set_height.Text = "width = " + form_width;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            size_from_string("500");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            size_from_string("610");
        }

        private void pic_left_Click(object sender, EventArgs e)
        {
            int my_width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            this.Width = (this.Width + 15);
            this.Left = (my_width - this.Width);//puts it against the right side
            int form_width = this.Width;
            set_height.Text = "width = " + form_width;
        }

        private void pic_right_Click(object sender, EventArgs e)
        {
            int my_width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            this.Width = (this.Width - 15);
            this.Left = (my_width - this.Width);//puts it against the right side
            int form_width = this.Width;
            set_height.Text = "width = " + form_width;
        }
    }
}
