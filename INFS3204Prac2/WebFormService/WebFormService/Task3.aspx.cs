using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormService
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Time.Text = "The first run recorded at: " + DateTime.Now.ToString();
        }
    }
}