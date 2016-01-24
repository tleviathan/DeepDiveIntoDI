using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace DI.WebForms
{
    public partial class Customers : System.Web.UI.Page
    {
        [Import]
        ICustomerRepository _CustomerRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            grdCustomers.DataSource = _CustomerRepository.GetAll();
            grdCustomers.DataBind();
        }
    }
}