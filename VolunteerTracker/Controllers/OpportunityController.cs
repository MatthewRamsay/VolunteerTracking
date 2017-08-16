using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteerTracker.Controllers
{
    public class OpportunityController : Controller
    {
        // GET: Opportunity
        public ActionResult Index()
        {
            return View();
        }
    }
}