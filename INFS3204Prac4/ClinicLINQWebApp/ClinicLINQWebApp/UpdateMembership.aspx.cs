using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClinicLINQWebApp.ServiceReference1;

using System.ServiceModel;

namespace INFS3204Prac4
{
    public partial class UpdateMembership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            var client = new LINQDatabaseServiceClient(); 

            var fullname = FirstName.Text + " " + LastName.Text;

            try
            {
                var membership = client.GetMembership(fullname, ClubName.Text);

                StartDate.Text = membership.StartDate.ToString("yyyy-MM-dd");
                EndDate.Text = membership.EndDate.HasValue ? membership.EndDate.Value.ToString("yyyy-MM-dd") : "";
                NumOfGames.Text = membership.NumOfGames.HasValue ? membership.NumOfGames.Value.ToString() : "";
                FirstName.Enabled = false;
                FirstName.CssClass = "form-control";
                LastName.Enabled = false;
                LastName.CssClass = "form-control";
                ClubName.Enabled = false;
                ClubName.CssClass = "form-control";
                Error.Text = "";
                Error.CssClass = "";
            }
            catch(FaultException)
            {
                FirstName.Enabled = true;
                LastName.Enabled = true;
                ClubName.Enabled = true;
                Error.Text = "Not Found!";
                Error.CssClass = "alert alert-danger";
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            var client = new LINQDatabaseServiceClient(); 

            var fullname = FirstName.Text + " " + LastName.Text;

            try 
            { 
                client.UpdateMembership(fullname, ClubName.Text, DateTime.Parse(EndDate.Text), Int32.Parse(NumOfGames.Text));
                Error.Text = "Updated Successfully";
                Error.CssClass = "alert alert-success";
            }
            catch(FaultException)
            {
                Error.Text = "An Error Occurred!";
                Error.CssClass = "alert alert-danger";
            }
        }
    }
}