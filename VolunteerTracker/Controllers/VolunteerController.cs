using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteerTracker.Controllers
{


    /// <summary>
    /// When admin clicks "manage volunteers" link, a list of all volunteers will be displayed by default. 
    /// 
    /// On that page will be a filters dropdown with the 6 options below. When the admin selects a filter the 
    /// list method will be call with new filter as parameter. 
    /// 
    /// There will also be a search box at the top to search by name. The adim will type in desired name which will
    /// be passed to the search get method. A list of volunteers matching the search will be displayed. 
    /// 
    /// Each volunteer row on the list of volunteers will have a link, "view opportunitty matches". When clicked a new view 
    /// will be displayed with a list of opportunitties (name, description, ...) that fit the volunteer's schedule
    /// 
    /// The "edit volunteer" link will also be in each volunteer row.
    /// 
    /// The "add volunteer" (button/link) will be at the top in the same area as the filters. 
    /// </summary>
    
    public class VolunteerController : Controller 
    {
        // GET: Volunteer
        public ActionResult Index()
        {
            return View();
        }


        /* list of volunteers with filter logic in method. Default filter parameter will be "all". 
         * Filter option to include: approved/pending approval, approved, pending approval, disapproved, 
         * inactive, all.
         */
        public ActionResult ListVolunteers()
        {
            return View();
        }


        /* search volunteers: get, will provide user with search box to input search criteria
         * Search criteria (string) will be passed to HttpPost method. 
         */
        [HttpGet]
        public ActionResult SearchVolunteers()
        {
            return View();
        }


        // search volunteers: post, will  return search results based on string received
        [HttpPost]
        public ActionResult SearchVolunteers(string searchName)
        {
            return View();
        }


        /* view volunteer opportunity matches, will be called when link(in volunteer list) is 
         * clicked and will display event that fit the volunteer's schedule
         * 
         * Param: daysAvailable == volunteer.availability.daysAvailable
         * ***need to determine what type of object will be passed 
         */
        public ActionResult ViewOpportunityMatches(object daysAvailable)
        {
            return View();
        }


        // edit volunteer 
        public ActionResult EditVolunteer()
        {
            return View();
        }


        // add volunteer 
        public ActionResult AddVolunteer()
        {
            return View();
        }


        // delete volunteer ***optional
    }
}