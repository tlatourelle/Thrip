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
            CreateSampleSessions(dataContext);
            CreateSampleLocations(dataContext);

            dataContext.SaveChanges();
        }

        static void CreateSampleConference(ThripEntities dataContext)
        {
            var _conference = new Conference();
            
            _conference.Id = Guid.NewGuid();
            _conference.Name = "MVC Springboard";
            _conference.StartDate = DateTime.Parse("9/1/2010");
            _conference.EndDate = DateTime.Parse("9/5/2010");
            _conference.Description = "A really great conference!  Come and see.";
            _conference.URL = "http://www.mvcspringboard.org";
            dataContext.Conferences.AddObject(_conference);
        }

        static void CreateSampleSessions(ThripEntities dataContext)
        {
            var _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "MVC 101";
            _session.Description = "From A to MVC in no time flat!";
            _session.Tags = "mvc,intro";

            dataContext.Sessions.AddObject(_session);

            _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "Spark and MVC";
            _session.Description = "From Web forms to Spark forms ";
            _session.Tags = "mvc,Spark";

            dataContext.Sessions.AddObject(_session);

            _session = new Session();

            _session.Id = Guid.NewGuid();
            _session.Name = "Entity Framework and MVC";
            _session.Description = "Getting MVC hooked up to EF";
            _session.Tags = "mvc,Entity Framework";

            dataContext.Sessions.AddObject(_session);

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




    }
}
