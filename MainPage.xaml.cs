namespace TaxApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculateClicked(object sender, EventArgs e)
        {
            if (float.TryParse(AmountEntry.Text, out float amount))
            {
                var result = new TaxCalc
                {
                    Betrag = amount,
                    IsNetto = NettoRadioButton.IsChecked,
                    UstProzent = TaxRatePicker.SelectedItem.ToString() switch
                    {
                        "8 Prozent" => 0.08f,
                        "3.5 Prozent" => 0.035f,
                        "2.5 Prozent" => 0.025f,
                        _ => 0.0f
                    }
                };

                result.CalcResult();

                await Navigation.PushAsync(new ResultPage(result));
            }
            else
            {
                ResultLabel.Text = "Bitte geben Sie einen gültigen Betrag ein.";
            }
        }
    }

}
