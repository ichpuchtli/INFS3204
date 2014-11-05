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
    public partial class PlayerReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            int tmp;

            var player = new Player();

            player.RegistrationID = Guid.NewGuid().ToString();
            player.FirstName = FirstName.Text;
            player.LastName = LastName.Text;
            player.Address = Address.Text;
            player.PhoneNumber = Int32.TryParse(PhoneNumber.Text, out tmp) ? Int32.Parse(PhoneNumber.Text) : new Nullable<Int32>();
            player.DateOfBirth = DateTime.Parse(DateOfBirth.Text);

            var client = new ClinicWebApp.ServiceReference1.ADODatabaseServiceClient();

            try
            {
                client.PlayerRegistration(player);
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
                var player = client.GetPlayerInfo(FirstName.Text, LastName.Text);
                Address.Text = player.Address;
                PhoneNumber.Text = player.PhoneNumber.HasValue ? player.PhoneNumber.Value.ToString() : "";
                DateOfBirth.Text = player.DateOfBirth.ToString("yyyy-MM-dd"); 
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