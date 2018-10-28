using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using New.Models;
using News.Repository;

namespace News.App.Controllers
{
    public class BaseController : Controller
    {
        protected NewsDbContext Context;

        public BaseController()
        {
            this.Context = new NewsDbContext();
        }
    }
}