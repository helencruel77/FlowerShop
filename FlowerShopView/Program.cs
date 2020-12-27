using BusinessLogic.BusinessLogics;
using BusinessLogic.Controller;
using BusinessLogic.HelperModels;
using BusinessLogic.Interfaces;
using Database.Implements;
using System;
using System.Configuration;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace FlowerShopView
{
    static class Program
    {
        public static bool IsLogined { get; set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            MailLogic.MailConfig(new MailConfig
            {
                SmtpClientHost = ConfigurationManager.AppSettings["SmtpClientHost"],
                SmtpClientPort = Convert.ToInt32(ConfigurationManager.AppSettings["SmtpClientPort"]),
                MailLogin = ConfigurationManager.AppSettings["MailLogin"],
                MailPassword = ConfigurationManager.AppSettings["MailPassword"],
            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new FormEnter();
            form.ShowDialog();
            if (IsLogined)
            {
                Application.Run(container.Resolve<FormMain>());
            }
        }
        private static IUnityContainer BuildUnityContainer()
        {
            {
                var currentContainer = new UnityContainer();
                currentContainer.RegisterType<IBouquetLogic, BouquetLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<IFlowerLogic, FlowerLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<IPackagingLogic, PackagingLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<IClientLogic, ClientLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<IRequestLogic, RequestLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<MainLogic>(new HierarchicalLifetimeManager());
                currentContainer.RegisterType<ExceptionHandling>(new HierarchicalLifetimeManager());

                return currentContainer;
            }
        }
    }
}
