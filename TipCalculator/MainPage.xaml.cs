using Microsoft.Extensions.Options;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button15Percent(object sender, EventArgs e)
        {
           PercentagesSlider.Value = 15;
        }
        private void Button30Percent(object sender, EventArgs e)
        {
            PercentagesSlider.Value = 30;

        }
        private void ButtonRoundUp(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TigLabel.Text = tip.ToString("C2");
            double Valrefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            TotalLabel.Text = Valrefeicao.ToString("C2");
        }
        private void ButtonRoundDown(object sender, EventArgs e)
        {

        }
        private double CalculateTip()
        {
            double Valrefeição = Convert.ToDouble(ValueEntry.Text);
            double Valporcentagem = Convert.ToDouble(PercentagesSlider.Value);
            double ValorGorjeta = Valrefeição*(Valporcentagem/100);
            return (ValorGorjeta);
        }
        private void PercentagensSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TigLabel.Text = $"{PercentagesSlider.Value.ToString()}%";
                
        }
    }


}
