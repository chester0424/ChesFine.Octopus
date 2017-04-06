using Autofac;
using Autofac.Integration.Mvc;
using ChesFine.Octopus.Core;
using ChesFine.Octopus.Core.Data;
using ChesFine.Octopus.Data;
using ChesFine.Octopus.Services.Thmes;
using ChesFine.Octopus.Services.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ChesFine.Octopus.Web.App_Start
{
    public class IocConfig

    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //实体注册
            var entitiesFilePath = HttpContext.Current.Server.MapPath("~/bin/ChesFine.Octopus.Entities.dll");
            var entitiesAssemblyTypes = Assembly.LoadFrom(entitiesFilePath).GetTypes();
            foreach (var item in entitiesAssemblyTypes)
            {
                if (item.IsSubclassOf(typeof(BaseEntity)))
                {
                    builder.RegisterType(item).InstancePerLifetimeScope();
                }
            }
            //数据库操作注册
            builder.RegisterType<OctopusDbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            //服务注册
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<ThemeService>().As<IThemeService>().InstancePerLifetimeScope();
            //控制器注册
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //autofac 注册依赖
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}