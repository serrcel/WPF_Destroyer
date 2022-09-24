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
        private Page loadPost =  new LoadPost();
        private Page settings = new Settings();
        private Page _CurPage = new LoadPost();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
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
