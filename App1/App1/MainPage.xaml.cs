using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

       /* async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new PolicyPage());
        }*/

        async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PolicyPage());
           
        }
    }
}
