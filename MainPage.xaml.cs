namespace JulianTorresProgreso2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void BotonIrAChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());
        }

        private void BotonIrAAbput_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
