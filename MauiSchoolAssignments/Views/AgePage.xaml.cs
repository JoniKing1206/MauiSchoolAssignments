namespace MauiSchoolAssignments.Views;

public partial class AgePage : ContentPage
{
    public AgePage()
    {
        InitializeComponent();
    }

    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        int age;
        int newAge;

        if (int.TryParse(AgeEntry.Text, out age))
        {
            newAge = age + 10;

            ResultLabel.Text =
                NameEntry.Text + ", in 10 years you will be " + newAge;
        }
        else
        {
            ResultLabel.Text = "Please enter a valid age.";
        }
    }
}