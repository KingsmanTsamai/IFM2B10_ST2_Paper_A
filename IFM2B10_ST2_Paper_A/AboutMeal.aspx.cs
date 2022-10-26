using IFM2B10_ST2_Paper_A.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using IFM2B10_ST2_Paper_A.ServiceReference1;

namespace IFM2B10_ST2_Paper_A
{
    public partial class AboutMeal : System.Web.UI.Page
    {
        PaperAServiceClient sr = new PaperAServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrive the URL parameter.
            //Display all the information about the meal.
            //use example HTML to style the page.
            var item = sr.getSingleProduct(Convert.ToInt32(Request.QueryString["ID"]));
            
            ImageDiv.InnerHtml ="<img src = '"+item.Image+"' alt = '' >";
            textDiv.InnerHtml += "<h5>"+item.Name+"</h5>";
            textDiv.InnerHtml += "<p>"+Math.Round(item.Price,2)+"</p>";
            textDiv.InnerHtml += "<h3>"+item.Description+"</h3>";


                 
        }
    }
}