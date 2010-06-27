using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thrip.Model;
using Thrip.Web.Admin.Models;

namespace Thrip.Web.Admin.Controllers
{
    public partial class ConferenceController : BaseController
    {
        public virtual RedirectToRouteResult Index()
        {
            return RedirectToAction("List");
        }
        public virtual ActionResult Create()
        {
            var _viewModel = new ConferenceEditViewModel();
            _viewModel.Conference = new Conference();
            return View(_viewModel);
        }
        public virtual ActionResult List()
        {
            var _viewModel = new ConferenceListViewModel();
            _viewModel.Conferences = DataContext.Conferences.ToList();
            return View(_viewModel);
        }
        public virtual ActionResult Insert(Conference conference)
        {
            conference.Id = Guid.NewGuid();
            DataContext.Conferences.AddObject(conference);
            DataContext.SaveChanges();
            return RedirectToAction(MVC.Conference.ActionNames.Edit, new {id = conference.Id});
        }
        public virtual ActionResult Edit(Guid id)
        {
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == id);
            var _viewModel = new ConferenceEditViewModel();
            _viewModel.Conference = _conference;
            return View(_viewModel);
        }
        public virtual ActionResult Update(Conference conference)
        {
            var _conference = DataContext.Conferences.SingleOrDefault(c => c.Id == conference.Id);
            _conference.Name = conference.Name;
            _conference.StartDate = conference.StartDate;
            _conference.EndDate = conference.EndDate;
            _conference.Description = conference.Description;
            DataContext.SaveChanges();
            return RedirectToAction(MVC.Conference.ActionNames.Edit, new { id = conference.Id });
        }
    }
}
