using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SearchRepositories.Utils
{
    /// <summary>
    /// Manage all session data
    /// </summary>
    public class SessionManager
    {
        private const string MARKED_REPOSITORIES = "markedRepositories";
        public dynamic MarksRepositories
        {
            get
            {
                return HttpContext.Current.Session["MARKED_REPOSITORIES"];
            }
            set
            {
                dynamic markedRepositories = HttpContext.Current.Session["MARKED_REPOSITORIES"];
                if (markedRepositories == null)
                {
                    markedRepositories = new List<dynamic>();
                }
                markedRepositories.Add(value);
                HttpContext.Current.Session["MARKED_REPOSITORIES"] = markedRepositories;

            }
        }
    }
}