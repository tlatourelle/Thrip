using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Site.Models
{
    public class SessionDetailViewModel :BaseViewModel
    {
        public Session Session { get; set; }
        //public List<ScheduledSession> ScheduledSessions { get; set; }
    }
}