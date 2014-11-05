using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebFormService
{
    using ServiceReference1;

    /// <summary>
    /// Summary description for WebService3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService3 : System.Web.Services.WebService
    {

        [WebMethod]
        public Food Mixer(List<Food> foods) {

            var client = new WebService1SoapClient();

            var all = foods
                      .Select(x => client.FatAndCal(x.name, x.weight))
                      .Where(x => x != null) // Ignore Nulls
                      .ToList();

            return new Food () { calorie = all.Sum(x => x.calorie), fat = all.Sum(x => x.fat) };

        }


    }
}
