using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSchoolAssignments.Models;

public static class WeaponCatalog
{
    public static Dictionary<string, Weapon> Weapons { get; } =
        new Dictionary<string, Weapon>
        {
            {
                "pistol",
                new Weapon
                {
                    Name = "Pistol",
                    Damage = 20,
                    Ammo = 12
                }
            },

            {
                "rifle",
                new Weapon
                {
                    Name = "Rifle",
                    Damage = 40,
                    Ammo = 30
                }
            },

            {
                "shotgun",
                new Weapon
                {
                    Name = "Shotgun",
                    Damage = 80,
                    Ammo = 8
                }
            }
        };
}