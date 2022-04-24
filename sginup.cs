using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Art_Gallery_Project
{
    public partial class sginup : Form
    {
        public sginup()
        {
            InitializeComponent();
        }

        dbcontrol sql = new dbcontrol();

        void register()
        {
            sql.Proam("@usr", txtname.Text);
            sql.Proam("@pwd", txtpassword.Text);
            sql.Proam("@email", txtemail.Text);
            sql.Proam("@age", txtpassword.Text.ToString());
            sql.Proam("@country",txtcountry.Text);
         
            sql.qurey("inster into tbuser (usr,pwd,email,age,country) values(@usr,@pwd,@email,@age,@country)");

            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sginup_Load(object sender, EventArgs e)
        {

        }

        private void sginup_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
