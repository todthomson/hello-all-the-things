using Microsoft.Phone.Controls;
using Xamarin.Forms;

namespace Hello.WinPhone
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = Hello.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}



