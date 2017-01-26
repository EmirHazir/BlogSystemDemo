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

        public BaseController()
            : this(new BlogSystemDemoData())
        {

        }

        public BaseController(IBlogSystemDemoData data)
        {
            this.Data = data;
        }

        protected IBlogSystemDemoData Data { get; private set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }


    }
}