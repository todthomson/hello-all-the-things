using Hello.WinPhone.Resources;

namespace Hello.WinPhone
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static readonly AppResources _LocalizedResources = new AppResources();

        public AppResources LocalizedResources
        {
            get { return _LocalizedResources; }
        }
    }
}
