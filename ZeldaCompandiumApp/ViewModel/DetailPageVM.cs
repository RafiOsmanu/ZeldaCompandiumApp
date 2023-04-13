using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaCompandiumApp.Model;

namespace ZeldaCompandiumApp.ViewModel
{
    internal class DetailPageVM : ObservableObject 
    {
        private Monster _CurrentMonster;

        public Monster CurrentMonster
        {
            get => _CurrentMonster;
            set => SetProperty(ref _CurrentMonster, value);
        }

        public DetailPageVM()
        {
            CurrentMonster = new Monster();

            CurrentMonster.Image = "https://botw-compendium.herokuapp.com/api/v2/entry/snow_octorok/image";
            CurrentMonster.Name = "002 Majoras Nightmare";
            CurrentMonster.Description = "These octopus-like monsters live in snowy fields and disguise themselves as grass. When someone wanders by, they spring into action and attack by spitting snowballs.";
            CurrentMonster.Common_locations = new string[]{ "Hyrule Field", "Deep Akkata","Salty Springs"};
        }

    }
}
