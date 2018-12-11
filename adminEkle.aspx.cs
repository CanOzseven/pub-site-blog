using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace habBlog
{
    public partial class adminEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void adminEklebuton(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True";
            baglan.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO uyeler (kullanici_adi,kullanici_sifre) values (@kullanici_adi,@kullanici_sifre)");
            cmd.Connection = baglan;


            SqlParameter p = new SqlParameter("@kullanici_adi", SqlDbType.NVarChar);
            p.Value = adminKadi.Text;
            cmd.Parameters.Add(p);


            p = new SqlParameter("@kullanici_sifre", SqlDbType.NVarChar);
            p.Value = adminsifre.Text;
            cmd.Parameters.Add(p);


            int etkilenen = cmd.ExecuteNonQuery();

            if (etkilenen > 0)
            {

                Label1.Text = "Yeni bir admin  Eklendi";
            }
            else
            {
                Label1.Text = "Admin Eklerken bir hata oluştu";
            }
        }
    }
}