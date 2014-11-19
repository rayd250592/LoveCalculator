using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Love_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private  async void Button_Click(object sender, RoutedEventArgs e)
        {
            Random matchran = new Random();
            int matchint = matchran.Next(1, 101);
            res.Visibility = Windows.UI.Xaml.Visibility.Visible;
            percent.Visibility = Windows.UI.Xaml.Visibility.Visible;
            res.Text = matchint.ToString();

            if (matchint < 20)
            {
                MessageDialog msg = new MessageDialog("Oh dear - things don't look good!");
                await msg.ShowAsync();
            }
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)

        {
            MessageDialog msg = new MessageDialog("Developed by Raymond Dillon");
            await msg.ShowAsync();
        }
    }
}
