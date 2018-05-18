using PhotoSharingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class PhotoController : Controller
{  public ActionResult Index()
{
    var photo = new Photo();
        return View(photo);
}
     }
 