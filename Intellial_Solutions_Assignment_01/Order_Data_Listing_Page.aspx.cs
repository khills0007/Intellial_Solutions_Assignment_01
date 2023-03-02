using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Intellial_Solutions_Assignment_01.Order_Listing
{
    public partial class Order_Data_Listing_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_addorder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Order.aspx");
        }
    }
}