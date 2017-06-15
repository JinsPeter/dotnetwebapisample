using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using App.DataAccess.Repositories;
using App.DataAccess.Interfaces;
using App.Business.Managers;

namespace DotNetWebApiApp.UnityDependencyResolver
{
    public static class AppDependancyRegistry
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            container.RegisterTypes(AllClasses.FromLoadedAssemblies(), WithMappings.FromMatchingInterface, WithName.Default);
        }

    }
}