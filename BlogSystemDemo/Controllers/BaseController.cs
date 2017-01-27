using AutoMapper;
using BlogSystemDemo.Common.Mapping;
using BlogSystemDemo.Data; //IBlogSystemDemoData
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BlogSystemDemo.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}