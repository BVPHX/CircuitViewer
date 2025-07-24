namespace okak
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
            List<string> nuda = new List<string>();
            nuda.Add("ddad");
            nuda.Add("ddad");
            nuda.Add("ddad");
            nuda.Add("ddad");
            nuda.Add("ddad");
            nuda.Add("ddad");
            nuda.Add("ddad");
            machinesList.ItemsSource = nuda;
            //Не важно
        }

        private void machinesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new NewPage1());//Открывает окно
        }
    }

}
