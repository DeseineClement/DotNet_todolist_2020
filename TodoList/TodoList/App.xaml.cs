using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TodoList.Contexts;
using TodoList.Models;
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
		   
		    TodoContext.Add(new Todo() {Title = "Test", Body = "Body", DueDate = new DateTime(), Done = false});
		    TodoContext.SaveChanges();

            MainPage = new MainPage();
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
