using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art_Gallery_Project
{
    public partial class sbidarbar : Form
    {
        bool sidebarExpand;
        public sbidarbar()
        {
            InitializeComponent();
        }

        private void aaa1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sbibae_tik(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sibebar.Width -= 10;
                if (sibebar.Width == sibebar.MinimumSize.Width)
                        {
                    sidebarExpand = false;
                    sibedartimer.Stop();
                }
            }

            else {
                sibebar.Width += 10;
                if (sibebar.Width  == sibebar.MaximumSize.Width){
                    sidebarExpand = true;
                    sibedartimer.Stop();



                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //set time arival to lowest to make it smother 
            sibedartimer.Start();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void sibebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
