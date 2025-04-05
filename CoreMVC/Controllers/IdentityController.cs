﻿using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class IdentityController : Controller
    {
        //public List<Identity> identity = new List<Identity>()
        //    .Add(new Identity({ 1, "Trump", "Active", "2017 - 2021", "Republican", "President"});
        
        Identity identity = new Identity(1, "Obama", "Not Active", "2009 - 2017", "Democrat", "President");
        
        public JsonResult getResponse()
        {
            return Json(identity);
        }
    }
}
