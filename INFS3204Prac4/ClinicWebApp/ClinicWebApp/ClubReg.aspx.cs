using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClinicWebApp.ServiceReference1;
using System.ServiceModel;

namespace INFS3204Prac4
{
    public partial class ClubReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

            var club = new Club();
            int tmp;

            club.RegistrationID = Guid.NewGuid().ToString();
            club.Name = Name.Text;
            club.Founded = DateTime.Parse(Founded.Text);
            club.WorldRanking = Int32.TryParse(WorldRanking.Text, out tmp) ? Int32.Parse(WorldRanking.Text) : new Nullable<Int32>();

            var client = new ClinicWebApp.ServiceReference1.ADODatabaseServiceClient();

            try
            {
                client.ClubRegistration(club);
                Error.Text = "Saved Successfully";
                Error.CssClass = "alert alert-success";
            }
            catch
            {
                Error.Text = "An Error Occurred!";
                Error.CssClass = "alert alert-danger";
            }

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {

            var client = new ClinicWebApp.ServiceReference1.ADODatabaseServiceClient(); 

            try
            {
                var club = client.GetClubInfo(Name.Text);

                Founded.Text = club.Founded.ToString("yyyy-MM-dd");
                WorldRanking.Text = club.WorldRanking.HasValue ? club.WorldRanking.Value.ToString() : "";
                Error.Text = "";
                Error.CssClass = "";
            }
            catch(FaultException)
            {
                Error.Text = "Not Found!";
                Error.CssClass = "alert alert-danger";
            }

        }
    }
}