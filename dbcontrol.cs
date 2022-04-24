using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Art_Gallery_Project
{
    internal class dbcontrol
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-CK4I4NO\SQLEXPRESS01;Initial Catalog=artgallery;Integrated Security=True");

        SqlCommand cm;
        public SqlDataAdapter da;
        List<SqlParameter> parmas = new List<SqlParameter>();
        public DataTable dt;
        public int recordcount;
        public string exception;

        public void qurey(string name)
        {
            recordcount = 0;
            exception = null;
            try
            {
                cn.Open();
                cm = new SqlCommand(name, cn);

                parmas.ForEach(p => cm.Parameters.Add(p));
                parmas.Clear();
                dt = new DataTable();
                da = new SqlDataAdapter(cm);
                recordcount = da.Fill(dt);

            }
            catch (Exception e)
            {
                exception = "Problem:" + e.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public void Proam(String name, object value)
        {

            SqlParameter newparam = new SqlParameter(name, value);


            parmas.Add(newparam);

        }

        public bool Check4error(bool err = false)
        {
            if (string.IsNullOrEmpty(exception))
            {
                return false;
            }
            if (err == true)
            {
                MessageBox.Show(exception, "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return true;
        } 
    }
}
