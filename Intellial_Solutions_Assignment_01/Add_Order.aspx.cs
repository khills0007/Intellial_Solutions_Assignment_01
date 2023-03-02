using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Intellial_Solutions_Assignment_01.Order_Listing;

namespace Intellial_Solutions_Assignment_01
{
    
    public partial class Add_Order : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Projects\Intellial Solutions\Asp_net_Project\Intellial_Solutions_Assignment_01\Intellial_Solutions_Assignment_01\App_Data\Order_Data_Listing.mdf"";Integrated Security=True");
        SqlCommand cmd;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void display()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table";
            cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable(); 
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //dataAdapter.Fill(dt);
            //GridView2.DataSource = dt;
            //GridView2.DataBind();
            conn.Close();


        }

        public void clrData()
        {
            txtbox_customer.Text = " ";
            txtbox_product.Text = " ";
            txtbox_remarks.Text = " ";
        }

        protected void btn_placeorder_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table values('" + txtbox_customer.Text + "','" + txtbox_product.Text + "','" + txtbox_remarks + "')";
            conn.Close();
            Server.Transfer("Order_Data_Listing_Page.aspx");
           // display();
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            clrData();
        }
    }
}