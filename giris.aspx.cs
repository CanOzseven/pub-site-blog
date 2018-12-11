using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
namespace habBlog
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void gonder(object sender, EventArgs e)
        {
           
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True";
            baglan.Open();
            SqlCommand com = new SqlCommand("Select * from uyeler where kullanici_adi='" + kadi.Text + "'and kullanici_sifre='" + sifre.Text + "'", baglan);
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                Session["kullaniciAdi"] = kadi.Text;
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "2;url=Panel.aspx";
                this.Page.Controls.Add(meta);
                Label1.Text = "2 saniye sonra yönlendirileceksiniz.";
               
            }
            else
            {
                Label1.Text = "Kullanıcı Kaydı Bulunmadı! Lütfen tekrar deneyiniz.";
            }
        }
    }
}