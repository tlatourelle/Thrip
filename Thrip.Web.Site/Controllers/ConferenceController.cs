using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Web.Site.Models;

namespace Thrip.Web.Site.Controllers
{
    public class ConferenceController : BaseController
    {
        //
        // GET: /Conference/

        public ActionResult Index()
        {
            var _upcomingConferences = DataContext.Conferences.Where(c => c.StartDate > DateTime.Now).ToList();
            var _viewModel = new ConferenceIndexViewModel();
            _viewModel.Conferences = _upcomingConferences;
            return View(_viewModel);
        }

    }
}
