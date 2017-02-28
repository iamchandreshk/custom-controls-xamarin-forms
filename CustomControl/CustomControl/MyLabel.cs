using Xamarin.Forms;

namespace CustomControl
{
    public class MyLabel: Label
    {
        public MyLabel()
        {
            SetValue(FontFamilyProperty, Device.OnPlatform(
                   null, "IndieFlower.ttf#IndieFlower", "Assets/IndieFlower.ttf#IndieFlower"));
        }
    }
}
