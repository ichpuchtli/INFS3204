using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WebFormService
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        public static readonly string dbFilename = "json_db.txt"; 

        [WebMethod]
        public string Register(string username, string password)
        {
            // Open or Create our json encoded flat file database
            FileStream file = new FileStream(Server.MapPath("~/") + dbFilename, FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(file);
            var text = reader.ReadToEnd();
            reader.Close();
            file.Close();

            // If file is empty use an empty json array
            if (text.Count() == 0)
            {
                text = "[]";
            }

            // Parse our json encoded database in a json object
            var json_db = JArray.Parse(text);

            // If any user with the username exists return
            if (json_db.Any(x => x["username"].ToString() == username)) {
                return "the username already exists!";
            }

            var new_user = new JObject();
            new_user["username"] = username;
            new_user["password"] = password;

            json_db.Add(new_user);

            // Truncate database file then restore old users + new user
            file = new FileStream(Server.MapPath("~/") + dbFilename, FileMode.Truncate);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(json_db.ToString());
            writer.Close();
            file.Close();

            return "your password is: " + password;
        }
    }
}
