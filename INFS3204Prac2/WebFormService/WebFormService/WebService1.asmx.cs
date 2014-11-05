using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebFormService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public class Food
        {
            public Food() { }

            public string name { get; set; }
            public double weight { get; set; }
            public virtual double fat { get; set; }
            public virtual int calorie { get; set; }

        }

        public class FoodComputed : Food {

            private double fatper100g { get; set; }
            private int calper100g { get; set; }

            public FoodComputed() { }

            public FoodComputed(string name, double fatper100g, int calper100g)
            {
                this.name = name;
                this.fatper100g = fatper100g;
                this.calper100g = calper100g;
            }

            public override double fat
            {
                get
                {
                    return weight * fatper100g / 100f;
                }
            }

            public override int calorie
            {
                get
                {
                    return (int) (weight * calper100g / 100f);
                }
            }
        }

        /// <summary>
        /// Fat and Calories per 100g
        /// </summary>
        public static List<FoodComputed> Foods = new List<FoodComputed>()
        {
            new FoodComputed ("Fried egg",15.31f,96),
            new FoodComputed ( "Toasted bread", 3.6f, 284),
            new FoodComputed ( "Beef", 3.3f, 111),
            new FoodComputed ( "Potato chips", 2.8f, 471),
            new FoodComputed ( "Apple", 0.17f, 52),
            new FoodComputed ( "Orange juice", 0.2f, 45)
        };

        [WebMethod]
        public FoodComputed FatAndCal(string name, double weight) {

            var food = Foods.Where(x => x.name == name).SingleOrDefault();

            if (food != null) {
                food.weight = weight;
                return food;
            }

            return null;
        }

    }
}
