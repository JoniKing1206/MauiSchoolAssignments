using MauiSchoolAssignments.Views;

namespace MauiSchoolAssignments;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(AgePage),typeof(AgePage));

        Routing.RegisterRoute(nameof(CandlesPage),typeof(CandlesPage));

        Routing.RegisterRoute(nameof(UserSearchPage),typeof(UserSearchPage));

        Routing.RegisterRoute(nameof(WeaponSearchPage),typeof(WeaponSearchPage));

        Routing.RegisterRoute(nameof(SliderCandlesPage),typeof(SliderCandlesPage));

        Routing.RegisterRoute(nameof(WeaponListPage),typeof(WeaponListPage));
    }
}