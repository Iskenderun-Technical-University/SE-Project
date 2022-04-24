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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dbcontrol sql = new dbcontrol();
        // SQL 
        //SqlConnection con = new SqlConnection();




        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        bool Login()
        {
            sql.Proam("@usr", txt_name.Text);
            sql.Proam("@pwd", txt_password.Text);
            sql.qurey("select count(*) from tbuser where usr=@usr and pwd=@pwd");
         
            MessageBox.Show("Invalid Username or Password ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (Login() == true)
            {
                sbidarbar a = new sbidarbar();
                Hide();
                a.ShowDialog();
                   
            }





            /*String username, userpassword;
            username = txt_name.Text;
            userpassword = txt_password.Text;

            try
            {
                
                String querry = "SELECT * FROM Login WHERE username = '"+txt_name.Text+"' AND password ='" +txt_password.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtble = new DataTable();
                sda.Fill(dtble);

                if (dtble.Rows.Count > 0)
                {
                    username = txt_name.Text;
                    userpassword = txt_password.Text;
                    sbidarbar q = new sbidarbar();
                    q.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaid Loginm", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error
                       );

                    }
               
                 
              
            
            }

            catch
            {
                MessageBox.Show("Eroor");
            }
            finally
            {
                con.Close();
            }
            */

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sginup ob = new sginup();
            ob.ShowDialog(); 
        }
    }
}
