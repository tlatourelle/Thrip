using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Thrip.Model;

namespace Thrip.Sandbox
{
    class Program
    {

        static void Main(string[] args)
        {
            ThripEntities _dataContext = new ThripEntities();

            CreateSampleData(_dataContext);
        }


        static void CreateSampleData(ThripEntities dataContext)
        {
            CreateSampleConference(dataContext);
            dataContext.SaveChanges();
            CreateSamplePeople(dataContext);
            dataContext.SaveChanges();
            CreateSampleSessions(dataContext);
            dataContext.SaveChanges();
            CreateSampleLocations(dataContext);
            dataContext.SaveChanges();
            CreateSampleTimeSlots(dataContext);
            dataContext.SaveChanges();
            CreateSampleScheduledSessions(dataContext);
            dataContext.SaveChanges();
        }

        static void CreateSampleConference(ThripEntities dataContext)
        {
            var _conference = new Conference();
            
            _conference.Id = Guid.NewGuid();
            _conference.Name = "MVC Springboard";
            _conference.StartDate = DateTime.Parse("9/3/2010");
            _conference.EndDate = DateTime.Parse("9/5/2010");
            _conference.Description = "A really great conference!  Come and see.";
            _conference.URL = "http://www.mvcspringboard.org";
            dataContext.Conferences.AddObject(_conference);
        }

        static void CreateSampleLocations(ThripEntities dataContext)
        {
            var _location = new Location();

            _location.Id = Guid.NewGuid();
            _location.Name = "Main Ballroom";
            _location.Description = "";

            dataContext.Locations.AddObject(_location);

            _location = new Location();

            _location.Id = Guid.NewGuid();
            _location.Name = "Franklin Room";
            _location.Description = "";

            dataContext.Locations.AddObject(_location);


            _location = new Location();

            _location.Id = Guid.NewGuid();
            _location.Name = "Washington Room";
            _location.Description = "";

            dataContext.Locations.AddObject(_location);

            _location = new Location();

            _location.Id = Guid.NewGuid();
            _location.Name = "Jefferson Room";
            _location.Description = "";

            dataContext.Locations.AddObject(_location);

            _location = new Location();

            _location.Id = Guid.NewGuid();
            _location.Name = "Lincoln Room";
            _location.Description = "";

            dataContext.Locations.AddObject(_location);

        }

        static void CreateSamplePeople(ThripEntities dataContext)
        {
            var _person = new Person();

            _person.Id = Guid.NewGuid();
            _person.FirstName = "Tom";
            _person.LastName = "LaTourelle";
            _person.Email = "tlatourelle@hotmail.com";
            dataContext.People.AddObject(_person);

            _person = new Person();

            _person.Id = Guid.NewGuid();
            _person.FirstName = "J";
            _person.LastName = "Wynia";
            _person.Email = "j@wynia.com";
            dataContext.People.AddObject(_person);

            _person = new Person();

            _person.Id = Guid.NewGuid();
            _person.FirstName = "Javier";
            _person.LastName = "Lozano";
            _person.Email = "javier@lozano.com";
            dataContext.People.AddObject(_person);

            _person = new Person();

            _person.Id = Guid.NewGuid();
            _person.FirstName = "Dedrick";
            _person.LastName = "Tucker";
            _person.Email = "dtucker@gmail.com";
            dataContext.People.AddObject(_person);


        }

        static void CreateSampleSessions(ThripEntities dataContext)
        {
            var _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "MVC 101";
            _session.Description = "From A to MVC in no time flat!";
            _session.Tags = "mvc,intro";
            var _facilitator = dataContext.People.Where(p => p.LastName == "Wynia").SingleOrDefault();
            _session.Facilitators.Add(_facilitator);

            dataContext.Sessions.AddObject(_session);

            _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "Breakfast and Keynote";
            _session.Description = "";
            _session.Tags = "keynote";
            _session.Facilitators.Add(dataContext.People.Where(p => p.LastName == "Lozano").SingleOrDefault());

            dataContext.Sessions.AddObject(_session);

            _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "Spark and MVC";
            _session.Description = "From Web forms to Spark forms ";
            _session.Tags = "mvc,Spark";
            _session.Facilitators.Add(dataContext.People.Where(p => p.LastName == "LaTourelle").SingleOrDefault());

            dataContext.Sessions.AddObject(_session);

            _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "Entity Framework and MVC";
            _session.Description = "Getting MVC hooked up to EF";
            _session.Tags = "mvc,Entity Framework";
            _session.Facilitators.Add(dataContext.People.Where(p => p.LastName == "Tucker").SingleOrDefault());

            dataContext.Sessions.AddObject(_session);

        }

        static void CreateSampleTimeSlots(ThripEntities dataContext)
        {
            var _timeSlot = new TimeSlot();

            _timeSlot.Id = Guid.NewGuid();
            _timeSlot.Name = "Welcome Session";
            _timeSlot.StartDate = DateTime.Now; // DateTime.Parse("9/3/2010 08:00");
            _timeSlot.EndDate = DateTime.Now.AddHours(1); // DateTime.Parse("9/3/2010 09:00");
            dataContext.TimeSlots.AddObject(_timeSlot);

            dataContext.SaveChanges();

            _timeSlot = new TimeSlot();

            _timeSlot.Id = Guid.NewGuid();
            _timeSlot.Name = "Friday Morning";
            _timeSlot.StartDate = DateTime.Parse("9/3/2010 09:15");
            _timeSlot.EndDate = DateTime.Parse("9/3/2010 11:00");
            dataContext.TimeSlots.AddObject(_timeSlot);

            dataContext.SaveChanges();

            _timeSlot = new TimeSlot();

            _timeSlot.Id = Guid.NewGuid();
            _timeSlot.Name = "Friday Midday";
            _timeSlot.StartDate = DateTime.Parse("9/3/2010 11:15");
            _timeSlot.EndDate = DateTime.Parse("9/3/2010 12:45");
            dataContext.TimeSlots.AddObject(_timeSlot);

            dataContext.SaveChanges();

            _timeSlot = new TimeSlot();

            _timeSlot.Id = Guid.NewGuid();
            _timeSlot.Name = "Friday Afternoon";
            _timeSlot.StartDate = DateTime.Parse("9/3/2010 13:00");
            _timeSlot.EndDate = DateTime.Parse("9/3/2010 16:00");
            dataContext.TimeSlots.AddObject(_timeSlot);

            dataContext.SaveChanges();

            _timeSlot = new TimeSlot();

            _timeSlot.Id = Guid.NewGuid();
            _timeSlot.Name = "Satuday Wake-up";
            _timeSlot.StartDate = DateTime.Parse("9/4/2010 08:00");
            _timeSlot.EndDate = DateTime.Parse("9/4/2010 09:00");
            dataContext.TimeSlots.AddObject(_timeSlot);

            dataContext.SaveChanges();
        }

        static void CreateSampleScheduledSessions(ThripEntities dataContext)
        {
            var _scheduledSession = new ScheduledSession();

            _scheduledSession.Id = Guid.NewGuid();
            _scheduledSession.SessionId = dataContext.Sessions.Where(s => s.Name == "Breakfast and Keynote").SingleOrDefault().Id;
            _scheduledSession.TimeSlotId = dataContext.TimeSlots.Where(ts => ts.Name == "Welcome Session").SingleOrDefault().Id;
            _scheduledSession.LocationId = dataContext.Locations.Where(l => l.Name == "Main Ballroom").SingleOrDefault().Id;
            dataContext.ScheduledSessions.AddObject(_scheduledSession);

            _scheduledSession = new ScheduledSession();

            _scheduledSession.Id = Guid.NewGuid();
            _scheduledSession.SessionId = dataContext.Sessions.Where(s => s.Name == "MVC 101").SingleOrDefault().Id;
            _scheduledSession.TimeSlotId = dataContext.TimeSlots.Where(ts => ts.Name == "Friday Morning").SingleOrDefault().Id;
            _scheduledSession.LocationId = dataContext.Locations.Where(l => l.Name == "Franklin Room").SingleOrDefault().Id;
            dataContext.ScheduledSessions.AddObject(_scheduledSession);

            _scheduledSession = new ScheduledSession();

            _scheduledSession.Id = Guid.NewGuid();
            _scheduledSession.SessionId = dataContext.Sessions.Where(s => s.Name == "Spark and MVC").SingleOrDefault().Id;
            _scheduledSession.TimeSlotId = dataContext.TimeSlots.Where(ts => ts.Name == "Friday Afternoon").SingleOrDefault().Id;
            _scheduledSession.LocationId = dataContext.Locations.Where(l => l.Name == "Lincoln Room").SingleOrDefault().Id;
            dataContext.ScheduledSessions.AddObject(_scheduledSession);
        
        }



    }
}
