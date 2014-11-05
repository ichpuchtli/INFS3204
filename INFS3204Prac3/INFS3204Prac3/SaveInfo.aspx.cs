using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFS3204Prac3
{
    public partial class SaveInfo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            var stock = new ServiceReference1.Stock();

            try
            {
                stock.name = stockname.Text;
                stock.isDiscontinued = isDiscontinued.Checked;
                stock.productionDate = DateTime.Parse(productionDate.Text);

                stock.Store = new ServiceReference1.Store();

                stock.Store.ID = Guid.NewGuid().ToString();
                stock.Store.address = address.Text;
                stock.Store.name = name.Text;
                stock.Store.phoneNumber = Int32.Parse(phoneNumber.Text);
                stock.Store.branchNO = Int32.Parse(branchNO.Text);
            }
            catch
            {
                Success.CssClass = "alert alert-danger";
                Success.Text = "Unable to save";
            }

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            if (client.SaveInfo(stock))
            {
                // label success
                Success.CssClass = "alert alert-success";
                Success.Text = "Successfully Saved!";
            }
            else
            {
                Success.CssClass = "alert alert-danger";
                Success.Text = "Unable to save";
            }

        }
    }
}