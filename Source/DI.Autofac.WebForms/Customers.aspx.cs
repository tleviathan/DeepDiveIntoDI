using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace DI.WebForms
{
    public partial class Customers : Page
    {
        public ICustomerRepository _CustomerRepository { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            grdCustomers.DataSource = _CustomerRepository.GetAll();
            grdCustomers.DataBind();
        }
    }
}