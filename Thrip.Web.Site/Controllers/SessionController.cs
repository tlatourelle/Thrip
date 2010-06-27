using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Web.Site.Models;

namespace Thrip.Web.Site.Controllers
{
    public partial class SessionController : BaseController
    {
        //
        // GET: /Session/

        public virtual ActionResult List(Guid id)
        {
            //id is the conference id
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == id);
            var _viewModel = new SessionListViewModel();
            _viewModel.Conference = _conference;
            _viewModel.Sessions = _conference.Sessions.ToList();
            return View(_viewModel);
        }

    }
}
