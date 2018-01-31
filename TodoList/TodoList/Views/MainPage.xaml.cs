using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;
using Xamarin.Forms;

namespace TodoList.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();
	        todoList.ItemsSource = await App.TodoContext.GetTodos();
	        createButton.Clicked += async (sender, args) =>
	        {
	            await Navigation.PushAsync(new CreatePage());
	        };
	    }
    }
}
