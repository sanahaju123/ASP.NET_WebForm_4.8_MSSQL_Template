using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using TaskManagementApp.DAL.Interfaces;
using TaskManagementApp.DAL.Services;
using Unity;
using Unity.AspNet.Mvc;

namespace TaskManagementApp
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            var container = new UnityContainer();

            // Register your dependencies, including IExpenseService
            container.RegisterType<ITaskService, TaskService>();
            container.RegisterType<ITaskRepository, TaskRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
