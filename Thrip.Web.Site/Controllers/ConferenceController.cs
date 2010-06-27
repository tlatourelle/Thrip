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

        public ActionResult Detail(Guid id)
        {
            //id is the conference id
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == id);
            var _viewModel = new ConferenceDetailViewModel();
            _viewModel.Conference = _conference;

            _viewModel.Sessions = (from s in DataContext.Sessions.OrderBy(x=>Guid.NewGuid())
                                   select s).Take(2).ToList();

            _viewModel.Sponsors = (from s in _conference.Sponsors.OrderBy(x=>Guid.NewGuid())
                                   select s).Take(1).ToList();

            //_viewModel.Speakers = (from s in _conference.S
            //                       select s).Take(5).ToList();

            return View(_viewModel);
        }

    }
}
