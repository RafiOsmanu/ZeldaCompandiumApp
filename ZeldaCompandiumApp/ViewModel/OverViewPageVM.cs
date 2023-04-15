using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaCompandiumApp.Model;
using ZeldaCompandiumApp.Repository;

namespace ZeldaCompandiumApp.ViewModel
{
    internal class OverViewPageVM : ObservableObject
    {

        private List<Monster> _monsters;

        public List<Monster> Monsters

        {
            get => _monsters
;
            set => SetProperty(ref _monsters, value);
        }

        private List<String> _monstersImage;

        public List<String> MonstersImage

        {
            get => _monstersImage
;
            set => SetProperty(ref _monstersImage, value);
        }

        private List<String> _monstersNames;
        public List<String> MonstersNames

        {
            get => _monstersNames
;
            set => SetProperty(ref _monstersNames, value);
        }


        public OverViewPageVM() 
        {
            Monsters = MonsterRepository.GetMonsters();
            MonstersImage = MonsterRepository.GetMonsterImages();
            MonstersNames = MonsterRepository.GetMonsterNames();
        }

    }
}
