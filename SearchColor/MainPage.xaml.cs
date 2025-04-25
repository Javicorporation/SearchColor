
namespace SearchColor
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            // eliminamos el codigo por defecto
        }


        // manejador de eventos
        private void Slider_ValueChanged(Object sender, ValueChangedEventArgs e) {
            var red = slrRed.Value;
            var green = slrGreen.Value;
            var blue = slrBlue.Value;

            Color color = Color.FromRgb(red, green, blue);

            setColor(color);
        }

        private void setColor(Color color)
        {
            btnRandom.BackgroundColor = color;
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }

        public void btnRandom_Clicker(object sender, EventArgs e) { 
            var random = new Random();
            var color = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0,256)
                );
            setColor(color);
            slrRed.Value = color.Red;
            slrGreen.Value = color.Green;
            slrBlue.Value = color.Blue;

        }
    }
}
