using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClinicLINQWebApp.ServiceReference1;

namespace INFS3204Prac4
{
    public partial class NewMembership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

            var fullname = FirstName.Text + " " + LastName.Text;

            var client = new LINQDatabaseServiceClient();

            try
            {
                client.NewMembership(fullname, ClubName.Text, DateTime.Parse(StartDate.Text));
                Error.Text = "Saved Successfully";
                Error.CssClass = "alert alert-success";
            }
            catch
            {
                Error.Text = "An Error Occurred!";
                Error.CssClass = "alert alert-danger";
            }

        }
    }
}