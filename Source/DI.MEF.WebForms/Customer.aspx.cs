using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace DI.WebForms
{
    public partial class Customer1 : System.Web.UI.Page
    {
        [Import]
        ICustomerRepository _CustomerRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.QueryString["id"];
            if (string.IsNullOrWhiteSpace(value))
                value = "1";

            detCustomer.DataSource = new List<Customer>() { _CustomerRepository.GetById(Convert.ToInt32(value)) };
            detCustomer.DataBind();
        }
    }
}