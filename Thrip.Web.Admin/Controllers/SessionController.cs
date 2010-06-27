using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thrip.Web.Admin.Controllers
{
    public partial class SessionController : BaseController
    {
        //
        // GET: /Session/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
