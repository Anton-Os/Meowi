using System.Media;

using Plugin.Maui.Audio;

namespace Meowi
{
    public partial class GamePage : ContentPage
    {

        public GamePage()
        {
            InitializeComponent();
        }

        private void OnImageButtonClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("Meow Pressed");
            // TODO: Play cat noise
            int[] numbers = { 0, 1, 2, 3 };
        }

        private void OnDeadClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("Dead Pressed");
        }
        private void OnAliveClicked(object? sender, EventArgs e)
        {
            Console.WriteLine("Alive Pressed");
        }

        private int getRandIdx()
        {
            var rand = new Random();
            return rand.Next() % 9;
        }

        // private SoundPlayer player = new SoundPlayer();
    }
}
