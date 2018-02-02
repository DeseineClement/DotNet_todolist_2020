using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        }

        private async void OnCreateButtonOnClicked(object sender, EventArgs args)
        {
            await App.TodoContext.StoreTodo(new Todo()
            {
                Title = titleEntry.Text,
                Body = bodyEntry.Text,
                Done = false,
                DueDate = dueDatePicker.Date
            });
            todoList.ItemsSource = new ObservableCollection<Todo>(await App.TodoContext.GetTodos());
        }

        private void ButtonEditOnClicked(object sender, EventArgs e)
        {
            var stack = (((sender as Button).Parent as StackLayout).Parent as StackLayout).Parent as StackLayout;
            stack.FindByName<StackLayout>("stackView").IsVisible = false;
            stack.FindByName<StackLayout>("stackEdition").IsVisible = true;
        }

        private async void ButtonDoneOnClicked(object sender, EventArgs e)
        {
            var stack = (((sender as Button).Parent as Grid).Parent as StackLayout).Parent as StackLayout;
            stack.FindByName<StackLayout>("stackView").IsVisible = true;
            stack.FindByName<StackLayout>("stackEdition").IsVisible = false;
        }
    }
}
