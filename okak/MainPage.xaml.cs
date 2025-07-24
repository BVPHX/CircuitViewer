namespace okak
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
            List<string> nuda = new List<string>();
            nuda.Add("dad");
            nuda.Add("dd");
            nuda.Add("dda");
            nuda.Add("ad");
            nuda.Add("ddad");
            nuda.Add("d");
            nuda.Add("ddd");
            machinesList.ItemsSource = nuda;
            //Не важно
        }

        private void machinesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (machinesList.SelectedItem != null) 
            Navigation.PushAsync(new NewPage1());//Открывает окно
            else machinesList.SelectedItem = null;
            
        }
    }

}
