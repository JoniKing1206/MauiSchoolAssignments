using MauiSchoolAssignments.Models;

namespace MauiSchoolAssignments.Views;

public partial class WeaponSearchPage : ContentPage
{
    private Dictionary<string, Weapon> weapons;
    private List<User> users;

    public WeaponSearchPage()
    {
        InitializeComponent();

        weapons = WeaponCatalog.Weapons;

        users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Daniel",
                WeaponList = new List<Weapon>
                {
                    weapons["pistol"],
                    weapons["rifle"]
                }
            },

            new User
            {
                Id = 2,
                Name = "Noa",
                WeaponList = new List<Weapon>
                {
                    weapons["pistol"]
                }
            },

            new User
            {
                Id = 3,
                Name = "David",
                WeaponList = new List<Weapon>
                {
                    weapons["shotgun"]
                }
            },

            new User
            {
                Id = 4,
                Name = "Maya",
                WeaponList = new List<Weapon>
                {
                    weapons["rifle"]
                }
            },

            new User
            {
                Id = 5,
                Name = "Yonatan",
                WeaponList = new List<Weapon>
                {
                    weapons["shotgun"],
                    weapons["rifle"]
                }
            },

            new User
            {
                Id = 6,
                Name = "Sarah",
                WeaponList = new List<Weapon>
                {
                    weapons["pistol"],
                    weapons["shotgun"]
                }
            },

            new User
            {
                Id = 7,
                Name = "Ariel",
                WeaponList = new List<Weapon>
                {
                    weapons["rifle"]
                }
            },

            new User
            {
                Id = 8,
                Name = "Dana",
                WeaponList = new List<Weapon>
                {
                    weapons["pistol"]
                }
            },

            new User
            {
                Id = 9,
                Name = "Eli",
                WeaponList = new List<Weapon>
                {
                    weapons["shotgun"]
                }
            },

            new User
            {
                Id = 10,
                Name = "Roni",
                WeaponList = new List<Weapon>
                {
                    weapons["pistol"],
                    weapons["rifle"],
                    weapons["shotgun"]
                }
            }
        };
    }

    private void SearchButton_Clicked(
        object? sender,
        EventArgs e)
    {
        List<Weapon> selectedWeapons;
        List<User> matchingUsers;
        bool hasAllWeapons;
        string resultText;

        selectedWeapons = new List<Weapon>();
        matchingUsers = new List<User>();

        if (PistolCheckBox.IsChecked)
        {
            selectedWeapons.Add(weapons["pistol"]);
        }

        if (RifleCheckBox.IsChecked)
        {
            selectedWeapons.Add(weapons["rifle"]);
        }

        if (ShotgunCheckBox.IsChecked)
        {
            selectedWeapons.Add(weapons["shotgun"]);
        }

        if (selectedWeapons.Count == 0)
        {
            SearchResultLabel.Text =
                "Select at least one weapon.";

            return;
        }

        foreach (User user in users)
        {
            hasAllWeapons = true;

            foreach (Weapon weapon in selectedWeapons)
            {
                if (!user.WeaponList.Contains(weapon))
                {
                    hasAllWeapons = false;
                }
            }

            if (hasAllWeapons)
            {
                matchingUsers.Add(user);
            }
        }

        if (matchingUsers.Count == 0)
        {
            SearchResultLabel.Text =
                "No matching users were found.";

            return;
        }

        resultText = "Matching users:\n\n";

        foreach (User user in matchingUsers)
        {
            resultText += user.Name + "\n";
        }

        SearchResultLabel.Text = resultText;
    }
}