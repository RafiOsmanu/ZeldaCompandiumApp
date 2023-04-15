using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ZeldaCompandiumApp.Model;
using ZeldaCompandiumApp.Repository;
using ZeldaCompandiumApp.View;

namespace ZeldaCompandiumApp.ViewModel
{
    internal class OverViewPageVM : ObservableObject
    {

        public string CommandText
        {
            get
            {
                if (IsJsonLocal) //overView page -> go to details page
                {
                    return "TO SERVER";
                }
                else
                {
                    return "TO LOCAL";
                }
            }

        }

        private List<Monster> _monsters;

        public List<Monster> Monsters

        {
            get => _monsters
;
            set => SetProperty(ref _monsters, value);
        }

        private Monster _selectedMonster;

        public Monster SelectedMonster
        {
            get => _selectedMonster
;
            set => SetProperty(ref _selectedMonster, value);
        }

        public RelayCommand SwitchJson { get; private set; }

        private bool _isJsonLocal = true;
        public bool IsJsonLocal
        {
            get { return _isJsonLocal; }
            set
            {
                _isJsonLocal = value;
                OnPropertyChanged(nameof(IsJsonLocal));
            }
        }



        public OverViewPageVM() 
        {
            Monsters = MonsterRepository.GetMonsters();
            SwitchJson = new RelayCommand(() => SwitchJsonFile()); 
        }

        public void SwitchJsonFile()
        {
            IsJsonLocal = !IsJsonLocal;

            if(IsJsonLocal) 
            {
                Monsters = MonsterRepository.GetMonsters();
                OnPropertyChanged(nameof(CommandText));
            }
            else
            {
                Monsters = MonsterRepositoryServer.GetMonsters();
                OnPropertyChanged(nameof(CommandText));
            }
        }

    }
}
