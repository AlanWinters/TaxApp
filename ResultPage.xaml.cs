namespace TaxApp;

public partial class ResultPage : ContentPage
{
    public ResultPage(TaxCalc result)
    {
        InitializeComponent();
        NetAmountLabel.Text = $"Nettobetrag : {result.BetragNetto:F2}";
        TaxAmountLabel.Text = $"Umsatzsteuer : {result.BetragUst:F2}";
        GrossAmountLabel.Text = $"Bruttobetrag : {result.BetragBrutto:F2}";
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}