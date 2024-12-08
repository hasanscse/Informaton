using System;
using System.Globalization;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)  // To ensure the list is populated only once
            {
                PopulateMonthDropdown();
            }
        }

        private void PopulateMonthDropdown()
        {
            // Create a list of months in "MMM-yyyy" format (e.g., Jan-2024, Feb-2024)
            for (int i = 0; i < 12; i++)
            {
                var month = DateTime.Now.AddMonths(i);  // Add i months to the current date
                string monthString = month.ToString("MMM-yyyy", CultureInfo.InvariantCulture);  // Format as "Jan-2024"
                
                // Add the item to the DropDownList
                ddlMonths.Items.Add(new ListItem(monthString, monthString));
            }
        }
    }
}


/// concert yeardate 
 // Input date in the format "Jan-2025"
//string input = "Jan-2025";

        // Parse the date string using DateTime.ParseExact
     //   DateTime date = DateTime.ParseExact(input, "MMM-yyyy", CultureInfo.InvariantCulture);

        // Format the date to "yyyyMM"
      //  string formattedDate = date.ToString("yyyyMM");
