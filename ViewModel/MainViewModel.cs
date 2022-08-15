using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Destroyer.View;

namespace WPF_Destroyer.ViewModel
{
    internal class MainViewModel: ViewModelBase
    {
        private Page chngTraf = new ChangeTraf();
        private Page deleteGarb = new DeleteGarbagge();
        private Page loadPost =  new LoadPost();
        private Page settings = new Settings();
        private Page _CurPage = new LoadPost();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenCtPage
        {
            get
            {
                return new RelayCommand(() => CurPage = chngTraf);
            }
        }

        public ICommand OpenDtPage
        {
            get
            {
                return new RelayCommand(() => CurPage = deleteGarb);
            }
        }
        public ICommand OpenLpPage
        {
            get
            {
                return new RelayCommand(() => CurPage = loadPost);
            }
        }
        public ICommand OpenStPage
        {
            get
            {
                return new RelayCommand(() => CurPage = settings);
            }
        }
    }
}
