using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoPage : ContentPage
    {
        public List<string> TodoItems { get; set; }

        public ToDoPage()
        {
            InitializeComponent();

            this.TodoItems = new List<string>();
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newToDoItemEntry.Text))
            {
                DisplayAlert("Error", "Please enter a value", "Ok");
            }
            else
            {
                this.TodoItems.Add(newToDoItemEntry.Text);

                toDoList.ItemsSource = this.TodoItems;

                newToDoItemEntry.Text = "";
            }

        }

        private void clearItemButton_Clicked(object sender, EventArgs e)
        {
            this.TodoItems.Clear();

            toDoList.ItemsSource = new List<string>();

        }
    }
}