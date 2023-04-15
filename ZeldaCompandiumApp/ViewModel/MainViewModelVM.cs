using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZeldaCompandiumApp.Model;
using ZeldaCompandiumApp.View;

namespace ZeldaCompandiumApp.ViewModel
{
    internal class MainViewModelVM : ObservableObject
    {
        public string CommandText
        {
            get
            {
                if (CurrentPage is OverViewPage) //overView page -> go to details page
                {
                    return "VIEW DETAILS";
                }
                else
                {
                    return "GO BACK";
                }
            }

        }

        private OverViewPage _mainPage;
        public OverViewPage MainPage
        {
            get => _mainPage;
            set => SetProperty(ref _mainPage, value);
        }

        private DetailPage _monsterPage;

        public DetailPage MonsterPage
        {
            get => _monsterPage;
            set => SetProperty(ref _monsterPage, value);
        }

        public Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                SetProperty(ref _currentPage, value);
                OnPropertyChanged(nameof(CommandText));

            }
        }

        private RelayCommand _switchPageCommand;

        public RelayCommand SwitchPageCommand
        {
            get
            {

                if (_switchPageCommand == null)
                {
                    // Initialize the RelayCommand with the SwitchPage function
                    _switchPageCommand = new RelayCommand(SwitchPage);
                }
                return _switchPageCommand;
            }
        }

        public void SwitchPage()
        {
            //check the current visible page type
            if (CurrentPage is OverViewPage) //overView page -> go to details page
            {
                //get the selected pokemon
                Monster selectedMonster = (MainPage.DataContext as OverViewPageVM).SelectedMonster;
                if (selectedMonster == null) return;

                //TODO:
                (MonsterPage.DataContext as DetailPageVM).CurrentMonster = selectedMonster;

                //Set the current page. TODO notify the view of the change
                CurrentPage = MonsterPage;


            }
            else
            {
                CurrentPage = MainPage;
            }
        }

        public MainViewModelVM()
        {
            MainPage = new OverViewPage();
            MonsterPage = new DetailPage();
            CurrentPage = MainPage;
        }


    }
}
