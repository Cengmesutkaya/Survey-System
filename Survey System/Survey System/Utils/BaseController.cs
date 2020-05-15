using Survey_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Survey_System.Utils
{
    public class BaseController : Controller
    {
       public SurveyEntities db = new SurveyEntities();
        public string UserCode { get; set; }
        public string NameSurname { get; set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (Session["Code"] == null)
            {
                filterContext.Result = new RedirectResult("/Login/SignIn");
            }
            else
            {
                UserCode = Session["Code"].ToString();
                NameSurname = Session["NameSurname"].ToString();
            }
            base.OnActionExecuting(filterContext);
        }
    }
}