using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFS3204Prac3
{
    public partial class Search : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            var stores = client.GetAllStores(name.Text);

            if (stores == null)
            {
                Error.CssClass = "alert alert-danger";
                Error.Text = "Not Found";
                return;
            }
            else
            {
                Error.CssClass = "";
                Error.Text = "";
            }

            var row = new TableRow();

            var headerCell = new TableHeaderCell();
            headerCell.Text = "ID";
            row.Cells.Add(headerCell);

            headerCell = new TableHeaderCell();
            headerCell.Text = "Address";
            row.Cells.Add(headerCell);

            headerCell = new TableHeaderCell();
            headerCell.Text = "name";
            row.Cells.Add(headerCell);

            headerCell = new TableHeaderCell();
            headerCell.Text = "Branch No.";
            row.Cells.Add(headerCell);

            headerCell = new TableHeaderCell();
            headerCell.Text = "Phone No.";
            row.Cells.Add(headerCell);

            Table1.Rows.Add(row);

            foreach(var store in stores)
            {
                row = new TableRow();

                var cell = new TableCell();
                cell.Text = store.ID;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = store.address;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = store.name;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = store.branchNO.ToString();
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = store.phoneNumber.ToString();
                row.Cells.Add(cell);

                Table1.Rows.Add(row);
            }
        }
    }
}