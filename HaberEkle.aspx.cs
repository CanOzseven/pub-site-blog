using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

namespace habBlog
{
    public partial class HaberEkle : System.Web.UI.Page
    {
        string resimPath;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
                try
                {

                    FileUpload1.SaveAs(Server.MapPath("haberResim/") + FileUpload1.FileName);
                    resimPath = ("haberResim/") + FileUpload1.FileName;
                    Label1.Text =  "haberResim/"  + FileUpload1.FileName;
                    resimPath = Label1.Text;
                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            else
            {
                Label1.Text = "Dosya Seçin ve Yükleyin";
            }
        }

        protected void gonderClick(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True";
            baglan.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO haber (haberBaslik,haberDetay,haberResmi,haberTarih) values (@haberBasligi,@haberDetayi,@haberResmi,GETDATE())");
            cmd.Connection = baglan;


            SqlParameter p = new SqlParameter("@haberBasligi", SqlDbType.NVarChar);
            p.Value = haberBaslikText.Text;
            cmd.Parameters.Add(p);


            p = new SqlParameter("@haberResmi", SqlDbType.NVarChar);
            p.Value = Label1.Text;
            cmd.Parameters.Add(p);


            p = new SqlParameter("@haberDetayi", SqlDbType.NVarChar);
            p.Value = HaberDetayText.Text;
            cmd.Parameters.Add(p);




            int etkilenen = cmd.ExecuteNonQuery();

            if (etkilenen > 0)
            {

                Label3.Text = "Haber Eklendi";
            }
            else
            {
                Label3.Text = "Haber Eklerken bir hata oluştu";
            }
        }



    }
}