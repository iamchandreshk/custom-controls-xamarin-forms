using Xamarin.Forms;

namespace CustomControl
{
    public class MyButton : Button
    {
        public MyButton()
        {
            SetValue(FontFamilyProperty, Device.OnPlatform(
                   null, "IndieFlower.ttf#IndieFlower", "Assets/IndieFlower.ttf#IndieFlower"));
            SetValue(BorderRadiusProperty, "5");
            SetValue(BackgroundColorProperty, Color.Blue);
            SetValue(TextColorProperty, Color.White);
            SetValue(MarginProperty, "10");
        }
    }
}
