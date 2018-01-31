using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TodoList.Contexts;
using TodoList.Models;
using TodoList.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace TodoList
{
	public partial class App : Application
	{
	    static TodoContext todoContext;

	    public static TodoContext TodoContext
	    {
	        get
	        {
	            if (todoContext == null)
	            {
	                var databasePath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoList.db");
	                todoContext = TodoContext.Create(databasePath);
	            }

	            return todoContext;
	        }
	    }

	    public App ()
		{
			InitializeComponent();
		    MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
