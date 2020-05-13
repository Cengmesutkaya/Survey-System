using Survey_System.Models;
using Survey_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Survey_System.Controllers
{
    public class AnswerController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            List<SelectListItem> personList = (from person in db.Person
                                               where person.Code != Code
                                               select new SelectListItem
                                               {
                                                  Text = person.NameSurname,
                                                   Value = person.Code.ToString()
                                               }).ToList();

            ViewBag.Person = new SelectList(personList.OrderBy(m => m.Text), "Value", "Text");

            var questionModel = db.Question.ToList();
            return View(questionModel);
        }

        public String SendData(AnswerModel answerModel)
        {
            return "True";
        }


    }
}