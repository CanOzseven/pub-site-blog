using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace habBlog
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptHaber.DataSource = HaberBind();
            rptHaber.DataBind();
        }
        public List<Class1> HaberBind()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select haber_id,haberResmi,haberBaslik,haberTarih,haberDetay from haber order by haber_id desc", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Class1> haber = new List<Class1>();

            while (dr.Read())
            {
                haber.Add(new Class1()
                {
                    haberID = Convert.ToString(dr["haber_id"]),
                    haberDetay = Convert.ToString(dr["haberDetay"]),
                    haberBaslik = Convert.ToString(dr["haberBaslik"]),
                    haberTarih = Convert.ToString((dr["haberTarih"])),
                    haberResmi= Convert.ToString(dr["haberResmi"])
                    
            });

            }
            con.Close();
            con.Dispose();
            return haber;
        }
    }
}