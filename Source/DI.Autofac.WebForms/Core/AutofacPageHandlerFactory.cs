using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Autofac;

namespace DI.WebForms.Core
{
    public class AutofacPageHandlerFactory : PageHandlerFactory
    {
        public override IHttpHandler GetHandler(HttpContext context, string requestType, string virtualPath, string path)
        {
            Page page = base.GetHandler(context, requestType, virtualPath, path) as Page;

            if (page == null)
                return page;

            IContainer container = context.Application["Container"] as IContainer;

            container.InjectProperties(page);

            return page;
        }
    }
}

// can also go the PageBase route
