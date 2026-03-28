namespace ManageAlbumsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            const int newHeight = 600;
            //I made the UI width slightly large so as it can still be visible when the ResultsLabel.Text shows to the user.
            const int newWidth = 1075;

            var newWindow = new Window(new AppShell())
            {
                Height = newHeight,
                Width = newWidth
            };

            return newWindow;
        }
    }
}