using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thrip.Web.Site.Controllers
{
    public partial class PageController : BaseController
    {
        //
        // GET: /Page/

        public virtual ActionResult Home()
        {
            return View();
        }

        



    }
}
