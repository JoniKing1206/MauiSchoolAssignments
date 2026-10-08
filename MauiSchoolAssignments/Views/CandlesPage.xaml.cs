using Microsoft.Maui.Layouts;

namespace MauiSchoolAssignments.Views;

public partial class CandlesPage : ContentPage
{
    private Entry nameEntry;
    private Entry ageEntry;
    private Label resultLabel;
    private FlexLayout candlesLayout;

    public CandlesPage()
    {
        InitializeComponent();

        VerticalStackLayout mainLayout;
        Button calculateButton;
        ScrollView scrollView;

        mainLayout = new VerticalStackLayout();
        mainLayout.Padding = 25;
        mainLayout.Spacing = 12;

        nameEntry = new Entry();
        nameEntry.Placeholder = "Enter your name";

        ageEntry = new Entry();
        ageEntry.Placeholder = "Enter your age";
        ageEntry.Keyboard = Keyboard.Numeric;

        calculateButton = new Button();
        calculateButton.Text = "Calculate Age";
        calculateButton.BackgroundColor = Colors.Brown;
        calculateButton.TextColor = Colors.White;
        calculateButton.Clicked += CalculateButton_Clicked;

        resultLabel = new Label();
        resultLabel.FontSize = 20;

        candlesLayout = new FlexLayout();
        candlesLayout.Wrap = FlexWrap.Wrap;
        candlesLayout.JustifyContent = FlexJustify.Center;

        mainLayout.Children.Add(nameEntry);
        mainLayout.Children.Add(ageEntry);
        mainLayout.Children.Add(calculateButton);
        mainLayout.Children.Add(resultLabel);
        mainLayout.Children.Add(candlesLayout);

        scrollView = new ScrollView();
        scrollView.Content = mainLayout;

        Content = scrollView;
    }

    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        int age;
        int newAge;
        int i;
        Image candleImage;

        candlesLayout.Children.Clear();

        if (int.TryParse(ageEntry.Text, out age))
        {
            newAge = age + 10;

            resultLabel.Text =
                nameEntry.Text + ", in 10 years you will be " + newAge;

            for (i = 0; i < newAge; i++)
            {
                candleImage = new Image();
                candleImage.Source = "candle.png";
                candleImage.WidthRequest = 30;
                candleImage.HeightRequest = 45;

                candlesLayout.Children.Add(candleImage);
            }
        }
        else
        {
            resultLabel.Text = "Please enter a valid age.";
        }
    }
}