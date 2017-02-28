using Xamarin.Forms;

namespace CustomControl
{
    public class MyStackLayout: StackLayout
    {
        public MyStackLayout()
        {
            SetValue(MarginProperty, "10");
        }
    }
}
