using IFM2B10_ST2_Paper_A.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFM2B10_ST2_Paper_A
{
    public partial class Reservation : System.Web.UI.Page
    {
        PaperAServiceClient sr = new PaperAServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if a URL parameter has been passed.
            //If Yes, deactivate the EditRes div.
            //Populate the inputs with information of the reservation to be edited
            if (Request.QueryString["ID"] != null)
            {
                EditRes.Visible = false;
                var reservation = sr.getEmail(Convert.ToInt32(Request.QueryString["ID"]));
                email.Value = reservation.Email;
                pnone.Value = reservation.Phone;
                Select.Value = Convert.ToString(reservation.Persons);
                datepicker.Value = Convert.ToString(reservation.Date);
                Select2.Value = reservation.Time;
                Textarea.Value = reservation.Note;
            }

        }

        protected void btnReserv_Click(object sender, EventArgs e)
        {
            //add a reservation to the database, if no URL parameter has been passed.
            //check if reservation already exists using the email address.

            if (Request.QueryString["ID"] == null) {
                if (sr.checkIfExist(email.Value).Equals(false))
                {
                    var book = sr.addBooking(name.Value, email.Value, Convert.ToInt32(Select.Value), pnone.Value, Convert.ToDateTime(datepicker.Value), Select2.Value, Textarea.Value);
                    if (book.Equals(true))
                    {

                        message.Text = "booked";
                    }
                    else {
                        message.Text = "not booked";
                    }
                }
                else {
                    message.Text = "cant book";
                }
            
            }

            //If URL Parameter has been passed, edit the information 
        }

        protected void BtnEditRes_Click(object sender, EventArgs e)
        {
            //Edit an already exisiting reservation.
            //check if reservation exists already. If it does, send the ID to this page.
            if (sr.checkIfExist(EditEmail.Value).Equals(true))
            {
                var editbooking = sr.editReservation(name.Value, email.Value, Convert.ToInt32(Select.Value), pnone.Value, Convert.ToDateTime(datepicker.Value), Select2.Value, Textarea.Value);
                if (editbooking.Equals(true))
                {
                    message.Text = "edited";
                }
                else {
                    message.Text = "not edited";
                }

            }
            else {
                message.Text = "does not exist";
             }


        }
    }
}