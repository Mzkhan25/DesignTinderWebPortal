using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using DesignTinderWeb.DataObjects;
using DesignTinderWeb.Models;
using Microsoft.Azure.Mobile.Server.Tables.Config;
using Owin;

namespace DesignTinderWeb
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            
            new MobileAppConfiguration()
                .AddTables(
                    new MobileAppTableConfiguration()
                        .MapTableControllers()
                        .AddEntityFramework())
                .MapApiControllers()
                .AddMobileAppHomeController()
                .AddPushNotifications()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            Database.SetInitializer(new MobileServiceInitializer());

            var migrator = new DbMigrator(new Migrations.Configuration());

            migrator.Update();

            var settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            if (string.IsNullOrEmpty(settings.HostName))
            {
                app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
                {
                    // This middleware is intended to be used locally for debugging. By default, HostName will
                    // only have a value when running in an App Service application.
                    SigningKey = ConfigurationManager.AppSettings["SigningKey"],
                    ValidAudiences = new[] { ConfigurationManager.AppSettings["ValidAudience"] },
                    ValidIssuers = new[] { ConfigurationManager.AppSettings["ValidIssuer"] },
                    TokenHandler = config.GetAppServiceTokenHandler()
                });
            }

            app.UseWebApi(config);
        }
    }

    public class MobileServiceInitializer : CreateDatabaseIfNotExists<MobileServiceContext>
    {
        protected override void Seed(MobileServiceContext context)
        {
            string name = "Design Talk 2016 Projects -";
            List<Project> projects = new List<Project>();
            for (int i = 1; i < 56; i++)
            {
                context.Projects.AddOrUpdate(
                    new Project
                    {
                        UpVote = 0,
                        DownVote = 0,
                        URL = name + i + ".jpg"
                    }
                    );

            }

            foreach (Project project in projects)
            {
                context.Set<Project>().Add(project);
            }

            base.Seed(context);
            


        }
    }
}

