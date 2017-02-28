using Xamarin.Forms;

namespace CustomControl
{
    public class MyEntry: Entry
    {
        public MyEntry()
        {
            SetValue(FontFamilyProperty, Device.OnPlatform(
                   null, "IndieFlower.ttf#IndieFlower", "Assets/IndieFlower.ttf#IndieFlower"));
        }
    }
}
