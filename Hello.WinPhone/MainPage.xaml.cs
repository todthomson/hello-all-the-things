using Xamarin.Forms;

namespace Hello.WinPhone
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Forms.Init();
            Content = XamarinForms.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}
