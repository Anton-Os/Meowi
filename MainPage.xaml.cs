namespace Meowi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetupGame();
        }


        private void SetupGame(){
            Console.WriteLine("Setting up game");
        }

        async private void OnButtonPressed(object? sender, EventArgs e){
            await Navigation.PushAsync(new GamePage());
        }
    }
}
