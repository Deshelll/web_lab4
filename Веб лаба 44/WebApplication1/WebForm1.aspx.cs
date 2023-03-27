using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            GridView1.DataSource = client.GetCustomers();
            GridView1.DataBind();


            /*ServiceReference1.Service1Client order = new ServiceReference1.Service1Client();
            GridView2.DataSource = order.GetOrders(int.Parse(GridView1.SelectedRow.Cells[1].Text, out Id));
            GridView2.DataBind();*/
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client order = new ServiceReference1.Service1Client();
            GridView2.Enabled = true;
            GridView2.DataSource = order.GetOrders(int.Parse(GridView1.SelectedRow.Cells[1].Text));
            GridView2.DataBind();


        }
    }
}