
using Xamarin.Forms;

namespace CustomControl
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "CustomControl",
            //    Content = new MyStackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new MyLabel() { Text = "Hello"},
            //            new MyEntry() { Text = "Hello"},
            //            new MyButton() { Text = "Hello"}
            //        }
            //    }
            //};

            //MainPage = new NavigationPage(content);
            MainPage = new PageHome();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
