using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Models;
using Xamarin.Forms;

namespace TodoList.Views
{
    public partial class CreatePage: ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new Todo();
            storeButton.Clicked += async (sender, args) =>
            {
                var newTodo = (Todo) BindingContext;
                newTodo.Done = false;
                await App.TodoContext.StoreTodo(newTodo);
                await Navigation.PopAsync();
            };
        }
    }
}
