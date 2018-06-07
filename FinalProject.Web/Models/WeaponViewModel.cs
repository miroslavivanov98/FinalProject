using FinalProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Web.Models
{
    public class WeaponViewModel : BaseModel
    {
        public Weapon Weapon { get; set; }
        public List<Specification> Specs { get; set; }

        public WeaponViewModel(Weapon Weapon)
        {
            Specs = new List<Specification>();

            Specs.Add(new Specification() { Name = "Производител", Value = Weapon.Manafacturer.Name});
            Specs.Add(new Specification() { Name = "Модел", Value = Weapon.Model });
            Specs.Add(new Specification() { Name = "Калибър", Value = Weapon.Caliber });
            Specs.Add(new Specification() { Name = "Тегло", Value = Weapon.Weight + "кг" });
            Specs.Add(new Specification() { Name = "Дължина на цевта", Value = Weapon.BarrelLength+"см" });
            Specs.Add(new Specification() { Name = "Цена", Value = Weapon.Price + "лв" });

            this.Weapon = Weapon;
        }
    }

    public struct Specification
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}