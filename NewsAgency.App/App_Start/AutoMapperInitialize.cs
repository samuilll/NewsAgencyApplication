using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MapperConfiguration = NewsAgency.App.Utilities.Mapper.MapperConfiguration;

namespace NewsAgency.App.App_Start
{
    public  class AutoMapperInitialize
    {
        public static void InitializeMapper()
        {
            Mapper.Initialize(MapperConfiguration.Configure);
        }

    }
}