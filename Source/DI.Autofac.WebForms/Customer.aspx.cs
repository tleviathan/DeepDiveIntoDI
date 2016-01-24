using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace DI.WebForms
{
    public partial class Customer1 : Page
    {
        public ICustomerRepository _CustomerRepository { get; set; }

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