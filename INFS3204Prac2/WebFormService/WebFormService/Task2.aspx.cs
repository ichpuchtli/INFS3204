using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormService
{

    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            WebService1.Foods.ForEach(x =>
                FoodDropDown.Items.Add(x.name)
            );

            ViewState["foods"] = new List<ServiceReference2.Food>();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            var name = FoodDropDown.Text;
            var weight = Weight.Text;

            double weightAsDouble = Double.Parse(weight);

            FoodNames.Items.Add(name);
            Weights.Items.Add(weight);

            var foods = (List<ServiceReference2.Food>) ViewState["foods"]; 

            foods.Add(new ServiceReference2.Food() { name = name, weight = weightAsDouble });

        }

        protected void CalculateBtn_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference2.WebService3SoapClient();

            var foods = (List<ServiceReference2.Food>) ViewState["foods"];

            var result = client.Mixer( foods.ToArray() );

            TotalFat.Text = "Total Fat (g): " + result.fat.ToString();
            TotalCalories.Text =  "Total Calories: " + result.calorie.ToString();
        }

        protected void ResetBtn_Click(object sender, EventArgs e)
        {
            ViewState["foods"] = new List<ServiceReference2.Food>();

            Weight.Text = null;

            FoodNames.Items.Clear();
            Weights.Items.Clear();

            TotalFat.Text = "Total Fat (g):";
            TotalCalories.Text = "Total Calories: ";

        }

    }
}