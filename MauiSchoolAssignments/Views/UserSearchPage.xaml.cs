using MauiSchoolAssignments.Models;

namespace MauiSchoolAssignments.Views;

public partial class UserSearchPage : ContentPage
{
    private List<User> users;

    public UserSearchPage()
    {
        InitializeComponent();

        users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Daniel",
                Email = "daniel@example.com",
                Password = "1234",
                BirthDate = new DateTime(2008, 1, 10)
            },

            new User
            {
                Id = 2,
                Name = "Noa",
                Email = "noa@example.com",
                Password = "1234",
                BirthDate = new DateTime(2007, 2, 15)
            },

            new User
            {
                Id = 3,
                Name = "David",
                Email = "david@example.com",
                Password = "1234",
                BirthDate = new DateTime(2008, 3, 20)
            },

            new User
            {
                Id = 4,
                Name = "Maya",
                Email = "maya@example.com",
                Password = "1234",
                BirthDate = new DateTime(2007, 4, 12)
            },

            new User
            {
                Id = 5,
                Name = "Yonatan",
                Email = "yonatan@example.com",
                Password = "1234",
                BirthDate = new DateTime(2008, 5, 25)
            },

            new User
            {
                Id = 6,
                Name = "Sarah",
                Email = "sarah@example.com",
                Password = "1234",
                BirthDate = new DateTime(2007, 6, 18)
            },

            new User
            {
                Id = 7,
                Name = "Ariel",
                Email = "ariel@example.com",
                Password = "1234",
                BirthDate = new DateTime(2008, 7, 9)
            },

            new User
            {
                Id = 8,
                Name = "Dana",
                Email = "dana@example.com",
                Password = "1234",
                BirthDate = new DateTime(2007, 8, 14)
            },

            new User
            {
                Id = 9,
                Name = "Eli",
                Email = "eli@example.com",
                Password = "1234",
                BirthDate = new DateTime(2008, 9, 5)
            },

            new User
            {
                Id = 10,
                Name = "Roni",
                Email = "roni@example.com",
                Password = "1234",
                BirthDate = new DateTime(2007, 10, 22)
            }
        };
    }

    private void SearchButton_Clicked(object sender, EventArgs e)
    {
        string searchText;
        string resultText;
        bool userFound;

        searchText = SearchEntry.Text;

        if (string.IsNullOrWhiteSpace(searchText))
        {
            ResultLabel.Text = "Please enter a name.";
            return;
        }

        resultText = "";
        userFound = false;

        foreach (User user in users)
        {
            if (user.Name.Contains(
                searchText,
                StringComparison.OrdinalIgnoreCase))
            {
                resultText +=
                    "ID: " + user.Id + "\n" +
                    "Name: " + user.Name + "\n" +
                    "Email: " + user.Email + "\n" +
                    "Birth date: " +
                    user.BirthDate.ToShortDateString() +
                    "\n\n";

                userFound = true;
            }
        }

        if (userFound)
        {
            ResultLabel.Text = resultText;
        }
        else
        {
            ResultLabel.Text = "No users were found.";
        }
    }
}