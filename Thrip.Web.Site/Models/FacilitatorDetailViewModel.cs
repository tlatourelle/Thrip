using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Site.Models
{
    public class FacilitatorDetailViewModel :BaseViewModel
    {
        public Person Facilitator { get; set; }
        public List<Session> Sessions { get; set; }

    }
}