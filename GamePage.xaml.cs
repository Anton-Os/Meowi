using System.Media;

// using Plugin.Maui.Audio;

namespace Meowi
{
    public partial class GamePage : ContentPage
    {

        public GamePage()
        {
            InitializeComponent();
        }

        private void OnImageButtonClicked(object? sender, EventArgs e){
            Console.WriteLine("Meow Pressed");
            // TODO: Play cat noise
        }

        // private SoundPlayer player = new SoundPlayer();
    }
}
