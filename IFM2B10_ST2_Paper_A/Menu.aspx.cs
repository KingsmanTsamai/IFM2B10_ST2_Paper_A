using IFM2B10_ST2_Paper_A.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace IFM2B10_ST2_Paper_A
{
    public partial class Menu : System.Web.UI.Page
    {
        PaperAServiceClient sr = new PaperAServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //load all the meals in their respetice divs according to meal type.
            //Starters in the starter div, main dishes in the main div and so on.
            //link the images to the details page for each item.
            //display only the image, meal name, and meal price.
            dynamic mealtype = sr.getmealType();
            string starter = "";
            string main = "";
            string launch = "";
            string desert = "";
            string special = "";
            foreach (itemMenu s in mealtype)
            {
                if (s.Category.Equals("Starter"))
                {

                    starter += "<div class='single_food_item media'>";
                    starter += "<img src = '" + s.Image + "' class='mr-3' alt='...'>";
                    starter += "<div class='media-body align-self-center'>";
                    starter += "<h3>" + s.Name + "</h3>";
                    starter += "<p>" + s.Description + "</p>";
                    starter += "<h5>" + Math.Round(s.Price, 2) + "</h5>";
                    starter += "</div>";
                    starter += "</div>";


                }
                if (s.Category.Equals("Main"))
                {

                    main += "<div class='single_food_item media'>";
                    main += "<img src = '" + s.Image + "' class='mr-3' alt='...'>";
                    main += "<div class='media-body align-self-center'>";
                    main += "<h3>" + s.Name + "</h3>";
                    main += "<p>" + s.Description + "</p>";
                    main += "<h5>" + Math.Round(s.Price, 2) + "</h5>";
                    main += "</div>";
                    main += "</div>";


                }

                if (s.Category.Equals("Launch"))
                {

                    launch += "<div class='single_food_item media'>";
                    launch += "<img src = '" + s.Image + "' class='mr-3' alt='...'>";
                    launch += "<div class='media-body align-self-center'>";
                    launch += "<h3>" + s.Name + "</h3>";
                    launch += "<p>" + s.Description + "</p>";
                    launch += "<h5>" + Math.Round(s.Price, 2) + "</h5>";
                    launch += "</div>";
                    launch += "</div>";


                }

                if (s.Category.Equals("Dessert"))
                {

                    desert += "<div class='single_food_item media'>";
                    desert += "<img src = '" + s.Image + "' class='mr-3' alt='...'>";
                    desert += "<div class='media-body align-self-center'>";
                    desert += "<h3>" + s.Name + "</h3>";
                    desert += "<p>" + s.Description + "</p>";
                    desert += "<h5>" + Math.Round(s.Price, 2) + "</h5>";
                    desert += "</div>";
                    desert += "</div>";


                }
                if (s.OnSpecial == 1)
                {

                    special += "<div class='single_food_item media'>";
                    special += "<img src = '" + s.Image + "' class='mr-3' alt='...'>";
                    special += "<div class='media-body align-self-center'>";
                    special += "<h3>" + s.Name + "</h3>";
                    special += "<p>" + s.Description + "</p>";
                    special += "<h5>" + Math.Round(s.Price, 2) + "</h5>";
                    special += "</div>";
                    special += "</div>";


                }



            };
            DivStarter.InnerHtml = desert;
            DivLaunch.InnerHtml = launch;
            DivMeal.InnerHtml = main;
            DivSpecial.InnerHtml = special;


        }
    }
}