using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IFM2B10_ST2_Paper_A.ServiceReference1;

namespace IFM2B10_ST2_Paper_A
{
    public partial class Home : System.Web.UI.Page
    {
        PaperAServiceClient sr = new PaperAServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //load the meals on special on the home page.
            //in the specials div.
            //link the images to the details page for each item.
            //display only the image, meal name, and meal price.
            //link read more to drtails page for each item.
            dynamic meals = sr.getOEI();
            string special = "";
            foreach(Item p in meals)
            {
                if (p.OnSpecial.Equals(1)) {
                    special += "<div class='col-sm-6 col-lg-4'>";
                    special += "<div class='single_blog_item'>";
                    special +="<div class='single_blog_img'>";
                    special +="<img src ='"+p.Image+"' alt=''>";
                    special +="</div>";
                    special +="<div class='single_blog_text'>";
                    special +="<h3>"+p.Name+"</h3>";
                    special +="<p>"+Math.Round(p.Price,2)+"</p>";
                    special += "<a href='AboutMeal.aspx?ID="+p.Id+"' class='btn_3'>Read More<img src='' alt=''></a>";
                    special +="</div>";
                    special +="</div>";
                    special +="</div>";
                }

    
            }
                 specials.InnerHtml=special;
        }

        protected void BtnR_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservation.aspx");

        }
    }
}