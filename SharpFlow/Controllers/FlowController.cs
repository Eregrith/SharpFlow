using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpFlow.Models;

namespace SharpFlow.Controllers
{
    public class FlowController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public JsonResult GetBranches()
        {
            string repository = Repository.Discover("H:/Projects/Sites/");
            Repository repo = new Repository(repository);

            LightweightRepository lightRepo = new LightweightRepository(repo);

            return Json(lightRepo, JsonRequestBehavior.AllowGet);
        }
    }
}