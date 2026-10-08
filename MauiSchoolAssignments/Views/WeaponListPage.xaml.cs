using MauiSchoolAssignments.Models;

namespace MauiSchoolAssignments.Views;

public partial class WeaponListPage : ContentPage
{
    private List<Weapon> weapons;

    public WeaponListPage()
    {
        InitializeComponent();

        weapons = WeaponCatalog.Weapons.Values.ToList();

        ShowWeapons();
    }

    private void ShowWeapons()
    {
        HorizontalStackLayout weaponLayout;
        Label nameLabel;
        Label damageLabel;
        Label ammoLabel;

        listWeapons.Children.Clear();

        foreach (Weapon weapon in weapons)
        {
            weaponLayout = new HorizontalStackLayout();
            weaponLayout.Spacing = 15;
            weaponLayout.Padding = 10;

            nameLabel = new Label();
            nameLabel.Text = weapon.Name;
            nameLabel.FontAttributes = FontAttributes.Bold;
            nameLabel.WidthRequest = 100;
            nameLabel.VerticalOptions = LayoutOptions.Center;

            damageLabel = new Label();
            damageLabel.Text = "Damage: " + weapon.Damage;
            damageLabel.WidthRequest = 100;
            damageLabel.VerticalOptions = LayoutOptions.Center;

            ammoLabel = new Label();
            ammoLabel.Text = "Ammo: " + weapon.Ammo;
            ammoLabel.VerticalOptions = LayoutOptions.Center;

            weaponLayout.Children.Add(nameLabel);
            weaponLayout.Children.Add(damageLabel);
            weaponLayout.Children.Add(ammoLabel);

            listWeapons.Children.Add(weaponLayout);
        }
    }
}