using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Web.Site.Models;

namespace Thrip.Web.Site.Controllers
{
    public partial class FacilitatorController : BaseController
    {

        public virtual ActionResult List(Guid id)
        {
            // id is the conference id
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == id);
            var _viewModel = new FacilitatorListViewModel();
            _viewModel.Facilitators = _conference.Facilitators.ToList();
            return View(_viewModel);
        }

        public virtual ActionResult Detail(Guid id)
        {
            //id is the facilitator id (person id)
            var _facilitator = DataContext.People.SingleOrDefault(c => c.Id == id);
            var _viewModel = new FacilitatorDetailViewModel();
            _viewModel.Sessions = _facilitator.Sessions.ToList();
            return View(_viewModel);
        }

    }
}
