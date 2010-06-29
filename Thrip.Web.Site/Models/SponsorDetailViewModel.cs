using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Site.Models
{
    public class SponsorDetailViewModel :BaseViewModel
    {
        public Sponsor Sponsor { get; set; }
        public List<Conference> Conferences { get; set; }
        public List<Session> Sessions { get; set; }
        public List<Person> Facilitators { get; set; }

    }
}