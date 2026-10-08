using MauiSchoolAssignments.Views;

namespace MauiSchoolAssignments;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void AgePageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AgePage));
    }

    private async void CandlesPageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CandlesPage));
    }

    private async void UserSearchButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(UserSearchPage));
    }

    private async void WeaponSearchButton_Clicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WeaponSearchPage));
    }

    private async void SliderCandlesButton_Clicked(object? sender,EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SliderCandlesPage));
    }

    private async void WeaponListButton_Clicked(object? sender,EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WeaponListPage));
    }
}
