using Autofac;
using CRM.Data.Interfaces.Interfaces;
using CRM.Desktop.Views.Forms;
using CRM.Services.BusinessServices;
using System;
using System.Windows.Forms;
using CRM.Data.EF.Access;
using CRM.Data.EF;

namespace CRM.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CRMContext>();

            builder.RegisterType<FClientAccess>().As<IClientAccess>();
            builder.RegisterType<FContactAccess>().As<IContactAccess>();
            builder.RegisterType<FProjectAccess>().As<IProjectAccess>();

            builder.RegisterType<ContactService>().As<IContactService>();
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProjectService>().As<IProjectService>();

            builder.RegisterType<FClients>();
            builder.RegisterType<FAddClient>();
            builder.RegisterType<FAddContact>();
            builder.RegisterType<FaddProject>();
            builder.RegisterType<FUpdateContact>();
            builder.RegisterType<FUpdateProject>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(scope.Resolve<FClients>());
            }
        }
    }
}
