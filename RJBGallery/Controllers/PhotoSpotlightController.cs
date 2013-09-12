using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RJBGallery.Models;

namespace RJBGallery.Controllers
{
    public class PhotoSpotlightController : Controller
    {
        //
        // GET: /PhotoSpotlight/

        public ActionResult Index()
        {
            Photo ph = new Photo();
              ph.photoName = "Robert";
            
            return View(ph);
        }

        [HttpPost]
        public ActionResult Index(Photo photoObj)
        {
            

            return View(photoObj);
        }

    }
}
