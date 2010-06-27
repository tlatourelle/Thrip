using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Model;

namespace Thrip.Web.Site.Controllers
{
    public partial class BaseController : Controller
    {
        public ThripEntities DataContext;

        public BaseController()
        {
            DataContext = new ThripEntities();
        }

    }
}
