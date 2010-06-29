using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Web.Site.Models;

namespace Thrip.Web.Site.Controllers
{
    public partial class SponsorController : BaseController
    {
        //id is the conference id (person id)
        public virtual ActionResult List(Guid id)
        {
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == id);
            var _viewModel = new SponsorListViewModel();
            _viewModel.Sponsors = _conference.Sponsors.ToList();
            return View(_viewModel);
        }

        public virtual ActionResult Detail(Guid id)
        {
            //id is the Sponsor id
            var _facilitator = DataContext.People.SingleOrDefault(c => c.Id == id);
            var _viewModel = new SponsorDetailViewModel();
            _viewModel.Sessions = _facilitator.Sessions.ToList();
            return View(_viewModel);
        }

    }
}
