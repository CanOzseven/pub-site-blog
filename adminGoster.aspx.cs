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
    public partial class adminGoster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            rptHaber.DataSource = HaberBind();
            rptHaber.DataBind();
        }
        protected void rpt_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "delete")
            {
                con.Open();

                int id = Convert.ToInt32(e.CommandArgument.ToString());

                 

                SqlCommand cmd = new SqlCommand("Delete from uyeler where uye_id=" + id + "", con);
                cmd.ExecuteNonQuery();
                Response.Write("Silme İşlemi Gerçekleştirildi.");
                Response.Redirect("adminGoster.aspx", true);
                con.Close();
            }
        }
        protected void rpt_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {


            }
        }
        public List<Class1> HaberBind()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select uye_id,kullanici_adi,kullanici_sifre from uyeler ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Class1> haber = new List<Class1>();

            while (dr.Read())
            {
                haber.Add(new Class1()
                {
                    uye_id = Convert.ToString(dr["uye_id"]),
                    kullaniciAdi = Convert.ToString(dr["kullanici_adi"]),
                });

            }
            con.Close();
            con.Dispose();
            return haber;
        }
    }
}