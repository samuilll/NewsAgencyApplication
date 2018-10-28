using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using News.Repository;
using NewsAgency.App.Utilities.Mapper;

namespace NewsAgency.App.Controllers
{
    public class BaseController:Controller
    {
        protected NewsDbContext DbContext;

        protected IMapper Mapper;

        public BaseController()
        {
            DbContext = new NewsDbContext();
            //this.Mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
        }
    }
}