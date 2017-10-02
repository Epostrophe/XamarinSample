using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Assignment2());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InteractionsPage());
        }

        private void todoButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToDoPage());
        }

        private void gridButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }
    }
}
