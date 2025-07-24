namespace okak
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY"); //Все, пиздец, дай денег (они не возьмут)

            MainPage = new AppShell();
        }
    }
}
