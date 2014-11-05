using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFS3204Prac1
{
    public partial class _Default : Page
    {
        /// <summary>
        /// Page Load method
        /// </summary>
        protected void Page_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Classify Button Action
        /// </summary>
        protected void ClassifyBtn_Click(object sender, EventArgs e)
        {
            var numbers = parse(NumberTextBox.Text);

            if (RemoveDuplicates.Checked)
            {
                numbers = numbers.Distinct();
            }

            EvenListBox.Items.Clear();

            if (EvenOddRadioBtn.Text == "Even" || EvenOddRadioBtn.Text == "Both")
            {
                foreach (var evenNumber in even(numbers))
                {
                    EvenListBox.Items.Add(evenNumber.ToString());
                }
            }

            OddListBox.Items.Clear();
            if (EvenOddRadioBtn.Text == "Odd" || EvenOddRadioBtn.Text == "Both")
            {
                foreach (var oddNumber in odd(numbers))
                {
                    OddListBox.Items.Add(oddNumber.ToString());
                }
            }
        }

        /// <summary>
        /// Returns a list of integers found in a comma separated list of natural numbers
        /// </summary>
        public static IEnumerable<Int32> parse(string inputString)
        {
            return inputString.Split(new char[] { ',' }).Select(x => Int32.Parse(x));
        }

        /// <summary>
        /// Returns a sub sequence of natural numbers that are even numbers
        /// </summary>
        public static IEnumerable<Int32> even(IEnumerable<Int32> naturalNumbers)
        {
            return naturalNumbers.Where(x => x % 2 == 0);
        }

        /// <summary>
        /// Returns a sub sequence of natural numbers that are odd numbers
        /// </summary>
        public static IEnumerable<Int32> odd(IEnumerable<Int32> naturalNumbers)
        {
            return naturalNumbers.Where(x => x % 2 != 0);
        }

    }
}