using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace habBlog
{
    public partial class detay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["id"]);

            Class1 haber = HaberBind(id);
            lbl_Baslik.Text = haber.haberBaslik;
            lbl_Tarih.Text = haber.haberTarih;
            lbl_icerik.Text = haber.haberDetay;
            image_Haber.ImageUrl = haber.haberResmi;
        }
        public Class1 HaberBind(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select haber_id,haberResmi,haberBaslik,haberTarih,haberDetay from haber where haber_id=@id", con);
            SqlParameter sp = new SqlParameter("@id", System.Data.SqlDbType.Int);
            sp.Value = id;
            cmd.Parameters.Add(sp);

            SqlDataReader dr = cmd.ExecuteReader();
            Class1 haber = new Class1();

            while (dr.Read())
            {

                haber.haberID = Convert.ToString(dr["haberBaslik"]);
                haber.haberBaslik = Convert.ToString(dr["haberBaslik"]);
                haber.haberDetay = Convert.ToString(dr["haberDetay"]);
                haber.haberTarih = Convert.ToString(dr["haberTarih"]);
                haber.haberResmi = Convert.ToString(dr["haberResmi"]);

                

            }
            con.Close();
            con.Dispose();
            return haber;
        }
    }
}