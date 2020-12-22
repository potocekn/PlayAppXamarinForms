using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayApp
{
  
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async Task AlertAsync()
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");

        }
        protected void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked)
            {
                ((CheckBox)sender).Color = Color.Green;
                AlertAsync();
            }
            else
            {
                ((CheckBox)sender).Color = Color.Gray;
            }
        }

        Color defaultColor = Color.DarkBlue;
        protected void OnCheckedChangeBlue(object sender, CheckedChangedEventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (ch.IsChecked)
            {
                Frame1.BackgroundColor = Color.Aqua;
                Label1.TextColor = Color.Black;
            }
            else
            {
                Frame1.BackgroundColor = defaultColor;
                Label1.TextColor = Color.White;

            }
        }
    }
}
