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
    public partial class haberGoster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost; Initial Catalog=habBlog; Integrated Security=True");

        public void Page_Load(object sender, EventArgs e)
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

                //Silme işlemini gerçekleştirecek SqlCommand'ımızı belirliyoruz.

                SqlCommand cmd = new SqlCommand("Delete from haber where haber_id=" + id + "", con);
                cmd.ExecuteNonQuery();
                Response.Write("Silme İşlemi Gerçekleştirildi.");
                Response.Redirect("haberGoster.aspx",true);
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
            SqlCommand cmd = new SqlCommand("select haber_id,haberBaslik,haberTarih from haber order by haberTarih Desc", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Class1> haber = new List<Class1>();

            while (dr.Read())
            {
                haber.Add(new Class1()
                {
                    haberID= Convert.ToString(dr["haber_id"]),
                    haberBaslik = Convert.ToString(dr["haberBaslik"]),
                    haberTarih = Convert.ToString((dr["haberTarih"])),
                });

            }
            con.Close();
            con.Dispose();
            return haber;
        }
        
       
        
    }
}