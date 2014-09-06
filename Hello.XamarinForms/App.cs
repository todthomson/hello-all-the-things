using Xamarin.Forms;

namespace Hello.XamarinForms
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ContentPage
            {
                Content =
                    new Label
                    {
                        Text = "Hello, Xamarin Forms!",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                    },
            };
        }
    }
}
