﻿using System.Web.Http;
using FluentScheduler;
using WebApi.FluentScheduler;
using WebApi.FluentScheduler.Interfacies;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        //    JobManager.Initialize(new FluentSchedulerRegistry());

        }
    }
}
