using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DI.WebForms
{
    public class MefPageHandlerFactory : PageHandlerFactory
    {
        public override IHttpHandler GetHandler(HttpContext context, string requestType, string virtualPath, string path)
        {
            Page page = base.GetHandler(context, requestType, virtualPath, path) as Page;

            if (page == null)
                return page;

            CompositionContainer container = context.Application["Container"] as CompositionContainer;
            container.SatisfyImportsOnce(page);

            return page;
        }
    }
}
