using Microsoft.Maui.Layouts;

namespace MauiSchoolAssignments.Views;

public partial class SliderCandlesPage : ContentPage
{
    private Entry nameEntry;
    private Label ageLabel;
    private Label resultLabel;
    private Slider ageSlider;
    private FlexLayout candlesLayout;

    public SliderCandlesPage()
    {
        VerticalStackLayout mainLayout;
        ScrollView scrollView;

        InitializeComponent();

        mainLayout = new VerticalStackLayout();
        mainLayout.Padding = 25;
        mainLayout.Spacing = 12;

        nameEntry = new Entry();
        nameEntry.Placeholder = "Enter your name";

        ageLabel = new Label();
        ageLabel.FontSize = 20;

        ageSlider = new Slider();
        ageSlider.Minimum = 0;
        ageSlider.Maximum = 30;
        ageSlider.Value = 10;
        ageSlider.ValueChanged += AgeSlider_ValueChanged;

        resultLabel = new Label();
        resultLabel.FontSize = 20;

        candlesLayout = new FlexLayout();
        candlesLayout.Wrap = FlexWrap.Wrap;
        candlesLayout.JustifyContent = FlexJustify.Center;

        mainLayout.Children.Add(nameEntry);
        mainLayout.Children.Add(ageLabel);
        mainLayout.Children.Add(ageSlider);
        mainLayout.Children.Add(resultLabel);
        mainLayout.Children.Add(candlesLayout);

        scrollView = new ScrollView();
        scrollView.Content = mainLayout;

        Content = scrollView;

        UpdateCandles(10);
    }

    private void AgeSlider_ValueChanged(
        object? sender,
        ValueChangedEventArgs e)
    {
        int age;

        age = (int)Math.Round(e.NewValue);

        UpdateCandles(age);
    }

    private void UpdateCandles(int age)
    {
        int newAge;
        int i;
        Image candleImage;

        newAge = age + 10;

        ageLabel.Text = "Selected age: " + age;

        resultLabel.Text =
            nameEntry.Text +
            ", in 10 years you will be " +
            newAge;

        candlesLayout.Children.Clear();

        for (i = 0; i < newAge; i++)
        {
            candleImage = new Image();
            candleImage.Source = "candle.png";
            candleImage.WidthRequest = 30;
            candleImage.HeightRequest = 45;

            candlesLayout.Children.Add(candleImage);
        }
    }
}