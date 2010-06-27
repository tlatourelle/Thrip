using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thrip.Model;

namespace Thrip.Web.Admin.Models
{
    public class ConferenceEditViewModel : BaseViewModel
    {
        public Conference Conference { get; set; }
    }
}