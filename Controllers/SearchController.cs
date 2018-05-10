using SearchRepositories.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchRepositories.Controllers
{
    public class SearchController : Controller
    {
        SessionManager sessionManager = new SessionManager();
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Add marked reposiroty into the session
        /// </summary>
        /// <param name="repositoryName"></param>
        /// <param name="avatar"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult MarkRepository(string repositoryName,string avatar)
        {
            sessionManager.MarksRepositories = new { RepositoryName = repositoryName, Avatar = avatar };
            return Json(true);
        }

        public ActionResult MarkedRepositories()
        {
            return View();
        }

        /// <summary>
        /// Get all marked repositories from the session
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetMarkedRepository()
        {
            return Json(sessionManager.MarksRepositories,JsonRequestBehavior.AllowGet);
        }
    }
}