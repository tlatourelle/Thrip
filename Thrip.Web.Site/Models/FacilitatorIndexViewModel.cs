using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Site.Models
{
    public class FacilitatorIndexViewModel :BaseViewModel
    {
        public List<Person> Facilitators { get; set; }
    }
}