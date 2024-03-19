namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void Button15Percent(object sender, EventArgs e)
        {
            TipPercentLabel.Text = $" {PercentageSlider.Value.ToString()}";
        }
        public void Button30Percent(object sender, EventArgs e)
        {

        }
        public void ButtonRoundUp(object sender, EventArgs e)
        {

        }
        public void ButtonRoundDown(object sender, EventArgs e)
        {

        }
    }

}
