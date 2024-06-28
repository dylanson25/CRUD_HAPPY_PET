using CRUD_HAPPY_PET.Views;
using CRUD_HAPPY_PET.Models;
using CRUD_HAPPY_PET.Presenters;
using CRUD_HAPPY_PET.Repositories;
using System.Configuration;
namespace CRUD_HAPPY_PET
{
    internal static class Program
    {
        /*
         * Jorge told me to you close the door when you leave because 
         * he is not coming back
         */
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}