using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DI.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void lnkCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != string.Empty)
                Response.Redirect("~/Customer.aspx?id=" + txtCustomerId.Text);
        }
    }
}
