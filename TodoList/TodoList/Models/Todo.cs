using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TodoList.Models
{
    public class Todo: INotifyPropertyChanged
    {
        private string title;
        private string body;
        private DateTime dueDate;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    App.TodoContext.StoreTodo(this);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string Body
        {
            get => body;
            set
            {
                if (body != value)
                {
                    body = value;
                    App.TodoContext.StoreTodo(this);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Body"));
                }
            }
        }

        public DateTime DueDate {
            get => dueDate;
            set
            {
                if (dueDate != value)
                {
                    dueDate = value;
                    App.TodoContext.StoreTodo(this);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DueDate"));
                }
            }
        }
        public bool Done { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
