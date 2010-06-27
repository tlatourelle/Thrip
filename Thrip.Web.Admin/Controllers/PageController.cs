using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Web.Admin.Models;

namespace Thrip.Web.Admin.Controllers
{
    public partial class PageController : BaseController
    {
        public virtual ActionResult Home()
        {
            var _viewModel = new BaseViewModel();

            return View(_viewModel);
        }
    }
}
