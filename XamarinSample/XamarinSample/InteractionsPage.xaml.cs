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
    public partial class InteractionsPage : ContentPage
    {
        public InteractionsPage()
        {
            InitializeComponent();

            
        }

        private void interactionButton_Clicked(object sender, EventArgs e)
        {
            decimal result = Convert.ToDecimal(firstnumberEntry.Text) + Convert.ToDecimal(secondnumberEntry.Text);

            resultLabel.Text = result.ToString();
        }
    }
}