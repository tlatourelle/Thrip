using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Admin.Models
{
    public class ConferenceListViewModel : BaseViewModel
    {
        public List<Conference> Conferences { get; set; }
    }
}