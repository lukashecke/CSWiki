using CSWiki.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CSWiki
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            MainPage.BackgroundColor = Color.Black;
        }

        protected override void OnStart ()
        {
            Application.Current.MainPage.DisplayAlert("Disclaimer", "This application is for training purposes only. Most of the given information is an extract of the original Microsoft Documentation. The usage of copyrighted material has not been authorized by any of the copyright owners.", "Let's Go :)");
        }

        protected override void OnSleep ()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SleepingPage());
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
